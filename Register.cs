using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Rename
{
	/// <summary>
	/// Summary description for Register.
	/// </summary>
	public class Register : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox key1textbox;
		private System.Windows.Forms.TextBox key2textbox;
		private System.Windows.Forms.TextBox key3textbox;
		private System.Windows.Forms.TextBox key4textbox;
		private System.Windows.Forms.TextBox key5textbox;
		private System.Windows.Forms.Label RegisterLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Button CancelButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Register()
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
			this.key1textbox = new System.Windows.Forms.TextBox();
			this.key2textbox = new System.Windows.Forms.TextBox();
			this.key3textbox = new System.Windows.Forms.TextBox();
			this.key4textbox = new System.Windows.Forms.TextBox();
			this.key5textbox = new System.Windows.Forms.TextBox();
			this.RegisterLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.OKButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// key1textbox
			// 
			this.key1textbox.Location = new System.Drawing.Point(24, 136);
			this.key1textbox.MaxLength = 5;
			this.key1textbox.Name = "key1textbox";
			this.key1textbox.Size = new System.Drawing.Size(56, 20);
			this.key1textbox.TabIndex = 0;
			this.key1textbox.Text = "";
			// 
			// key2textbox
			// 
			this.key2textbox.Location = new System.Drawing.Point(96, 136);
			this.key2textbox.MaxLength = 5;
			this.key2textbox.Name = "key2textbox";
			this.key2textbox.Size = new System.Drawing.Size(56, 20);
			this.key2textbox.TabIndex = 1;
			this.key2textbox.Text = "";
			// 
			// key3textbox
			// 
			this.key3textbox.Location = new System.Drawing.Point(168, 136);
			this.key3textbox.MaxLength = 5;
			this.key3textbox.Name = "key3textbox";
			this.key3textbox.Size = new System.Drawing.Size(56, 20);
			this.key3textbox.TabIndex = 2;
			this.key3textbox.Text = "";
			// 
			// key4textbox
			// 
			this.key4textbox.Location = new System.Drawing.Point(240, 136);
			this.key4textbox.MaxLength = 5;
			this.key4textbox.Name = "key4textbox";
			this.key4textbox.Size = new System.Drawing.Size(56, 20);
			this.key4textbox.TabIndex = 3;
			this.key4textbox.Text = "";
			// 
			// key5textbox
			// 
			this.key5textbox.Location = new System.Drawing.Point(312, 136);
			this.key5textbox.MaxLength = 5;
			this.key5textbox.Name = "key5textbox";
			this.key5textbox.Size = new System.Drawing.Size(56, 20);
			this.key5textbox.TabIndex = 4;
			this.key5textbox.Text = "";
			// 
			// RegisterLabel
			// 
			this.RegisterLabel.Location = new System.Drawing.Point(24, 88);
			this.RegisterLabel.Name = "RegisterLabel";
			this.RegisterLabel.Size = new System.Drawing.Size(328, 23);
			this.RegisterLabel.TabIndex = 5;
			this.RegisterLabel.Text = "Please enter the Product key to continue using this software";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(136, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "REGISTER";
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(88, 192);
			this.OKButton.Name = "OKButton";
			this.OKButton.TabIndex = 7;
			this.OKButton.Text = "OK";
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(200, 192);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.TabIndex = 8;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// Register
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(400, 248);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.RegisterLabel);
			this.Controls.Add(this.key5textbox);
			this.Controls.Add(this.key4textbox);
			this.Controls.Add(this.key3textbox);
			this.Controls.Add(this.key2textbox);
			this.Controls.Add(this.key1textbox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Register";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register";
			this.Load += new System.EventHandler(this.Register_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void OKButton_Click(object sender, System.EventArgs e)
		{
			if(key1textbox.Text.Length ==5 && key2textbox.Text.Length == 5 && key3textbox.Text.Length == 5 && key4textbox.Text.Length == 5 && key5textbox.Text.Length == 5)
			{
				char [] key1 = key2textbox.Text.ToCharArray(2,1);
				char [] key2 = key4textbox.Text.ToCharArray(4,1);
				char [] key3 = key5textbox.Text.ToCharArray(1,1);

				if(key1[0] == '7' && key2[0] == '0' && key3[0] == '9')
				{
					//RegistryKey rootkey,license;

					//rootkey = Registry.LocalMachine.OpenSubKey("Software",true);
					//license = rootkey.OpenSubKey("RenLis",true);
					//license.SetValue("Registered","true");
                    MessageBox.Show("You have successfully registered this product", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
				}
				else
				{
					MessageBox.Show("The product key is incorrect","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			else
				MessageBox.Show("The product key is incorrect","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}

		private void CancelButton_Click(object sender, System.EventArgs e)
		{
				this.Close();
		}

		private void Register_Load(object sender, System.EventArgs e)
		{
			//string date;
			//DateTime dateTime;
			//RegistryKey rootkey,license;

			//rootkey = Registry.LocalMachine.OpenSubKey("Software",true);
			//license = rootkey.OpenSubKey("RenLis",true);

			//date = license.GetValue("Date").ToString();
			//dateTime= Convert.ToDateTime(date);

			//if(DateTime.Now > dateTime.AddDays(14))
			//	CancelButton.Text = "Close";
		}

		
	}
}
