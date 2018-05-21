using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Rename
{
	/// <summary>
	/// Summary description for Preferences.
	/// </summary>
	public class Preferences : System.Windows.Forms.Form
	{
		private System.Windows.Forms.CheckBox StopLogcheckBox;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelButton;
        private RadioButton RemoveDigitsStartRadio;
        private RadioButton RemoveDigitsEndRadio;
        private RadioButton RemoveDigitsAllRadio;
        private RadioButton RemoveSpaceStartRadio;
        private RadioButton RemoveSpaceEndRadio;
        private RadioButton RemoveSpaceAllRadio;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton RemoveSpaceBothRadio;
        private RadioButton RemoveDigitsBothRadio;
        private GroupBox groupBox3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Preferences()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.StopLogcheckBox = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.RemoveDigitsStartRadio = new System.Windows.Forms.RadioButton();
            this.RemoveDigitsEndRadio = new System.Windows.Forms.RadioButton();
            this.RemoveDigitsAllRadio = new System.Windows.Forms.RadioButton();
            this.RemoveSpaceStartRadio = new System.Windows.Forms.RadioButton();
            this.RemoveSpaceEndRadio = new System.Windows.Forms.RadioButton();
            this.RemoveSpaceAllRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoveSpaceBothRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoveDigitsBothRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // StopLogcheckBox
            // 
            this.StopLogcheckBox.Location = new System.Drawing.Point(96, 41);
            this.StopLogcheckBox.Name = "StopLogcheckBox";
            this.StopLogcheckBox.Size = new System.Drawing.Size(362, 37);
            this.StopLogcheckBox.TabIndex = 0;
            this.StopLogcheckBox.Text = "Do not create log file";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(590, 762);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(135, 52);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(319, 762);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(135, 52);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // RemoveDigitsStartRadio
            // 
            this.RemoveDigitsStartRadio.AutoSize = true;
            this.RemoveDigitsStartRadio.Location = new System.Drawing.Point(96, 90);
            this.RemoveDigitsStartRadio.Name = "RemoveDigitsStartRadio";
            this.RemoveDigitsStartRadio.Size = new System.Drawing.Size(553, 33);
            this.RemoveDigitsStartRadio.TabIndex = 3;
            this.RemoveDigitsStartRadio.TabStop = true;
            this.RemoveDigitsStartRadio.Text = "Remove digits occuring at the start of file names";
            this.RemoveDigitsStartRadio.UseVisualStyleBackColor = true;
            // 
            // RemoveDigitsEndRadio
            // 
            this.RemoveDigitsEndRadio.AutoSize = true;
            this.RemoveDigitsEndRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemoveDigitsEndRadio.Location = new System.Drawing.Point(96, 140);
            this.RemoveDigitsEndRadio.Name = "RemoveDigitsEndRadio";
            this.RemoveDigitsEndRadio.Size = new System.Drawing.Size(557, 33);
            this.RemoveDigitsEndRadio.TabIndex = 4;
            this.RemoveDigitsEndRadio.TabStop = true;
            this.RemoveDigitsEndRadio.Text = "Remove digits occurring at the end of file names";
            this.RemoveDigitsEndRadio.UseVisualStyleBackColor = true;
            // 
            // RemoveDigitsAllRadio
            // 
            this.RemoveDigitsAllRadio.AutoSize = true;
            this.RemoveDigitsAllRadio.Location = new System.Drawing.Point(96, 41);
            this.RemoveDigitsAllRadio.Name = "RemoveDigitsAllRadio";
            this.RemoveDigitsAllRadio.Size = new System.Drawing.Size(387, 33);
            this.RemoveDigitsAllRadio.TabIndex = 5;
            this.RemoveDigitsAllRadio.TabStop = true;
            this.RemoveDigitsAllRadio.Text = " Remove all occurrence of digits";
            this.RemoveDigitsAllRadio.UseVisualStyleBackColor = true;
            // 
            // RemoveSpaceStartRadio
            // 
            this.RemoveSpaceStartRadio.AutoSize = true;
            this.RemoveSpaceStartRadio.Location = new System.Drawing.Point(96, 112);
            this.RemoveSpaceStartRadio.Name = "RemoveSpaceStartRadio";
            this.RemoveSpaceStartRadio.Size = new System.Drawing.Size(548, 33);
            this.RemoveSpaceStartRadio.TabIndex = 6;
            this.RemoveSpaceStartRadio.TabStop = true;
            this.RemoveSpaceStartRadio.Text = "Remove space occuring at the start of file name";
            this.RemoveSpaceStartRadio.UseVisualStyleBackColor = true;
            // 
            // RemoveSpaceEndRadio
            // 
            this.RemoveSpaceEndRadio.AutoSize = true;
            this.RemoveSpaceEndRadio.Location = new System.Drawing.Point(96, 162);
            this.RemoveSpaceEndRadio.Name = "RemoveSpaceEndRadio";
            this.RemoveSpaceEndRadio.Size = new System.Drawing.Size(556, 33);
            this.RemoveSpaceEndRadio.TabIndex = 7;
            this.RemoveSpaceEndRadio.TabStop = true;
            this.RemoveSpaceEndRadio.Text = "Remove space occuring at the end of file names";
            this.RemoveSpaceEndRadio.UseVisualStyleBackColor = true;
            // 
            // RemoveSpaceAllRadio
            // 
            this.RemoveSpaceAllRadio.AutoSize = true;
            this.RemoveSpaceAllRadio.Location = new System.Drawing.Point(96, 62);
            this.RemoveSpaceAllRadio.Name = "RemoveSpaceAllRadio";
            this.RemoveSpaceAllRadio.Size = new System.Drawing.Size(400, 33);
            this.RemoveSpaceAllRadio.TabIndex = 8;
            this.RemoveSpaceAllRadio.TabStop = true;
            this.RemoveSpaceAllRadio.Text = "Remove all occurrence of spaces";
            this.RemoveSpaceAllRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveSpaceBothRadio);
            this.groupBox1.Controls.Add(this.RemoveSpaceStartRadio);
            this.groupBox1.Controls.Add(this.RemoveSpaceAllRadio);
            this.groupBox1.Controls.Add(this.RemoveSpaceEndRadio);
            this.groupBox1.Location = new System.Drawing.Point(77, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 282);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove Spaces";
            // 
            // RemoveSpaceBothRadio
            // 
            this.RemoveSpaceBothRadio.AutoSize = true;
            this.RemoveSpaceBothRadio.Location = new System.Drawing.Point(96, 211);
            this.RemoveSpaceBothRadio.Name = "RemoveSpaceBothRadio";
            this.RemoveSpaceBothRadio.Size = new System.Drawing.Size(622, 33);
            this.RemoveSpaceBothRadio.TabIndex = 9;
            this.RemoveSpaceBothRadio.TabStop = true;
            this.RemoveSpaceBothRadio.Text = "Remove space occurring at start and end of file names";
            this.RemoveSpaceBothRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoveDigitsBothRadio);
            this.groupBox2.Controls.Add(this.RemoveDigitsAllRadio);
            this.groupBox2.Controls.Add(this.RemoveDigitsEndRadio);
            this.groupBox2.Controls.Add(this.RemoveDigitsStartRadio);
            this.groupBox2.Location = new System.Drawing.Point(77, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(917, 269);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Digits";
            // 
            // RemoveDigitsBothRadio
            // 
            this.RemoveDigitsBothRadio.AutoSize = true;
            this.RemoveDigitsBothRadio.Location = new System.Drawing.Point(96, 190);
            this.RemoveDigitsBothRadio.Name = "RemoveDigitsBothRadio";
            this.RemoveDigitsBothRadio.Size = new System.Drawing.Size(615, 33);
            this.RemoveDigitsBothRadio.TabIndex = 6;
            this.RemoveDigitsBothRadio.TabStop = true;
            this.RemoveDigitsBothRadio.Text = "Remove digits occurring at start and end of file names";
            this.RemoveDigitsBothRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StopLogcheckBox);
            this.groupBox3.Location = new System.Drawing.Point(77, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(914, 103);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // Preferences
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(12, 28);
            this.ClientSize = new System.Drawing.Size(1045, 865);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Preferences";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void OkButton_Click(object sender, System.EventArgs e)
		{
            //RegistryKey rootkey,license;

            //rootkey = Registry.LocalMachine.OpenSubKey("Software",true);
            //license = rootkey.OpenSubKey("RenLis",true);

            if (StopLogcheckBox.Checked)
                Properties.Settings.Default.logger = "no";
            //license.SetValue("Logger","no");
            else
                Properties.Settings.Default.logger = "yes";
                //license.SetValue("Logger","yes");

            //Set the Remove digits preference in Registry
            if (RemoveDigitsAllRadio.Checked == true)
                Properties.Settings.Default.removeDigit = "All";
            else if (RemoveDigitsStartRadio.Checked == true)
                Properties.Settings.Default.removeDigit = "Start";
            else if (RemoveDigitsEndRadio.Checked == true)
                Properties.Settings.Default.removeDigit = "End";
            else if (RemoveDigitsBothRadio.Checked == true)
                Properties.Settings.Default.removeDigit = "Both";

            //Set the Remove space preference in Registry
            if (RemoveSpaceAllRadio.Checked == true)
                Properties.Settings.Default.removeSpace = "All";
            else if (RemoveSpaceStartRadio.Checked == true)
                Properties.Settings.Default.removeSpace = "Start";
            else if (RemoveSpaceEndRadio.Checked == true)
                Properties.Settings.Default.removeSpace = "End";
            else if (RemoveSpaceBothRadio.Checked == true)
                Properties.Settings.Default.removeSpace = "Both";

            Properties.Settings.Default.Save();

   //         license.Close();
			//rootkey.Close();

			this.Close();
		}

		private void ApplyButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Preferences_Load(object sender, System.EventArgs e)
		{
			//RegistryKey rootkey,license;

			//rootkey = Registry.LocalMachine.OpenSubKey("Software",true);
			//license = rootkey.OpenSubKey("RenLis",true);

			if(Properties.Settings.Default.logger == "yes")  
				StopLogcheckBox.Checked = false;
			else
				StopLogcheckBox.Checked = true;

            if (Properties.Settings.Default.removeSpace == "All")
                RemoveSpaceAllRadio.Checked = true;
            else
                RemoveSpaceAllRadio.Checked = false;

            if (Properties.Settings.Default.removeSpace == "Start")
                RemoveSpaceStartRadio.Checked = true;
            else
                RemoveSpaceStartRadio.Checked = false;

            if (Properties.Settings.Default.removeSpace == "End")
                RemoveSpaceEndRadio.Checked = true;
            else
                RemoveSpaceEndRadio.Checked = false;

            if (Properties.Settings.Default.removeSpace == "Both")
                RemoveSpaceBothRadio.Checked = true;
            else
                RemoveSpaceBothRadio.Checked = false;

            if (Properties.Settings.Default.removeDigit == "All")
                RemoveDigitsAllRadio.Checked = true;
            else
                RemoveDigitsAllRadio.Checked = false;

            if (Properties.Settings.Default.removeDigit == "Start")
                RemoveDigitsStartRadio.Checked = true;
            else
                RemoveDigitsStartRadio.Checked = false;

            if (Properties.Settings.Default.removeDigit == "End")
                RemoveDigitsEndRadio.Checked = true;
            else
                RemoveDigitsEndRadio.Checked = false;

            if (Properties.Settings.Default.removeDigit == "Both")
                RemoveDigitsBothRadio.Checked = true;
            else
                RemoveDigitsBothRadio.Checked = false;

			//license.Close();
			//rootkey.Close();
		}
	}
}
