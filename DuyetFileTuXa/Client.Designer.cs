namespace DuyetFileTuXa
{
    partial class Client
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.dropBox = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.openandeditfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openandeditfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 367);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 386);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(157, 386);
            this.txtMess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(728, 24);
            this.txtMess.TabIndex = 7;
            // 
            // dropBox
            // 
            this.dropBox.FormattingEnabled = true;
            this.dropBox.ItemHeight = 16;
            this.dropBox.Location = new System.Drawing.Point(16, 420);
            this.dropBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropBox.Name = "dropBox";
            this.dropBox.Size = new System.Drawing.Size(492, 116);
            this.dropBox.TabIndex = 12;
            this.dropBox.Visible = false;
            this.dropBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropBox_DragDrop);
            this.dropBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropBox_DragEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.Send;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(517, 418);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 64);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 15);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1019, 333);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.SendMess;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(895, 367);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 64);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // openandeditfile
            // 
            this.openandeditfile.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.openandeditfile;
            this.openandeditfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openandeditfile.Location = new System.Drawing.Point(681, 458);
            this.openandeditfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openandeditfile.Name = "openandeditfile";
            this.openandeditfile.Size = new System.Drawing.Size(281, 79);
            this.openandeditfile.TabIndex = 16;
            this.openandeditfile.TabStop = false;
            this.openandeditfile.Visible = false;
            this.openandeditfile.Click += new System.EventHandler(this.openandeditfile_Click);
            // 
            // Client
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.Controls.Add(this.openandeditfile);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dropBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMess);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1082, 591);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openandeditfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.ListBox dropBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox openandeditfile;
    }
}