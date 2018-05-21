namespace Rename
{
    partial class LogView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UndoSelectedButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoglistView1 = new System.Windows.Forms.ListView();
            this.DateTimeCol = new System.Windows.Forms.ColumnHeader();
            this.renamedFromCol = new System.Windows.Forms.ColumnHeader();
            this.RenamedToCol = new System.Windows.Forms.ColumnHeader();
            this.PossibilityCol = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // UndoSelectedButton
            // 
            this.UndoSelectedButton.Location = new System.Drawing.Point(138, 453);
            this.UndoSelectedButton.Name = "UndoSelectedButton";
            this.UndoSelectedButton.Size = new System.Drawing.Size(87, 23);
            this.UndoSelectedButton.TabIndex = 1;
            this.UndoSelectedButton.Text = "Undo Selected";
            this.UndoSelectedButton.UseVisualStyleBackColor = true;
            this.UndoSelectedButton.Click += new System.EventHandler(this.UndoSelectedButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(328, 453);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enable logging from preferences to avail of this feature";
            this.label1.Visible = false;
            // 
            // LoglistView1
            // 
            this.LoglistView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateTimeCol,
            this.renamedFromCol,
            this.RenamedToCol,
            this.PossibilityCol});
            this.LoglistView1.FullRowSelect = true;
            this.LoglistView1.GridLines = true;
            this.LoglistView1.Location = new System.Drawing.Point(15, 36);
            this.LoglistView1.Margin = new System.Windows.Forms.Padding(20, 100, 50, 3);
            this.LoglistView1.Name = "LoglistView1";
            this.LoglistView1.Size = new System.Drawing.Size(513, 399);
            this.LoglistView1.TabIndex = 0;
            this.LoglistView1.UseCompatibleStateImageBehavior = false;
            this.LoglistView1.View = System.Windows.Forms.View.Details;
            // 
            // DateTimeCol
            // 
            this.DateTimeCol.Text = "Date Renamed";
            this.DateTimeCol.Width = 107;
            // 
            // renamedFromCol
            // 
            this.renamedFromCol.Text = "Renamed From";
            this.renamedFromCol.Width = 144;
            // 
            // RenamedToCol
            // 
            this.RenamedToCol.Text = "Renamed To";
            this.RenamedToCol.Width = 169;
            // 
            // PossibilityCol
            // 
            this.PossibilityCol.Text = "Possible";
            this.PossibilityCol.Width = 89;
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 488);
            this.Controls.Add(this.LoglistView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UndoSelectedButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LogView";
            this.Text = "Log View";
            this.Load += new System.EventHandler(this.LogView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UndoSelectedButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LoglistView1;
        private System.Windows.Forms.ColumnHeader DateTimeCol;
        private System.Windows.Forms.ColumnHeader renamedFromCol;
        private System.Windows.Forms.ColumnHeader RenamedToCol;
        private System.Windows.Forms.ColumnHeader PossibilityCol;
    }
}