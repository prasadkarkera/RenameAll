using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace Rename
{
    public partial class LogView : Form
    {
        public LogView()
        {
            InitializeComponent();
        }

        private void UndoSelectedButton_Click(object sender, EventArgs e)
        {
            //RegistryKey rootkey, license;

            //rootkey = Registry.LocalMachine.OpenSubKey("Software");
            //license = rootkey.OpenSubKey("RenLis");

            if (MessageBox.Show("Do you wish to undo the selected changes?", "Undo Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string log = Properties.Settings.Default.logger;
                for (int i = 0; i < LoglistView1.SelectedItems.Count; i++)
                {
                    if (LoglistView1.SelectedItems[i].SubItems[3].Text == "Possible")
                    {
                        File.Move(LoglistView1.SelectedItems[i].SubItems[2].Text, LoglistView1.SelectedItems[i].SubItems[1].Text);
                        
                        if (log == "yes")
                            LogMessage.LogMsg(LoglistView1.SelectedItems[i].SubItems[2].Text + " Renamed to " + LoglistView1.SelectedItems[i].SubItems[1].Text, LogMessage.LogType.Info);
                    }
                }
                MessageBox.Show("The selected changes have been undone.", "Undo Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LogView_Load(object sender, EventArgs e)
        {
            //RegistryKey rootkey, license;

            //rootkey = Registry.LocalMachine.OpenSubKey("Software");
            //license = rootkey.OpenSubKey("RenLis");
            string log = Properties.Settings.Default.logger;
            if (log == "no")
                label1.Visible = true;   //Display message to enable logging

            LogReader logread = new LogReader();

            logread.Log();


            DateTimeCol.ListView.Items.Clear();
            renamedFromCol.ListView.Items.Clear();
            RenamedToCol.ListView.Items.Clear();
            PossibilityCol.ListView.Items.Clear();

            //To generated the second tab log status
            for (int i = 0; i < Form1.fromPath.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(Form1.dateTime[i].ToString());
                lvi.SubItems.Add(Form1.fromPath[i].ToString());
                lvi.SubItems.Add(Form1.toPath[i].ToString());
                lvi.SubItems.Add(Form1.exists[i].ToString());
                LoglistView1.Items.Add(lvi);
            }

            Form1.fromPath.Clear();
            Form1.toPath.Clear();
            Form1.exists.Clear();
            Form1.dateTime.Clear();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}