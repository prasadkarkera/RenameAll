using System;
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Reflection;
using System.Configuration;
using Microsoft.Win32;
using MsdnMag;

namespace Rename
{
	/// <summary>
	/// Summary description for Form1.
    /// This is the main screen which user interacts with
	/// </summary>
	/// 
	

	public class Form1 : System.Windows.Forms.Form
	{ 
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button Addtext;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button removefromlist;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.Button AddFileTypes;
		private System.Windows.Forms.Button RemoveFileType;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox FilesPresentListBox;
		private System.Windows.Forms.Button ToRight;
		private System.Windows.Forms.Button ToLeft;
		private System.Windows.Forms.ListBox FilesSelected;
		private System.Windows.Forms.CheckBox SelectIndividualCheckBox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox SpaveRemoveCheckbox;
		private System.Windows.Forms.CheckBox RemoveDigitsCheckbox;
		private System.Windows.Forms.CheckBox RemoveAlphabetsCheckbox;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox TrunDataBeforeTextBox;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox TrunDataAfterCheckbox;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.RadioButton ToUpperCase;
		private System.Windows.Forms.RadioButton ToLowerCase;
		private System.Windows.Forms.RadioButton ToTitleCase;

		public static bool removeAlphabetsCheck;
		public static bool removeDigitsCheck;
		public static bool removeSpaceCheck;
		public static bool toUpperCheck;
		public static bool toLowerCheck;
		public static bool toTitleCheck;
        public static bool prefixNumberCheckbox;
        public static bool postfixNumberCheckbox;
		public static string truncateDataBefore;
		public static string truncateDataAfter;
        public static string prefixTextbox;
        public static string postfixTextbox;
        public static int prefixPadLength;
        public static int postfixPadLength;
		public char [] digits = {'0','1','2','3','4','5','6','7','8','9'};
		public char [] alphabets = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
		public static bool changeCase;
        public static bool remove_DSA;
		public static bool selectIndFilesCheckbox;
		public static ArrayList renamedTo = new ArrayList();
        public static ArrayList renamedFrom = new ArrayList();
        public static ArrayList successStatus = new ArrayList();
		public static ArrayList selectedFiles = new ArrayList();
		public static ArrayList renameFromText = new ArrayList();
		public static ArrayList renameToText = new ArrayList();
        public static ArrayList fromPath = new ArrayList();
        public static ArrayList toPath = new ArrayList();
        public static ArrayList exists = new ArrayList();
        public static ArrayList dateTime = new ArrayList();
        
        
		public static string log;

		private System.Windows.Forms.CheckBox ChangeCaseCheckbox;
		private System.Windows.Forms.CheckBox RemoveDSA;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MenuItem UndoMenu;
		private System.Windows.Forms.ListView LogRenamedlist;
		private System.Windows.Forms.ColumnHeader OriginalColumn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MenuItem RegisterMenuItem;
        private ColumnHeader Status;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupBox9;
        private TextBox PostfixTextbox;
        private GroupBox groupBox8;
        private TextBox PrefixTextbox;
        private CheckBox PreficNumberCheckBox;
        private CheckBox PostfixNumberCheckbox;
        private GroupBox PostfixNumbers;
        private GroupBox PrefixNumbers;
        private TextBox PostfixPadLength;
        private TextBox PrefixPadLength;
        private Label Postfix1;
        private Label Postfix2;
        private Label Prefix2;
        private Label Prefix1;
        private CheckBox PadPostficCheck;
        private CheckBox PadPrefixCheck;
        private Button Preview;
        private TabPage PreviewTab;
        private ListView LogPreviewlist;
        private ColumnHeader OriginalFileNameP;
        private ColumnHeader RenamedToP;
        private ColumnHeader StatusP;
        private MenuItem menuItem5;
        private MenuItem menuItem11;
        private MenuItem menuItem13;
        private MenuItem menuItem12;
        private MenuItem LoadPreferences;
        private SaveFileDialog saveFilePreferencesDialog;
        private OpenFileDialog openPrefencesFileDialog;
        private MenuItem ResetAllSettings;
        private MenuItem menuItem14;
		private System.Windows.Forms.ColumnHeader NewColumn;
		

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//For the splash screen
			/*Thread th = new Thread(new ThreadStart(DoSplash));
			th.Start();
			Thread.Sleep(3000);
			th.Abort();
			Thread.Sleep(1000);*/
								
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void DoSplash()
		{
			Splash sp = new Splash();
			sp.ShowDialog();
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.LoadPreferences = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.UndoMenu = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.ResetAllSettings = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.RegisterMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Preview = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.removefromlist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Addtext = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ChangeCaseCheckbox = new System.Windows.Forms.CheckBox();
            this.ToTitleCase = new System.Windows.Forms.RadioButton();
            this.ToLowerCase = new System.Windows.Forms.RadioButton();
            this.ToUpperCase = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RemoveDSA = new System.Windows.Forms.CheckBox();
            this.RemoveDigitsCheckbox = new System.Windows.Forms.CheckBox();
            this.SpaveRemoveCheckbox = new System.Windows.Forms.CheckBox();
            this.RemoveAlphabetsCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveFileType = new System.Windows.Forms.Button();
            this.AddFileTypes = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.PostfixNumbers = new System.Windows.Forms.GroupBox();
            this.PadPostficCheck = new System.Windows.Forms.CheckBox();
            this.Postfix1 = new System.Windows.Forms.Label();
            this.Postfix2 = new System.Windows.Forms.Label();
            this.PostfixPadLength = new System.Windows.Forms.TextBox();
            this.PostfixNumberCheckbox = new System.Windows.Forms.CheckBox();
            this.PrefixNumbers = new System.Windows.Forms.GroupBox();
            this.PadPrefixCheck = new System.Windows.Forms.CheckBox();
            this.Prefix2 = new System.Windows.Forms.Label();
            this.Prefix1 = new System.Windows.Forms.Label();
            this.PrefixPadLength = new System.Windows.Forms.TextBox();
            this.PreficNumberCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.PostfixTextbox = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.PrefixTextbox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TrunDataBeforeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TrunDataAfterCheckbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectIndividualCheckBox = new System.Windows.Forms.CheckBox();
            this.ToLeft = new System.Windows.Forms.Button();
            this.ToRight = new System.Windows.Forms.Button();
            this.FilesSelected = new System.Windows.Forms.ListBox();
            this.FilesPresentListBox = new System.Windows.Forms.ListBox();
            this.PreviewTab = new System.Windows.Forms.TabPage();
            this.LogPreviewlist = new System.Windows.Forms.ListView();
            this.OriginalFileNameP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RenamedToP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LogRenamedlist = new System.Windows.Forms.ListView();
            this.OriginalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NewColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveFilePreferencesDialog = new System.Windows.Forms.SaveFileDialog();
            this.openPrefencesFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.PostfixNumbers.SuspendLayout();
            this.PrefixNumbers.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.PreviewTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1378, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Browse...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(19, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1325, 35);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(492, 1077);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Rename";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(794, 1077);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "&Undo";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem4,
            this.menuItem6,
            this.menuItem8});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem11,
            this.menuItem12,
            this.menuItem3});
            this.menuItem1.Text = "&File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuItem2.Text = "&Browse";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 1;
            this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem13});
            this.menuItem11.Text = "&Export";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 0;
            this.menuItem13.Text = "&Preferences to a file";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 2;
            this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.LoadPreferences});
            this.menuItem12.Text = "&Import";
            // 
            // LoadPreferences
            // 
            this.LoadPreferences.Index = 0;
            this.LoadPreferences.Text = "&Preferences from a file";
            this.LoadPreferences.Click += new System.EventHandler(this.LoadPreferences_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "E&xit";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.UndoMenu,
            this.menuItem14,
            this.menuItem10,
            this.menuItem5});
            this.menuItem4.Text = "&Edit";
            // 
            // UndoMenu
            // 
            this.UndoMenu.Enabled = false;
            this.UndoMenu.Index = 0;
            this.UndoMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
            this.UndoMenu.Text = "&Undo";
            this.UndoMenu.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 1;
            this.menuItem14.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftU;
            this.menuItem14.Text = "U&ndo from log";
            this.menuItem14.Visible = false;
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 2;
            this.menuItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.menuItem10.Text = "&Rename";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.menuItem5.Text = "&Preview";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click_1);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ResetAllSettings,
            this.menuItem7});
            this.menuItem6.Text = "&Options";
            // 
            // ResetAllSettings
            // 
            this.ResetAllSettings.Index = 0;
            this.ResetAllSettings.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.ResetAllSettings.Text = "R&eset All Settings";
            this.ResetAllSettings.Click += new System.EventHandler(this.ResetAllSettings_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "&Preferences";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 3;
            this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.RegisterMenuItem,
            this.menuItem9});
            this.menuItem8.Text = "&Help";
            // 
            // RegisterMenuItem
            // 
            this.RegisterMenuItem.Index = 0;
            this.RegisterMenuItem.Text = "&Register";
            this.RegisterMenuItem.Visible = false;
            this.RegisterMenuItem.Click += new System.EventHandler(this.RegisterMenuItem_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.Text = "&About";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.PreviewTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1736, 1213);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.Preview);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1716, 1156);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Preview
            // 
            this.Preview.Location = new System.Drawing.Point(1109, 1075);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(173, 54);
            this.Preview.TabIndex = 18;
            this.Preview.Text = "&Preview";
            this.Preview.UseVisualStyleBackColor = true;
            this.Preview.Click += new System.EventHandler(this.Preview_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(46, 437);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1596, 627);
            this.tabControl2.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(10, 47);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1576, 570);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Options";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.removefromlist);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Addtext);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(14, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 465);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replace";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(58, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "Find";
            // 
            // removefromlist
            // 
            this.removefromlist.Location = new System.Drawing.Point(422, 396);
            this.removefromlist.Name = "removefromlist";
            this.removefromlist.Size = new System.Drawing.Size(180, 50);
            this.removefromlist.TabIndex = 10;
            this.removefromlist.Text = "R&emove";
            this.removefromlist.Click += new System.EventHandler(this.removefromlist_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(365, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "Replace with";
            // 
            // Addtext
            // 
            this.Addtext.Location = new System.Drawing.Point(96, 396);
            this.Addtext.Name = "Addtext";
            this.Addtext.Size = new System.Drawing.Size(173, 50);
            this.Addtext.TabIndex = 8;
            this.Addtext.Text = "&Add";
            this.Addtext.Click += new System.EventHandler(this.Addtext_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(365, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(288, 35);
            this.textBox3.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.ItemHeight = 29;
            this.listBox2.Location = new System.Drawing.Point(365, 155);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(288, 178);
            this.listBox2.TabIndex = 5;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(58, 155);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 178);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 35);
            this.textBox2.TabIndex = 6;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ChangeCaseCheckbox);
            this.groupBox7.Controls.Add(this.ToTitleCase);
            this.groupBox7.Controls.Add(this.ToLowerCase);
            this.groupBox7.Controls.Add(this.ToUpperCase);
            this.groupBox7.Location = new System.Drawing.Point(739, 286);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(360, 224);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            // 
            // ChangeCaseCheckbox
            // 
            this.ChangeCaseCheckbox.Location = new System.Drawing.Point(14, 0);
            this.ChangeCaseCheckbox.Name = "ChangeCaseCheckbox";
            this.ChangeCaseCheckbox.Size = new System.Drawing.Size(224, 34);
            this.ChangeCaseCheckbox.TabIndex = 3;
            this.ChangeCaseCheckbox.Text = "Change Case";
            this.ChangeCaseCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ToTitleCase
            // 
            this.ToTitleCase.Enabled = false;
            this.ToTitleCase.Location = new System.Drawing.Point(38, 155);
            this.ToTitleCase.Name = "ToTitleCase";
            this.ToTitleCase.Size = new System.Drawing.Size(250, 52);
            this.ToTitleCase.TabIndex = 2;
            this.ToTitleCase.Text = "To Title Case";
            this.ToTitleCase.CheckedChanged += new System.EventHandler(this.ToTitleCase_CheckedChanged_1);
            // 
            // ToLowerCase
            // 
            this.ToLowerCase.Enabled = false;
            this.ToLowerCase.Location = new System.Drawing.Point(38, 103);
            this.ToLowerCase.Name = "ToLowerCase";
            this.ToLowerCase.Size = new System.Drawing.Size(250, 52);
            this.ToLowerCase.TabIndex = 1;
            this.ToLowerCase.Text = "To Lower Case";
            this.ToLowerCase.CheckedChanged += new System.EventHandler(this.ToLowerCase_CheckedChanged);
            // 
            // ToUpperCase
            // 
            this.ToUpperCase.Enabled = false;
            this.ToUpperCase.Location = new System.Drawing.Point(38, 52);
            this.ToUpperCase.Name = "ToUpperCase";
            this.ToUpperCase.Size = new System.Drawing.Size(250, 51);
            this.ToUpperCase.TabIndex = 0;
            this.ToUpperCase.Text = "To Upper Case";
            this.ToUpperCase.CheckedChanged += new System.EventHandler(this.ToUpperCase_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RemoveDSA);
            this.groupBox4.Controls.Add(this.RemoveDigitsCheckbox);
            this.groupBox4.Controls.Add(this.SpaveRemoveCheckbox);
            this.groupBox4.Controls.Add(this.RemoveAlphabetsCheckbox);
            this.groupBox4.Location = new System.Drawing.Point(739, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 224);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // RemoveDSA
            // 
            this.RemoveDSA.Location = new System.Drawing.Point(14, 0);
            this.RemoveDSA.Name = "RemoveDSA";
            this.RemoveDSA.Size = new System.Drawing.Size(159, 34);
            this.RemoveDSA.TabIndex = 13;
            this.RemoveDSA.Text = "Remove";
            this.RemoveDSA.CheckedChanged += new System.EventHandler(this.RemoveDSA_CheckedChanged);
            // 
            // RemoveDigitsCheckbox
            // 
            this.RemoveDigitsCheckbox.Enabled = false;
            this.RemoveDigitsCheckbox.Location = new System.Drawing.Point(38, 52);
            this.RemoveDigitsCheckbox.Name = "RemoveDigitsCheckbox";
            this.RemoveDigitsCheckbox.Size = new System.Drawing.Size(250, 51);
            this.RemoveDigitsCheckbox.TabIndex = 11;
            this.RemoveDigitsCheckbox.Text = "Remove Digits";
            this.RemoveDigitsCheckbox.CheckedChanged += new System.EventHandler(this.RemoveDigitsCheckbox_CheckedChanged);
            // 
            // SpaveRemoveCheckbox
            // 
            this.SpaveRemoveCheckbox.Enabled = false;
            this.SpaveRemoveCheckbox.Location = new System.Drawing.Point(38, 103);
            this.SpaveRemoveCheckbox.Name = "SpaveRemoveCheckbox";
            this.SpaveRemoveCheckbox.Size = new System.Drawing.Size(288, 52);
            this.SpaveRemoveCheckbox.TabIndex = 10;
            this.SpaveRemoveCheckbox.Text = "Remove spaces";
            this.SpaveRemoveCheckbox.CheckedChanged += new System.EventHandler(this.SpaveRemoveCheckbox_CheckedChanged);
            // 
            // RemoveAlphabetsCheckbox
            // 
            this.RemoveAlphabetsCheckbox.Enabled = false;
            this.RemoveAlphabetsCheckbox.Location = new System.Drawing.Point(38, 155);
            this.RemoveAlphabetsCheckbox.Name = "RemoveAlphabetsCheckbox";
            this.RemoveAlphabetsCheckbox.Size = new System.Drawing.Size(288, 52);
            this.RemoveAlphabetsCheckbox.TabIndex = 12;
            this.RemoveAlphabetsCheckbox.Text = "Remove Alphabets";
            this.RemoveAlphabetsCheckbox.CheckedChanged += new System.EventHandler(this.RemoveAlphabetsCheckbox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.RemoveFileType);
            this.groupBox2.Controls.Add(this.AddFileTypes);
            this.groupBox2.Controls.Add(this.listBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(1121, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 465);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter your File selection";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(58, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "File Extension";
            // 
            // RemoveFileType
            // 
            this.RemoveFileType.Location = new System.Drawing.Point(230, 396);
            this.RemoveFileType.Name = "RemoveFileType";
            this.RemoveFileType.Size = new System.Drawing.Size(180, 50);
            this.RemoveFileType.TabIndex = 3;
            this.RemoveFileType.Text = "Re&move";
            this.RemoveFileType.Click += new System.EventHandler(this.RemoveFileType_Click);
            // 
            // AddFileTypes
            // 
            this.AddFileTypes.Location = new System.Drawing.Point(19, 396);
            this.AddFileTypes.Name = "AddFileTypes";
            this.AddFileTypes.Size = new System.Drawing.Size(180, 50);
            this.AddFileTypes.TabIndex = 2;
            this.AddFileTypes.Text = "A&dd";
            this.AddFileTypes.Click += new System.EventHandler(this.AddFileTypes_Click);
            // 
            // listBox3
            // 
            this.listBox3.ItemHeight = 29;
            this.listBox3.Location = new System.Drawing.Point(58, 138);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(307, 178);
            this.listBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(58, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(307, 35);
            this.textBox4.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.PostfixNumbers);
            this.tabPage4.Controls.Add(this.PrefixNumbers);
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(10, 47);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1576, 570);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "More Options";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // PostfixNumbers
            // 
            this.PostfixNumbers.Controls.Add(this.PadPostficCheck);
            this.PostfixNumbers.Controls.Add(this.Postfix1);
            this.PostfixNumbers.Controls.Add(this.Postfix2);
            this.PostfixNumbers.Controls.Add(this.PostfixPadLength);
            this.PostfixNumbers.Controls.Add(this.PostfixNumberCheckbox);
            this.PostfixNumbers.Location = new System.Drawing.Point(850, 373);
            this.PostfixNumbers.Name = "PostfixNumbers";
            this.PostfixNumbers.Size = new System.Drawing.Size(672, 191);
            this.PostfixNumbers.TabIndex = 21;
            this.PostfixNumbers.TabStop = false;
            // 
            // PadPostficCheck
            // 
            this.PadPostficCheck.AutoSize = true;
            this.PadPostficCheck.Enabled = false;
            this.PadPostficCheck.Location = new System.Drawing.Point(70, 58);
            this.PadPostficCheck.Name = "PadPostficCheck";
            this.PadPostficCheck.Size = new System.Drawing.Size(227, 33);
            this.PadPostficCheck.TabIndex = 24;
            this.PadPostficCheck.Text = "Pad the numbers";
            this.PadPostficCheck.UseVisualStyleBackColor = true;
            this.PadPostficCheck.CheckedChanged += new System.EventHandler(this.PadPostficCheck_CheckedChanged);
            // 
            // Postfix1
            // 
            this.Postfix1.AutoSize = true;
            this.Postfix1.Location = new System.Drawing.Point(62, 129);
            this.Postfix1.Name = "Postfix1";
            this.Postfix1.Size = new System.Drawing.Size(378, 29);
            this.Postfix1.TabIndex = 23;
            this.Postfix1.Text = "Total length of numbers should be";
            this.Postfix1.Visible = false;
            // 
            // Postfix2
            // 
            this.Postfix2.AutoSize = true;
            this.Postfix2.Location = new System.Drawing.Point(559, 129);
            this.Postfix2.Name = "Postfix2";
            this.Postfix2.Size = new System.Drawing.Size(71, 29);
            this.Postfix2.TabIndex = 23;
            this.Postfix2.Text = "digits";
            this.Postfix2.Visible = false;
            // 
            // PostfixPadLength
            // 
            this.PostfixPadLength.Location = new System.Drawing.Point(478, 114);
            this.PostfixPadLength.MaxLength = 1;
            this.PostfixPadLength.Name = "PostfixPadLength";
            this.PostfixPadLength.Size = new System.Drawing.Size(67, 35);
            this.PostfixPadLength.TabIndex = 21;
            this.PostfixPadLength.Visible = false;
            // 
            // PostfixNumberCheckbox
            // 
            this.PostfixNumberCheckbox.AutoSize = true;
            this.PostfixNumberCheckbox.Location = new System.Drawing.Point(26, 0);
            this.PostfixNumberCheckbox.Name = "PostfixNumberCheckbox";
            this.PostfixNumberCheckbox.Size = new System.Drawing.Size(373, 33);
            this.PostfixNumberCheckbox.TabIndex = 19;
            this.PostfixNumberCheckbox.Text = "Postfix Incremental Numbering";
            this.PostfixNumberCheckbox.UseVisualStyleBackColor = true;
            this.PostfixNumberCheckbox.CheckedChanged += new System.EventHandler(this.PostfixNumberCheckbox_CheckedChanged);
            // 
            // PrefixNumbers
            // 
            this.PrefixNumbers.Controls.Add(this.PadPrefixCheck);
            this.PrefixNumbers.Controls.Add(this.Prefix2);
            this.PrefixNumbers.Controls.Add(this.Prefix1);
            this.PrefixNumbers.Controls.Add(this.PrefixPadLength);
            this.PrefixNumbers.Controls.Add(this.PreficNumberCheckBox);
            this.PrefixNumbers.Location = new System.Drawing.Point(50, 373);
            this.PrefixNumbers.Name = "PrefixNumbers";
            this.PrefixNumbers.Size = new System.Drawing.Size(711, 191);
            this.PrefixNumbers.TabIndex = 20;
            this.PrefixNumbers.TabStop = false;
            // 
            // PadPrefixCheck
            // 
            this.PadPrefixCheck.AutoSize = true;
            this.PadPrefixCheck.Enabled = false;
            this.PadPrefixCheck.Location = new System.Drawing.Point(46, 58);
            this.PadPrefixCheck.Name = "PadPrefixCheck";
            this.PadPrefixCheck.Size = new System.Drawing.Size(227, 33);
            this.PadPrefixCheck.TabIndex = 23;
            this.PadPrefixCheck.Text = "Pad the numbers";
            this.PadPrefixCheck.UseVisualStyleBackColor = true;
            this.PadPrefixCheck.CheckedChanged += new System.EventHandler(this.PadPrefixCheck_CheckedChanged);
            // 
            // Prefix2
            // 
            this.Prefix2.AutoSize = true;
            this.Prefix2.Location = new System.Drawing.Point(542, 129);
            this.Prefix2.Name = "Prefix2";
            this.Prefix2.Size = new System.Drawing.Size(71, 29);
            this.Prefix2.TabIndex = 22;
            this.Prefix2.Text = "digits";
            this.Prefix2.Visible = false;
            // 
            // Prefix1
            // 
            this.Prefix1.AutoSize = true;
            this.Prefix1.Location = new System.Drawing.Point(38, 129);
            this.Prefix1.Name = "Prefix1";
            this.Prefix1.Size = new System.Drawing.Size(378, 29);
            this.Prefix1.TabIndex = 21;
            this.Prefix1.Text = "Total length of numbers should be";
            this.Prefix1.Visible = false;
            // 
            // PrefixPadLength
            // 
            this.PrefixPadLength.Location = new System.Drawing.Point(454, 114);
            this.PrefixPadLength.MaxLength = 1;
            this.PrefixPadLength.Name = "PrefixPadLength";
            this.PrefixPadLength.Size = new System.Drawing.Size(74, 35);
            this.PrefixPadLength.TabIndex = 20;
            this.PrefixPadLength.Visible = false;
            // 
            // PreficNumberCheckBox
            // 
            this.PreficNumberCheckBox.AutoSize = true;
            this.PreficNumberCheckBox.Location = new System.Drawing.Point(22, 0);
            this.PreficNumberCheckBox.Name = "PreficNumberCheckBox";
            this.PreficNumberCheckBox.Size = new System.Drawing.Size(363, 33);
            this.PreficNumberCheckBox.TabIndex = 18;
            this.PreficNumberCheckBox.Text = "Prefix Incremental Numbering";
            this.PreficNumberCheckBox.UseVisualStyleBackColor = true;
            this.PreficNumberCheckBox.CheckedChanged += new System.EventHandler(this.PreficNumberCheckBox_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.PostfixTextbox);
            this.groupBox9.Location = new System.Drawing.Point(850, 211);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(672, 149);
            this.groupBox9.TabIndex = 17;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Postfix";
            // 
            // PostfixTextbox
            // 
            this.PostfixTextbox.Location = new System.Drawing.Point(96, 60);
            this.PostfixTextbox.Name = "PostfixTextbox";
            this.PostfixTextbox.Size = new System.Drawing.Size(487, 35);
            this.PostfixTextbox.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.PrefixTextbox);
            this.groupBox8.Location = new System.Drawing.Point(48, 211);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(713, 149);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Prefix";
            // 
            // PrefixTextbox
            // 
            this.PrefixTextbox.Location = new System.Drawing.Point(96, 60);
            this.PrefixTextbox.Name = "PrefixTextbox";
            this.PrefixTextbox.Size = new System.Drawing.Size(557, 35);
            this.PrefixTextbox.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TrunDataBeforeTextBox);
            this.groupBox5.Location = new System.Drawing.Point(48, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(710, 156);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Truncate Data Before";
            // 
            // TrunDataBeforeTextBox
            // 
            this.TrunDataBeforeTextBox.Location = new System.Drawing.Point(96, 69);
            this.TrunDataBeforeTextBox.Name = "TrunDataBeforeTextBox";
            this.TrunDataBeforeTextBox.Size = new System.Drawing.Size(557, 35);
            this.TrunDataBeforeTextBox.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TrunDataAfterCheckbox);
            this.groupBox6.Location = new System.Drawing.Point(850, 34);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(672, 156);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Truncate Data After";
            // 
            // TrunDataAfterCheckbox
            // 
            this.TrunDataAfterCheckbox.Location = new System.Drawing.Point(96, 69);
            this.TrunDataAfterCheckbox.Name = "TrunDataAfterCheckbox";
            this.TrunDataAfterCheckbox.Size = new System.Drawing.Size(487, 35);
            this.TrunDataAfterCheckbox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.SelectIndividualCheckBox);
            this.groupBox3.Controls.Add(this.ToLeft);
            this.groupBox3.Controls.Add(this.ToRight);
            this.groupBox3.Controls.Add(this.FilesSelected);
            this.groupBox3.Controls.Add(this.FilesPresentListBox);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(46, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1596, 390);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select files to be renamed";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(907, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Files to be renamed";
            // 
            // SelectIndividualCheckBox
            // 
            this.SelectIndividualCheckBox.Location = new System.Drawing.Point(19, 108);
            this.SelectIndividualCheckBox.Name = "SelectIndividualCheckBox";
            this.SelectIndividualCheckBox.Size = new System.Drawing.Size(327, 51);
            this.SelectIndividualCheckBox.TabIndex = 6;
            this.SelectIndividualCheckBox.Text = "Select Individual Files";
            this.SelectIndividualCheckBox.CheckedChanged += new System.EventHandler(this.SelectIndividualCheckBox_CheckedChanged);
            // 
            // ToLeft
            // 
            this.ToLeft.Enabled = false;
            this.ToLeft.Location = new System.Drawing.Point(689, 286);
            this.ToLeft.Name = "ToLeft";
            this.ToLeft.Size = new System.Drawing.Size(180, 50);
            this.ToLeft.TabIndex = 5;
            this.ToLeft.Text = "Remove";
            this.ToLeft.Click += new System.EventHandler(this.ToLeft_Click);
            // 
            // ToRight
            // 
            this.ToRight.Enabled = false;
            this.ToRight.Location = new System.Drawing.Point(689, 196);
            this.ToRight.Name = "ToRight";
            this.ToRight.Size = new System.Drawing.Size(180, 50);
            this.ToRight.TabIndex = 4;
            this.ToRight.Text = "Add";
            this.ToRight.Click += new System.EventHandler(this.ToRight_Click);
            // 
            // FilesSelected
            // 
            this.FilesSelected.Enabled = false;
            this.FilesSelected.HorizontalScrollbar = true;
            this.FilesSelected.ItemHeight = 29;
            this.FilesSelected.Location = new System.Drawing.Point(914, 162);
            this.FilesSelected.Name = "FilesSelected";
            this.FilesSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.FilesSelected.Size = new System.Drawing.Size(617, 178);
            this.FilesSelected.TabIndex = 3;
            // 
            // FilesPresentListBox
            // 
            this.FilesPresentListBox.Enabled = false;
            this.FilesPresentListBox.HorizontalScrollbar = true;
            this.FilesPresentListBox.ItemHeight = 29;
            this.FilesPresentListBox.Location = new System.Drawing.Point(19, 162);
            this.FilesPresentListBox.Name = "FilesPresentListBox";
            this.FilesPresentListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.FilesPresentListBox.Size = new System.Drawing.Size(627, 178);
            this.FilesPresentListBox.TabIndex = 2;
            // 
            // PreviewTab
            // 
            this.PreviewTab.Controls.Add(this.LogPreviewlist);
            this.PreviewTab.Location = new System.Drawing.Point(10, 47);
            this.PreviewTab.Name = "PreviewTab";
            this.PreviewTab.Size = new System.Drawing.Size(1716, 1156);
            this.PreviewTab.TabIndex = 2;
            this.PreviewTab.Text = "Preview";
            this.PreviewTab.UseVisualStyleBackColor = true;
            // 
            // LogPreviewlist
            // 
            this.LogPreviewlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OriginalFileNameP,
            this.RenamedToP,
            this.StatusP});
            this.LogPreviewlist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LogPreviewlist.FullRowSelect = true;
            this.LogPreviewlist.GridLines = true;
            this.LogPreviewlist.Location = new System.Drawing.Point(55, 41);
            this.LogPreviewlist.Name = "LogPreviewlist";
            this.LogPreviewlist.Size = new System.Drawing.Size(1606, 1103);
            this.LogPreviewlist.TabIndex = 1;
            this.LogPreviewlist.UseCompatibleStateImageBehavior = false;
            this.LogPreviewlist.View = System.Windows.Forms.View.Details;
            // 
            // OriginalFileNameP
            // 
            this.OriginalFileNameP.Text = "Original File Name";
            this.OriginalFileNameP.Width = 253;
            // 
            // RenamedToP
            // 
            this.RenamedToP.Text = "Renamed To";
            this.RenamedToP.Width = 253;
            // 
            // StatusP
            // 
            this.StatusP.Text = "Remark";
            this.StatusP.Width = 159;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LogRenamedlist);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1716, 1156);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LogRenamedlist
            // 
            this.LogRenamedlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OriginalColumn,
            this.NewColumn,
            this.Status});
            this.LogRenamedlist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LogRenamedlist.FullRowSelect = true;
            this.LogRenamedlist.GridLines = true;
            this.LogRenamedlist.Location = new System.Drawing.Point(55, 41);
            this.LogRenamedlist.Name = "LogRenamedlist";
            this.LogRenamedlist.Size = new System.Drawing.Size(1608, 1098);
            this.LogRenamedlist.TabIndex = 0;
            this.LogRenamedlist.UseCompatibleStateImageBehavior = false;
            this.LogRenamedlist.View = System.Windows.Forms.View.Details;
            // 
            // OriginalColumn
            // 
            this.OriginalColumn.Text = "Original File Name";
            this.OriginalColumn.Width = 253;
            // 
            // NewColumn
            // 
            this.NewColumn.Text = "Renamed To";
            this.NewColumn.Width = 253;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 159;
            // 
            // saveFilePreferencesDialog
            // 
            this.saveFilePreferencesDialog.DefaultExt = "ini";
            this.saveFilePreferencesDialog.Filter = "*.ini|";
            // 
            // openPrefencesFileDialog
            // 
            this.openPrefencesFileDialog.DefaultExt = "ini";
            this.openPrefencesFileDialog.Filter = "*.ini|";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(12, 28);
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1772, 1265);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename All";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.PostfixNumbers.ResumeLayout(false);
            this.PostfixNumbers.PerformLayout();
            this.PrefixNumbers.ResumeLayout(false);
            this.PrefixNumbers.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.PreviewTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			string LOG4NET_CONFIG_PATH = "Log4NetConfigFile";
			DateTime dateToday = DateTime.Now;
			//RegistryKey rootkey,license;
			string strLocation = ConfigurationSettings.AppSettings.Get(LOG4NET_CONFIG_PATH);

			//Show splash screen
			//Splash splash = new Splash();
			//splash.Show();
			//Thread.Sleep(3000);
			//splash.Close();

			//Initialize log4net framework
			System.IO.FileInfo configFile = new System.IO.FileInfo(strLocation);
			log4net.Config.DOMConfigurator.Configure(configFile);

			//Registry access
			//rootkey = Registry.LocalMachine.OpenSubKey("Software",true);
			//license = rootkey.OpenSubKey("RenLis");
            Application.Run(new Form1());

   //         if (license == null) // Application runs for the first time
			//{
			//	license = rootkey.CreateSubKey("RenLis");
			//	license.SetValue("Date",dateToday.ToString());
			//	license.SetValue("Registered","false");
			//	license.SetValue("Logger","yes");
   //             license.SetValue("Remove Digits", "Start");
   //             license.SetValue("Remove Space", "Both");
   //             license.SetValue("Value", "1");

			//	rootkey.Close();
			//	license.Close();
				
			//	LogMessage.LogMsg("Logger Initialised ", LogMessage.LogType.Info);

				
			//}
			//else
			//{
			//	string date;
			//	DateTime dateTime;
				
			//	date = license.GetValue("Date").ToString();
			//	dateTime= Convert.ToDateTime(date);

			//	log = Properties.Settings.Default.logger;

			//	if(log == "yes")
			//		LogMessage.LogMsg("Logger Initialised ", LogMessage.LogType.Info);
   //             Application.Run(new Form1());

    //            if (license.GetValue("Registered").ToString() == "true") //Check if registered
				//{
				//	license.Close();
				//	rootkey.Close();
				//	Application.Run(new Form1());
				//}
				//else // if not registered
				//{
					
				//	if(DateTime.Now <= dateTime.AddDays(14)) //Check whether the trial version has expired
				//	{	
				//		DialogResult dResult;

				//		dResult = MessageBox.Show("This Trial Version will expire on " + dateTime.AddDays(14).ToString() +"\n\nDo you want to register this copy now?","Register",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
				//		if(dResult.ToString() == "Yes") //If yes is clicked
				//		{
				//			Register register = new Register();
				//			register.ShowDialog();

				//			if(DateTime.Now <= dateTime.AddDays(14))
				//				Application.Run(new Form1());
    //                        else if(license.GetValue("Registered").ToString() == "true")
    //                            Application.Run(new Form1());
				//		}
				//		else //If NO is clicked
				//			Application.Run(new Form1());
				//	}
				//	else // If trial version has expired directly register option will come
				//	{
				//		Register register = new Register();
				//		register.ShowDialog();
				//	}
    //                license.Close();
				//	rootkey.Close();
				//}
			//}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			GraphicMenu gmenu = new GraphicMenu();
			gmenu.Init(this.Menu);

			gmenu.AddIcon(menuItem2,"..//..//images//Open.bmp");
			//gmenu.AddIcon(UndoMenu,"..//..//images//undo.jpg");

			//registrykey rootkey,license;

			//rootkey = registry.localmachine.opensubkey("software");
			//license = rootkey.opensubkey("renlis");

			//if(license.getvalue("registered").tostring() == "true") // check if registered. if not then show register option in about help menu
			//	registermenuitem.visible = false;
			//else

            //RegisterMenuItem.Visible = true;

            //license.Close();
            //rootkey.Close();
		}


		//Browse button
		private void button1_Click(object sender, System.EventArgs e)
		{
			int i = 0;
			string folderToParse="";
			folderBrowserDialog1.SelectedPath = Application.StartupPath;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                folderToParse = folderBrowserDialog1.SelectedPath.ToString();
            else
                folderToParse = textBox1.Text; //Keep the existing text in the teztbox if cancel is pressed
			
			textBox1.Text = folderToParse;
			
			if(textBox1.Text.ToString() != "")
			{
				//Add file names from the selected folder into the listBox
				DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
			
				FilesPresentListBox.Items.Clear();

		
				if(listBox3.Items.Count != 0)
				{
					for(int j = 0; j < listBox3.Items.Count; j++)
					{
						FileInfo[] fiArr = dir.GetFiles("*." + listBox3.Items[j].ToString());
				
						i=0;
						foreach (FileInfo fri in fiArr)
						{
							FilesPresentListBox.Items.Add(fiArr.GetValue(i).ToString());
							i++;
						}
					}
				}
				else
				{
					FileInfo[] fiArr = dir.GetFiles("*.*");
				
					i=0;
					foreach (FileInfo fri in fiArr)
					{
						FilesPresentListBox.Items.Add(fiArr.GetValue(i).ToString());
						i++;
					}
				}

				if(SelectIndividualCheckBox.Checked == false)
				{
					FilesSelected.Items.Clear();
					for(int j=0 ;j < FilesPresentListBox.Items.Count;j++)
						if(!FilesSelected.Items.Contains(textBox1.Text.ToString() + "\\" + FilesPresentListBox.Items[j].ToString()))
							FilesSelected.Items.Add(textBox1.Text.ToString() + "\\" + FilesPresentListBox.Items[j].ToString());
				}
			}
		}


		//Rename button
		private void button2_Click(object sender, System.EventArgs e)
		{
            if (MessageBox.Show("Do you wish to rename the selected files?", "Rename", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //RegistryKey rootkey, license;

                //rootkey = Registry.LocalMachine.OpenSubKey("Software", true);
                //license = rootkey.OpenSubKey("RenLis", true);

                if (Properties.Settings.Default.isFirstAccess) //Accessing for the first time
                {
                    if (MessageBox.Show("It seems that you are using this tool for the first time.\nIt is recommended that you change the user preferences.\n\nDo you wish to change your preferences now?", "Change preferences", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString() == "Yes")
                    {
                        Preferences preferences = new Preferences();
                        preferences.ShowDialog();
                    }
                    Properties.Settings.Default.isFirstAccess = false;
                    Properties.Settings.Default.Save();
                }

                try
                {
                    if (textBox1.Text.ToString() != "")
                    {
                        truncateDataAfter = TrunDataAfterCheckbox.Text.ToString();
                        truncateDataBefore = TrunDataBeforeTextBox.Text.ToString();
                        prefixTextbox = PrefixTextbox.Text.ToString();
                        postfixTextbox = PostfixTextbox.Text;


                        if ("1234567890".Contains(PrefixPadLength.Text))
                        {
                            if (PrefixPadLength.Text != "")
                                prefixPadLength = Convert.ToInt16(PrefixPadLength.Text);

                            if ("1234567890".Contains(PostfixPadLength.Text))
                            {
                                if (PostfixPadLength.Text != "")
                                    postfixPadLength = Convert.ToInt16(PostfixPadLength.Text);

                                selectedFiles.Clear();

                                for (int j = 0; j < FilesSelected.Items.Count; j++)
                                {
                                    selectedFiles.Add(FilesSelected.Items[j].ToString());
                                }

                                renameFromText.Clear();
                                renameToText.Clear();
                                renamedFrom.Clear();
                                renamedTo.Clear();
                                successStatus.Clear();

                                //For find and replace
                                for (int j = 0; j < listBox1.Items.Count; j++)
                                {
                                    renameFromText.Add(listBox1.Items[j].ToString());
                                    renameToText.Add(listBox2.Items[j].ToString());
                                }

                                RenameFiles ren = new RenameFiles();
                                ren.RenameFiles1(FilesSelected);   // call to the rename function

                                //Clear all the textboxes

                                TrunDataAfterCheckbox.Clear();
                                TrunDataBeforeTextBox.Clear();
                                PostfixPadLength.Clear();
                                PrefixPadLength.Clear();

                                //Clear the List log in the second tab
                                OriginalColumn.ListView.Items.Clear();
                                NewColumn.ListView.Items.Clear();
                                Status.ListView.Items.Clear();

                                //To generated the second tab log status
                                for (int i = 0; i < renamedTo.Count; i++)
                                {
                                    //ListViewItem lvi = new ListViewItem(FilesSelected.Items[i].ToString());
                                    ListViewItem lvi = new ListViewItem(renamedFrom[i].ToString());

                                    if (successStatus[i].ToString() == "Failed")
                                        lvi.ForeColor = Color.Red;
                                    else if (successStatus[i].ToString() == "No Change")
                                        lvi.ForeColor = Color.Black;
                                    else
                                        lvi.ForeColor = Color.Indigo;

                                    lvi.SubItems.Add(renamedTo[i].ToString());
                                    lvi.SubItems.Add(successStatus[i].ToString());
                                    LogRenamedlist.Items.Add(lvi);
                                }



                                // To refresh the contents of the list box after renaming is successfull
                                FilesSelected.Items.Clear();

                                FilesPresentListBox.Items.Clear();

                                DirectoryInfo dir = new DirectoryInfo(textBox1.Text);

                                if (listBox3.Items.Count != 0)
                                {
                                    for (int j = 0; j < listBox3.Items.Count; j++)
                                    {
                                        FileInfo[] fiArr = dir.GetFiles("*." + listBox3.Items[j].ToString());

                                        int i = 0;
                                        foreach (FileInfo fri in fiArr)
                                        {
                                            FilesPresentListBox.Items.Add(fiArr.GetValue(i).ToString());
                                            i++;
                                        }
                                    }
                                }
                                else
                                {
                                    FileInfo[] fiArr = dir.GetFiles("*.*");

                                    int i = 0;
                                    foreach (FileInfo fri in fiArr)
                                    {
                                        FilesPresentListBox.Items.Add(fiArr.GetValue(i).ToString());
                                        i++;
                                    }

                                }
                                // Refresh completes


                                button3.Enabled = true; // Enable undo button
                                UndoMenu.Enabled = true; //Enable Undo option in menu

                            }
                            else
                            {
                                MessageBox.Show("You have entered an alphabet for postfix padding length.\nPlease enter a digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tabControl2.SelectTab(1);
                                PostfixPadLength.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("You have entered an alphabet for prefix padding length.\nPlease enter a digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tabControl2.SelectTab(1);
                            PrefixPadLength.Focus();
                        }
                    }
                    else
                        MessageBox.Show("Please select a folder", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Clear all text boxes
                    TrunDataBeforeTextBox.Clear();
                    TrunDataAfterCheckbox.Clear();
                    PrefixPadLength.Clear();
                    PostfixPadLength.Clear();
                    PrefixTextbox.Clear();
                    PostfixTextbox.Clear();
                    PreficNumberCheckBox.Checked = false;
                    PostfixNumberCheckbox.Checked = false;
                    RemoveDSA.Checked = false;
                    ChangeCaseCheckbox.Checked = false;

                }
                catch (Exception exp)
                {
                    MessageBox.Show("The process failed: \n" + exp.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
		}

		//Undo button
		private void button3_Click(object sender, System.EventArgs e)
		{
            if (MessageBox.Show("Do you wish to undo the last renamed files?", "Rename", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string line;
                int k = 0;
                ArrayList statusList = new ArrayList();

                // Clear the list log in the second tab
                OriginalColumn.ListView.Items.Clear();
                NewColumn.ListView.Items.Clear();
                Status.ListView.Items.Clear();
                statusList.Clear();

                StreamReader f = new StreamReader("undo.txt");
                while ((line = f.ReadLine()) != null)
                {

                    //MessageBox.Show(line,""); 

                    Array arr = line.Split(',');
                    //MessageBox.Show(arr.GetValue(0).ToString(),"spitted");


                    if (File.Exists(arr.GetValue(1).ToString())) //If Source file exits
                    {
                        if (File.Exists(arr.GetValue(0).ToString())) //If Destination file name already exits
                            statusList.Add("Falied");
                        else
                        {
                            statusList.Add("Success");
                            File.Move(arr.GetValue(1).ToString(), arr.GetValue(0).ToString());
                        }
                    }
                    else
                    {
                        statusList.Add("Failed");
                        MessageBox.Show(arr.GetValue(1).ToString() + "\nFile does not exits", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //To generated the second tab log status
                    ListViewItem lvi = new ListViewItem(arr.GetValue(1).ToString());

                    if (statusList[k].ToString() == "Failed")
                        lvi.ForeColor = Color.Red;
                    else if (statusList[k].ToString() == "No Change")
                        lvi.ForeColor = Color.Black;
                    else
                        lvi.ForeColor = Color.DarkGreen;

                    lvi.SubItems.Add(arr.GetValue(0).ToString());
                    lvi.SubItems.Add(statusList[k].ToString());
                    LogRenamedlist.Items.Add(lvi);
                    k++;
                }

                MessageBox.Show("The changes have been undone", "", MessageBoxButtons.OK, MessageBoxIcon.Information);



                // To refresh the contents of the list box after undoing is successfull
                FilesSelected.Items.Clear();

                FilesPresentListBox.Items.Clear();

                DirectoryInfo dir = new DirectoryInfo(textBox1.Text);

                if (listBox3.Items.Count != 0)
                {
                    for (int j = 0; j < listBox3.Items.Count; j++)
                    {
                        FileInfo[] fiArr = dir.GetFiles("*." + listBox3.Items[j].ToString());

                        int i = 0;
                        foreach (FileInfo fri in fiArr)
                        {
                            FilesPresentListBox.Items.Add(fiArr.GetValue(i).ToString());
                            i++;
                        }
                    }
                }
                else
                {
                    FileInfo[] fiArr = dir.GetFiles("*.*");

                    int i = 0;
                    foreach (FileInfo fri in fiArr)
                    {
                        FilesPresentListBox.Items.Add(fiArr.GetValue(i).ToString());
                        i++;
                    }

                }
                // Refresh completes

                f.Close();

                button3.Enabled = false; // Disable undo button
                UndoMenu.Enabled = false; //Disable undo option in menu

                //Clear all text boxes
                TrunDataBeforeTextBox.Clear();
                TrunDataAfterCheckbox.Clear();
                PrefixPadLength.Clear();
                PostfixPadLength.Clear();
                PrefixTextbox.Clear();
                PostfixTextbox.Clear();
                PreficNumberCheckBox.Checked = false;
                PostfixNumberCheckbox.Checked = false;
                RemoveDSA.Checked = false;
                ChangeCaseCheckbox.Checked = false;
            }
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		//Open in Menu
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			button1_Click(sender,e);	
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
			
		}

		private void Addtext_Click(object sender, System.EventArgs e)
		{
			if(textBox2.Text != textBox3.Text)
			{
                if(textBox2.Text != "")
                {
				    if(listBox1.Items.Contains(textBox2.Text.ToString()) && listBox2.Items.Contains(textBox3.Text.ToString()))
					    MessageBox.Show("Already in List","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);

				    else
				    {
					    listBox1.Items.Add(textBox2.Text.ToString());
					    listBox2.Items.Add(textBox3.Text.ToString());
				    }
                }
                else
                    MessageBox.Show("The Find text cannot be empty", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
            else
                MessageBox.Show("The 'Find' text and the 'Replace to' text cannot be same", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            textBox2.Clear();
            textBox3.Clear();
		}

		private void removefromlist_Click(object sender, System.EventArgs e)
		{
			//MessageBox.Show(listBox1.Items.RemoveAt(0),"");
			int count = listBox1.Items.Count;

			if(listBox1.SelectedItems.Count == 0)
			{
				if (count != 0)
				{
					listBox1.Items.RemoveAt(count-1);
					listBox2.Items.RemoveAt(count-1);
				}
				else
					MessageBox.Show("No item in list","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			else
			{
				listBox1.Items.Remove(listBox1.SelectedItem);
				listBox2.Items.Remove(listBox2.SelectedItem);
			}
		}

		private void AddFileTypes_Click(object sender, System.EventArgs e)
		{
			//Check whether the listbox alredy contains the entered extension or whether the extension is legal
			if(!listBox3.Items.Contains(textBox4.Text.ToString().Replace(".","")))
			{
				if(textBox4.Text.ToString().Length < 5 && textBox4.Text.ToString()!= "" )
				{
					listBox3.Items.Add(textBox4.Text.ToString().Replace(".",""));
				
					if(textBox1.Text.ToString() != "")
					{//Refresh the contents in the FilesPresentlistbox according to the files in the 
						DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
						FilesPresentListBox.Items.Clear();
						if(listBox3.Items.Count != 0)
						{
							for(int j = 0; j < listBox3.Items.Count; j++)
							{
								FileInfo[] fiArr = dir.GetFiles("*." + listBox3.Items[j].ToString());
				
								int i=0;
								foreach (FileInfo fri in fiArr)
								{
									FilesPresentListBox.Items.Add(fiArr.GetValue(i).ToString());
									i++;
								}
							}
						}
						else
						{
							FileInfo[] fiArr = dir.GetFiles("*.*");
				
							int i=0;
							foreach (FileInfo fri in fiArr)
							{
								FilesPresentListBox.Items.Add(fiArr.GetValue(i).ToString());
								i++;
							}
						}
			
						//Refresh the contents of the FilesSelected ListBox

					
						//Check whether the select individual files checkbox is ticked if no then refresh the files selected listbox from filespresent listbox
						if(selectIndFilesCheckbox == false)
						{
							FilesSelected.Items.Clear();
							for( int j=0; j < FilesPresentListBox.Items.Count; j++)
								FilesSelected.Items.Add(FilesPresentListBox.Items[j]);
						}
						/*else  //Refresh only the files inside the FilesSelected Listbox
						{
							Array arr;

							for(int j= FilesSelected.Items.Count-1; j >= 0 ; j--)
							{
								arr = FilesSelected.Items[j].ToString().Split('.','1');
				
								for( int k=0; k<listBox3.Items.Count; k++ )	
									if(listBox3.Items.Contains(arr.GetValue(arr.Length-1).ToString()))
									{}
									else	
										FilesSelected.Items.Remove(FilesSelected.Items[j]);
							}
						}*/
					}
				}

				else
                    MessageBox.Show("Illegal File Type", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
                MessageBox.Show("Already in list", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            textBox4.Clear();

		}

		private void RemoveFileType_Click(object sender, System.EventArgs e)
		{
			if (listBox3.Items.Count != 0) //For checking whether there is no item in  list
			{
				if(listBox3.SelectedItems.Count == 1) //If any item is selected
					listBox3.Items.RemoveAt(listBox3.SelectedIndex); //Remove that item
                else
					listBox3.Items.RemoveAt(listBox3.Items.Count-1); //Else remove the last inserted item

				if(textBox1.Text.ToString() != "")
				{
					//Refresh the contents in the FilesPresentlistbox according to the files in the 
					DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
					FilesPresentListBox.Items.Clear();
					if(listBox3.Items.Count != 0)
					{
						for(int j = 0; j < listBox3.Items.Count; j++)
						{
							FileInfo[] fiArr = dir.GetFiles("*." + listBox3.Items[j].ToString());
			
							int i=0;
							foreach (FileInfo fri in fiArr)
							{
								FilesPresentListBox.Items.Add(fiArr.GetValue(i).ToString());
								i++;
							}
						}
					}
					else
					{
						FileInfo[] fiArr = dir.GetFiles("*.*");
			
						int i=0;
						foreach (FileInfo fri in fiArr)
						{
							FilesPresentListBox.Items.Add(fiArr.GetValue(i).ToString());
							i++;
						}
					}
		
					//Refresh the contents of the FilesSelected ListBox

				
					//Check whether the select individual files checkbox is ticked if no then refresh the files selected listbox from filespresent listbox
					if(selectIndFilesCheckbox == false) //Directly copy from FilesSelected to FilesPresent List box
					{
						FilesSelected.Items.Clear();
						for( int j=0; j < FilesPresentListBox.Items.Count; j++)
							FilesSelected.Items.Add(FilesPresentListBox.Items[j]);
					}
					else  //Refresh only the files inside the FilesSelected Listbox
					{
						Array arr;

						for(int j= FilesSelected.Items.Count-1; j >= 0 ; j--)
						{
							arr = FilesSelected.Items[j].ToString().Split('.','1');
			
							for( int k=0; k<listBox3.Items.Count; k++ )	
								if(listBox3.Items.Contains(arr.GetValue(arr.Length-1).ToString()))
								{}
								else	
									FilesSelected.Items.Remove(FilesSelected.Items[j]);
						}
					}
				}		
			}
			else
				MessageBox.Show("No item in list","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}

		private void ToRight_Click(object sender, System.EventArgs e)
		{
			if(FilesPresentListBox.Enabled == true)
				if (FilesPresentListBox.SelectedItems.Count != 0)
                {
						for(int i=0 ;i < FilesPresentListBox.SelectedItems.Count;i++)
							if(!FilesSelected.Items.Contains(textBox1.Text.ToString() + "\\" + FilesPresentListBox.SelectedItems[i].ToString()))
								FilesSelected.Items.Add(textBox1.Text.ToString() + "\\" + FilesPresentListBox.SelectedItems[i].ToString());
				}
				else
                    MessageBox.Show("Please select a file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void SelectIndividualCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			if(SelectIndividualCheckBox.Checked == true)
			{
				FilesPresentListBox.Enabled = true;
				FilesSelected.Enabled = true;
				selectIndFilesCheckbox = true;
				
				ToRight.Enabled = true;
				ToLeft.Enabled = true;

				FilesSelected.Items.Clear();

			}
			else
			{
				FilesPresentListBox.Enabled = false;
				FilesSelected.Enabled = false;
				selectIndFilesCheckbox = false;
			
				ToRight.Enabled = false;
				ToLeft.Enabled = false;

				FilesSelected.Items.Clear();
				for(int i=0 ;i < FilesPresentListBox.Items.Count;i++)
					if(!FilesSelected.Items.Contains(textBox1.Text.ToString() + "\\" + FilesPresentListBox.Items[i].ToString()))
						FilesSelected.Items.Add(textBox1.Text.ToString() + "\\" + FilesPresentListBox.Items[i].ToString());
	
			}
		}

		private void ToLeft_Click(object sender, System.EventArgs e)
		{
			int count = FilesSelected.SelectedItems.Count;
			for(int i=count-1 ;i >= 0; i--)
				FilesSelected.Items.Remove(FilesSelected.SelectedItems[i]);
		}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(listBox1.SelectedItems.Count == 1 && listBox2.SelectedIndex != listBox1.SelectedIndex)
				listBox2.SetSelected(listBox1.SelectedIndex,true);
		}

		private void listBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(listBox2.SelectedItems.Count == 1 && listBox1.SelectedIndex != listBox2.SelectedIndex)
				listBox1.SetSelected(listBox2.SelectedIndex,true);
		}

		private void RemoveDigitsCheckbox_CheckedChanged(object sender, System.EventArgs e)
		{
			if(RemoveDigitsCheckbox.Checked == true)
				removeDigitsCheck = true;
			else
				removeDigitsCheck = false;
		}

		private void SpaveRemoveCheckbox_CheckedChanged(object sender, System.EventArgs e)
		{
			if(SpaveRemoveCheckbox.Checked == true)
				removeSpaceCheck = true;
			else
				removeSpaceCheck = false;
		}

		private void RemoveAlphabetsCheckbox_CheckedChanged(object sender, System.EventArgs e)
		{
			if(RemoveAlphabetsCheckbox.Checked == true)
				removeAlphabetsCheck = true;
			else
				removeAlphabetsCheck = false;
		}

		
		private void ToUpperCase_CheckedChanged(object sender, System.EventArgs e)
		{
			if(ToUpperCase.Checked == true)
				toUpperCheck = true;
			else
				toUpperCheck = false;
		}

		private void ToLowerCase_CheckedChanged(object sender, System.EventArgs e)
		{
			if(ToLowerCase.Checked == true)
				toLowerCheck = true;
			else
				toLowerCheck = false;
		}

		private void ToTitleCase_CheckedChanged_1(object sender, System.EventArgs e)
		{
			if(ToTitleCase.Checked == true)
				toTitleCheck = true;
			else
				toTitleCheck = false;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(ChangeCaseCheckbox.Checked == true)
			{
				ToUpperCase.Enabled = true;
				ToLowerCase.Enabled = true;
				ToTitleCase.Enabled = true;
				changeCase = true;
			}
			else
			{
				ToUpperCase.Enabled = false;
				ToLowerCase.Enabled = false;
				ToTitleCase.Enabled = false;
				changeCase = false;
			}

		}

		private void RemoveDSA_CheckedChanged(object sender, System.EventArgs e)
		{
			if(RemoveDSA.Checked == true)
			{
				RemoveAlphabetsCheckbox.Enabled = true;
				RemoveDigitsCheckbox.Enabled = true;
				SpaveRemoveCheckbox.Enabled = true;
				remove_DSA = true;
			}
			else
			{
				RemoveAlphabetsCheckbox.Enabled = false;
				RemoveDigitsCheckbox.Enabled = false;
				SpaveRemoveCheckbox.Enabled = false;
				remove_DSA = false;
			}
		
		}

		//Undo in menu
		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			button3_Click(sender,e);
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			button2_Click(sender,e);
		}

		// About in main menu
		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			About about = new About();

			about.Show();
			//MessageBox.Show("Renamer 1.0 \n ","About Renamer",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
		}

		//Preferences in main menu
		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			Preferences preferences = new Preferences();
			preferences.Show();
		}

        private void RegisterMenuItem_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void PreficNumberCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PreficNumberCheckBox.Checked == true)
            {
                PadPrefixCheck.Enabled = true;
                prefixNumberCheckbox = true; //variable
            }
            else
            {
                PadPrefixCheck.Enabled = false;
                PadPrefixCheck.Checked = false;
                prefixNumberCheckbox = false;  //variable
                Prefix1.Visible = false;
                Prefix2.Visible = false;
                PrefixPadLength.Visible = false;
                PrefixPadLength.Clear();

            }
        }

        private void PostfixNumberCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PostfixNumberCheckbox.Checked == true)
            {
                PadPostficCheck.Enabled = true;
                postfixNumberCheckbox = true; //variable
            }
            else
            {
                PadPostficCheck.Enabled = false;
                PadPostficCheck.Checked = false;
                postfixNumberCheckbox = false; //variable
                Postfix1.Visible = false;
                Postfix2.Visible = false;
                PostfixPadLength.Visible = false;
                PostfixPadLength.Clear();
            }
        }

        private void PadPrefixCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PadPrefixCheck.Checked == true)
            {
                Prefix1.Visible = true;
                Prefix2.Visible = true;
                PrefixPadLength.Visible = true;
            }
            else
            {
                Prefix1.Visible = false;
                Prefix2.Visible = false;
                PrefixPadLength.Visible = false;
                PrefixPadLength.Clear();
            }
        }

        private void PadPostficCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PadPostficCheck.Checked == true)
            {
                Postfix1.Visible = true;
                Postfix2.Visible = true;
                PostfixPadLength.Visible = true;
            }
            else
            {
                Postfix1.Visible = false;
                Postfix2.Visible = false;
                PostfixPadLength.Visible = false;
                PostfixPadLength.Clear();
            }
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.ToString() != "")
                {
                    truncateDataAfter = TrunDataAfterCheckbox.Text.ToString();
                    truncateDataBefore = TrunDataBeforeTextBox.Text.ToString();
                    prefixTextbox = PrefixTextbox.Text.ToString();
                    postfixTextbox = PostfixTextbox.Text;


                    if ("1234567890".Contains(PrefixPadLength.Text))
                    {
                        if (PrefixPadLength.Text != "")
                            prefixPadLength = Convert.ToInt16(PrefixPadLength.Text);

                        if ("1234567890".Contains(PostfixPadLength.Text))
                        {
                            if (PostfixPadLength.Text != "")
                                postfixPadLength = Convert.ToInt16(PostfixPadLength.Text);

                            selectedFiles.Clear();

                            for (int j = 0; j < FilesSelected.Items.Count; j++)
                            {
                                selectedFiles.Add(FilesSelected.Items[j].ToString());
                            }

                            renameFromText.Clear();
                            renameToText.Clear();
                            renamedFrom.Clear();
                            renamedTo.Clear();
                            successStatus.Clear();

                            //For find and replace
                            for (int j = 0; j < listBox1.Items.Count; j++)
                            {
                                renameFromText.Add(listBox1.Items[j].ToString());
                                renameToText.Add(listBox2.Items[j].ToString());
                            }

                            PreviewFiles pre = new PreviewFiles();
                            pre.PreviewRenameFiles(FilesSelected);   // call to the preview function

                            //Clear all the textboxes

                            TrunDataAfterCheckbox.Clear();
                            TrunDataBeforeTextBox.Clear();
                            PostfixPadLength.Clear();
                            PrefixPadLength.Clear();

                            //Clear the preview List log in the second tab
                            OriginalFileNameP.ListView.Items.Clear();
                            RenamedToP.ListView.Items.Clear();
                            StatusP.ListView.Items.Clear();

                            //To generated the second tab log status
                            for (int i = 0; i < renamedTo.Count; i++)
                            {
                                //ListViewItem lvi = new ListViewItem(FilesSelected.Items[i].ToString());
                                ListViewItem lvi = new ListViewItem(renamedFrom[i].ToString());

                                if (successStatus[i].ToString() == "Failed")
                                    lvi.ForeColor = Color.Red;
                                else if (successStatus[i].ToString() == "No Change")
                                    lvi.ForeColor = Color.Black;
                                else
                                    lvi.ForeColor = Color.Indigo;

                                lvi.SubItems.Add(renamedTo[i].ToString());
                                lvi.SubItems.Add(successStatus[i].ToString());
                                LogPreviewlist.Items.Add(lvi);
                            }
                            tabControl1.SelectTab(1);
                        }
                        else
                        {
                            MessageBox.Show("You have entered an alphabet for postfix padding length.\nPlease enter a digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tabControl2.SelectTab(1);
                            PostfixPadLength.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have entered an alphabet for prefix padding length.\nPlease enter a digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabControl2.SelectTab(1);
                        PrefixPadLength.Focus();
                    }
                }
                else
                    MessageBox.Show("Please select a folder", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception exp)
            {
                MessageBox.Show("The process failed: \n" + exp.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void menuItem5_Click_1(object sender, EventArgs e)
        {
            Preview_Click(sender, e);
        }

        //Save Prefernces menu item
        private void menuItem13_Click(object sender, EventArgs e)
        {
            if ("1234567890".Contains(PrefixPadLength.Text) && "1234567890".Contains(PostfixPadLength.Text))
            {
                if (saveFilePreferencesDialog.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(saveFilePreferencesDialog.FileName.ToString(), "");
                    if(File.Exists(saveFilePreferencesDialog.FileName.ToString()))
                        File.Delete(saveFilePreferencesDialog.FileName.ToString());
                    
                    FileStream f = new FileStream(saveFilePreferencesDialog.FileName.ToString().Remove(saveFilePreferencesDialog.FileName.ToString().IndexOf(".")) + ".ini", FileMode.Create);
                    StreamWriter s = new StreamWriter(f);

                    s.WriteLine("WARNING: Please do not edit this file manually");
                    s.WriteLine("[Replace]");

                    if (listBox1.Items.Count == 0)
                        s.WriteLine("NULL");
                    else
                        for (int i = 0; i < listBox1.Items.Count; i++)
                            s.WriteLine(listBox1.Items[i].ToString() + " " + listBox2.Items[i].ToString());

                    s.WriteLine("\n[Remove]");
                    if (RemoveDSA.Checked == true)
                        s.WriteLine("True");
                    else
                        s.WriteLine("False");

                    if (RemoveDigitsCheckbox.Checked == true)
                        s.WriteLine("True");
                    else
                        s.WriteLine("False");

                    if (SpaveRemoveCheckbox.Checked == true)
                        s.WriteLine("True");
                    else
                        s.WriteLine("False");

                    if (RemoveAlphabetsCheckbox.Checked == true)
                        s.WriteLine("True");
                    else
                        s.WriteLine("False");

                    s.WriteLine("\n[Change Case]");
                    if (ChangeCaseCheckbox.Checked == true)
                    {
                        if (ToUpperCase.Checked == true)
                            s.WriteLine("Upper");
                        else if (ToLowerCase.Checked == true)
                            s.WriteLine("Lower");
                        else if (ToTitleCase.Checked == true)
                            s.WriteLine("Title");
                        else
                            s.WriteLine("False");
                    }
                    else
                        s.WriteLine("False");


                    s.WriteLine("\n[Filter]");
                    if (listBox3.Items.Count == 0)
                        s.WriteLine("NULL");
                    else
                        for (int i = 0; i < listBox3.Items.Count; i++)
                            s.WriteLine(listBox3.Items[i].ToString());

                    s.WriteLine("\n[Truncate Data Before]");
                    if (TrunDataBeforeTextBox.Text == "")
                        s.WriteLine("NULL");
                    else
                        s.WriteLine(TrunDataBeforeTextBox.Text.ToString());

                    s.WriteLine("\n[Truncate Data After]");
                    if (TrunDataAfterCheckbox.Text == "")
                        s.WriteLine("NULL");
                    else
                        s.WriteLine(TrunDataAfterCheckbox.Text.ToString());

                    s.WriteLine("\n[Prefix]");
                    if (PrefixTextbox.Text == "")
                        s.WriteLine("NULL");
                    else
                        s.WriteLine(PrefixTextbox.Text.ToString());

                    s.WriteLine("\n[Postfix]");
                    if (PostfixTextbox.Text == "")
                        s.WriteLine("NULL");
                    else
                        s.WriteLine(PostfixTextbox.Text.ToString());

                    s.WriteLine("\n[Prefix Incremental Numbering]");
                    if (PreficNumberCheckBox.Checked == true)
                    {
                        s.WriteLine("True");
                        if (PadPrefixCheck.Checked == true)
                        {
                            s.WriteLine("True");
                            s.WriteLine(PrefixPadLength.Text.ToString());
                        }
                    }
                    else
                         s.WriteLine("False");

                    s.WriteLine("\n[Postfix Incremental Numbering]");
                        
                    if (PostfixNumberCheckbox.Checked == true)
                    {
                        s.WriteLine("True");
                        if (PadPostficCheck.Checked == true)
                        {
                            s.WriteLine("True");
                            s.WriteLine(PostfixPadLength.Text.ToString());
                        }
                    }
                    else
                        s.WriteLine("False");

                    //RegistryKey rootkey, license;
                    //rootkey = Registry.LocalMachine.OpenSubKey("Software");
                    //license = rootkey.OpenSubKey("RenLis");

                    s.WriteLine("\n[Log]");
                    s.WriteLine(Properties.Settings.Default.logger);
                    s.WriteLine("\n[Digits]");
                    s.WriteLine(Properties.Settings.Default.removeDigit);
                    s.WriteLine("\n[Space]");
                    s.WriteLine(Properties.Settings.Default.removeSpace);

                    //license.Close();
                    //rootkey.Close();
                    s.Close();
                    f.Close();
                }
            }
            else
            {
                MessageBox.Show("You have entered an alphabet for padding length.\nPlease enter a digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl2.SelectTab(1);
            }
        }

        private void LoadPreferences_Click(object sender, EventArgs e)
        {
            // Reset all settings
            TrunDataBeforeTextBox.Clear();
            TrunDataAfterCheckbox.Clear();
            PrefixPadLength.Clear();
            PostfixPadLength.Clear();
            PrefixTextbox.Clear();
            PostfixTextbox.Clear();
            PreficNumberCheckBox.Checked = false;
            PostfixNumberCheckbox.Checked = false;
            RemoveDSA.Checked = false;
            ChangeCaseCheckbox.Checked = false;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            string line = "";
            
            if (openPrefencesFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(File.Exists(openPrefencesFileDialog.FileName.ToString()))
                {    
                    FileStream f = new FileStream(openPrefencesFileDialog.FileName.ToString(), FileMode.Open);
                    StreamReader s = new StreamReader(f);

                    if (s.ReadLine().Contains("WARNING"))
                    {
                        line = s.ReadLine();

                        if (line == "[Replace]")
                        {
                            line = s.ReadLine();
                            while (line != "")
                            {
                                if (line != "NULL")
                                {
                                    Array arr = line.Split(' ', '2');
                                    listBox1.Items.Add(arr.GetValue(0).ToString());
                                    listBox2.Items.Add(arr.GetValue(1).ToString());
                                }
                                line = s.ReadLine();
                            }

                            line = s.ReadLine();
                            if (line == "[Remove]")
                            {
                                if (s.ReadLine().Contains("True"))
                                {
                                    RemoveDSA.Checked = true;

                                    if (s.ReadLine().Contains("True"))
                                        RemoveDigitsCheckbox.Checked = true;
                                    else
                                        RemoveDigitsCheckbox.Checked = false;

                                    if (s.ReadLine().Contains("True"))
                                        SpaveRemoveCheckbox.Checked = true;
                                    else
                                        SpaveRemoveCheckbox.Checked = false;

                                    if (s.ReadLine().Contains("True"))
                                        RemoveAlphabetsCheckbox.Checked = true;
                                    else
                                        RemoveAlphabetsCheckbox.Checked = false;
                                }
                                else
                                    RemoveDSA.Checked = false;

                                s.ReadLine();
                                if (s.ReadLine().Contains("[Change Case]"))
                                {
                                    line = s.ReadLine();
                                    if (line == "False")
                                    {
                                        ChangeCaseCheckbox.Checked = false;
                                        ToUpperCase.Checked = false;
                                        ToLowerCase.Checked = false;
                                        ToTitleCase.Checked = false;
                                    }
                                    else if (line == "Upper")
                                    {
                                        ChangeCaseCheckbox.Checked = true;
                                        ToUpperCase.Checked = true;
                                    }
                                    else if (line == "Lower")
                                    {
                                        ChangeCaseCheckbox.Checked = true;
                                        ToLowerCase.Checked = true;
                                    }
                                    else if (line == "Title")
                                    {
                                        ChangeCaseCheckbox.Checked = true;
                                        ToUpperCase.Checked = true;
                                    }
                                    else
                                        MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    s.ReadLine();

                                    line = s.ReadLine();
                                    if (line == "[Filter]")
                                    {
                                        line = s.ReadLine();
                                        while (line != "")
                                        {
                                            if (line != "NULL")
                                                listBox3.Items.Add(line);

                                            line = s.ReadLine();
                                        }

                                        if (s.ReadLine().Contains("[Truncate Data Before]"))
                                        {
                                            line = s.ReadLine();
                                            if (line != "NULL")
                                                TrunDataBeforeTextBox.Text = line;

                                            s.ReadLine();
                                            if (s.ReadLine().Contains("[Truncate Data After]"))
                                            {
                                                line = s.ReadLine();
                                                if (line != "NULL")
                                                    TrunDataAfterCheckbox.Text = line;

                                                s.ReadLine();
                                                if (s.ReadLine().Contains("[Prefix]"))
                                                {
                                                    line = s.ReadLine();
                                                    if (line != "NULL")
                                                        PrefixTextbox.Text = line;

                                                    s.ReadLine();

                                                    if (s.ReadLine().Contains("[Postfix]"))
                                                    {
                                                        line = s.ReadLine();
                                                        if (line != "NULL")
                                                            PostfixTextbox.Text = line;

                                                        s.ReadLine();

                                                        if (s.ReadLine().Contains("[Prefix Incremental Numbering]"))
                                                        {
                                                            if (s.ReadLine().Contains("True"))
                                                            {
                                                                PreficNumberCheckBox.Checked = true;
                                                                if (s.ReadLine().Contains("True"))
                                                                {
                                                                    PadPrefixCheck.Checked = true;
                                                                    PrefixPadLength.Text = s.ReadLine();
                                                                }
                                                            }
                                                            else
                                                                PreficNumberCheckBox.Checked = false;

                                                            s.ReadLine();

                                                            if (s.ReadLine().Contains("[Postfix Incremental Numbering]"))
                                                            {
                                                                if (s.ReadLine().Contains("True"))
                                                                {
                                                                    PostfixNumberCheckbox.Checked = true;
                                                                    if (s.ReadLine().Contains("True"))
                                                                    {
                                                                        PadPostficCheck.Checked = true;
                                                                        PostfixPadLength.Text = s.ReadLine();
                                                                    }
                                                                }
                                                                else
                                                                    PostfixNumberCheckbox.Checked = false;

                                                                s.ReadLine();

                                                                //RegistryKey rootkey, license;
                                                                //rootkey = Registry.LocalMachine.OpenSubKey("Software", true);
                                                                //license = rootkey.OpenSubKey("RenLis",true);

                                                                if (s.ReadLine().Contains("[Log]"))
                                                                {
                                                                    if (s.ReadLine().Contains("Yes"))
                                                                        Properties.Settings.Default.logger = "yes";
                                                                       // license.SetValue("Logger", "yes");
                                                                    else
                                                                        Properties.Settings.Default.logger = "no";
                                                                    //license.SetValue("Logger", "no");

                                                                    s.ReadLine();
                                                                    if (s.ReadLine().Contains("[Digits]"))
                                                                    {
                                                                        line = s.ReadLine();
                                                                        if (line == "All")
                                                                            Properties.Settings.Default.removeDigit = "All";
                                                                            //license.SetValue("Remove Digits", "All");
                                                                        else if (line == "Start")
                                                                            Properties.Settings.Default.removeDigit = "Start";
                                                                        //license.SetValue("Remove Digits", "Start");
                                                                        else if (line == "End")
                                                                            Properties.Settings.Default.removeDigit = "End";
                                                                        //license.SetValue("Remove Digits", "End");
                                                                        else if (line == "Both")
                                                                            Properties.Settings.Default.removeDigit = "Both";
                                                                        //license.SetValue("Remove Digits", "Both");

                                                                        s.ReadLine();

                                                                        if (s.ReadLine().Contains("[Space]"))
                                                                        {
                                                                            line = s.ReadLine();
                                                                            if (line == "All")
                                                                                Properties.Settings.Default.removeDigit = "All";
                                                                            //license.SetValue("Remove Space", "All");
                                                                            else if (line == "Start")
                                                                                Properties.Settings.Default.removeDigit = "Start";
                                                                            //license.SetValue("Remove Space", "Start");
                                                                            else if (line == "End")
                                                                                Properties.Settings.Default.removeDigit = "End";
                                                                            //license.SetValue("Remove Space", "End");
                                                                            else if (line == "Both")
                                                                                Properties.Settings.Default.removeDigit = "Both";
                                                                            //license.SetValue("Remove Space", "Both");
                                                                        }
                                                                        else
                                                                            MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                                                    }
                                                                    else
                                                                        MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                }
                                                                else
                                                                    MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                            else
                                                                MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                        else
                                                            MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    else
                                                        MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else
                                                    MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                                MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                            MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                        MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                    MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                                MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("The selected ini file is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    s.Close();
                    f.Close();
                }
            }
        }

        private void ResetAllSettings_Click(object sender, EventArgs e)
        {
            //RegistryKey rootkey, license;
            //rootkey = Registry.LocalMachine.OpenSubKey("Software", true);
            //license = rootkey.OpenSubKey("RenLis",true);

            Properties.Settings.Default.logger = "yes";
            Properties.Settings.Default.removeDigit = "Both";
            Properties.Settings.Default.removeSpace = "Both";
            //license.SetValue("Logger", "yes");
            //license.SetValue("Remove Digits", "Start");
            //license.SetValue("Remove Space", "Both");

            //license.Close();
            //rootkey.Close();
            // Reset all settings
            TrunDataBeforeTextBox.Clear();
            TrunDataAfterCheckbox.Clear();
            PrefixPadLength.Clear();
            PostfixPadLength.Clear();
            PrefixTextbox.Clear();
            PostfixTextbox.Clear();
            PreficNumberCheckBox.Checked = false;
            PostfixNumberCheckbox.Checked = false;
            RemoveDSA.Checked = false;
            ChangeCaseCheckbox.Checked = false;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            MessageBox.Show("Your settings has been reset to default settings", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            LogView logview = new LogView();
            logview.ShowDialog();
        }
    }
}
