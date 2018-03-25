namespace searching
{
    partial class Form1
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
            this.cmbDrivers = new System.Windows.Forms.ComboBox();
            this.lbxFiles = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbDrivers
            // 
            this.cmbDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrivers.FormattingEnabled = true;
            this.cmbDrivers.Location = new System.Drawing.Point(12, 26);
            this.cmbDrivers.Name = "cmbDrivers";
            this.cmbDrivers.Size = new System.Drawing.Size(48, 24);
            this.cmbDrivers.TabIndex = 0;
            this.cmbDrivers.SelectedIndexChanged += new System.EventHandler(this.cmbDrivers_SelectedIndexChanged);
            // 
            // lbxFiles
            // 
            this.lbxFiles.FormattingEnabled = true;
            this.lbxFiles.ItemHeight = 16;
            this.lbxFiles.Location = new System.Drawing.Point(12, 56);
            this.lbxFiles.Name = "lbxFiles";
            this.lbxFiles.Size = new System.Drawing.Size(1020, 644);
            this.lbxFiles.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 718);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbxFiles);
            this.Controls.Add(this.cmbDrivers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrivers;
        private System.Windows.Forms.ListBox lbxFiles;
        private System.Windows.Forms.TextBox textBox1;
    }
}

