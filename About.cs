using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Rename
{
	/// <summary>
	/// Summary description for about.
	/// </summary>
	public class About : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel linktoEmailMe;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label RenameAll;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public About()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.RenameAll = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linktoEmailMe = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RenameAll
            // 
            this.RenameAll.Location = new System.Drawing.Point(384, 69);
            this.RenameAll.Name = "RenameAll";
            this.RenameAll.Size = new System.Drawing.Size(240, 49);
            this.RenameAll.TabIndex = 0;
            this.RenameAll.Text = "Rename All 1.0 ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linktoEmailMe
            // 
            this.linktoEmailMe.Location = new System.Drawing.Point(461, 293);
            this.linktoEmailMe.Name = "linktoEmailMe";
            this.linktoEmailMe.Size = new System.Drawing.Size(345, 52);
            this.linktoEmailMe.TabIndex = 3;
            this.linktoEmailMe.TabStop = true;
            this.linktoEmailMe.Text = "prasad.karkera@gmail.com";
            this.linktoEmailMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linktoEmailMe_LinkClicked);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(173, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please report  bugs to";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(384, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "All rights reserved";
            // 
            // About
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(12, 28);
            this.ClientSize = new System.Drawing.Size(963, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linktoEmailMe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RenameAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Rename All";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			//About about = new About();
			this.Close();
		}

		private void linktoEmailMe_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			
		}
	}
}
