namespace DuyetFileTuXa
{
    partial class Server
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
            this.listMess = new System.Windows.Forms.RichTextBox();
            this.dropBox = new System.Windows.Forms.ListBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.lbLoading = new System.Windows.Forms.Label();
            this.openandeditfile = new System.Windows.Forms.PictureBox();
            this.btnSendMess = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.openandeditfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendMess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listMess
            // 
            this.listMess.Location = new System.Drawing.Point(16, 15);
            this.listMess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listMess.Name = "listMess";
            this.listMess.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.listMess.Size = new System.Drawing.Size(1033, 299);
            this.listMess.TabIndex = 1;
            this.listMess.Text = "";
            // 
            // dropBox
            // 
            this.dropBox.FormattingEnabled = true;
            this.dropBox.ItemHeight = 16;
            this.dropBox.Location = new System.Drawing.Point(16, 369);
            this.dropBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dropBox.Name = "dropBox";
            this.dropBox.Size = new System.Drawing.Size(492, 132);
            this.dropBox.TabIndex = 2;
            this.dropBox.Visible = false;
            this.dropBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropBox_DragDrop);
            this.dropBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropBox_DragEnter);
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(16, 337);
            this.txtMess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(857, 22);
            this.txtMess.TabIndex = 3;
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoading.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbLoading.Location = new System.Drawing.Point(681, 393);
            this.lbLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(0, 25);
            this.lbLoading.TabIndex = 6;
            // 
            // openandeditfile
            // 
            this.openandeditfile.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.openandeditfile;
            this.openandeditfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openandeditfile.Location = new System.Drawing.Point(681, 423);
            this.openandeditfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openandeditfile.Name = "openandeditfile";
            this.openandeditfile.Size = new System.Drawing.Size(281, 79);
            this.openandeditfile.TabIndex = 9;
            this.openandeditfile.TabStop = false;
            this.openandeditfile.Visible = false;
            this.openandeditfile.Click += new System.EventHandler(this.pictureBox3_Click_2);
            // 
            // btnSendMess
            // 
            this.btnSendMess.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.SendMess;
            this.btnSendMess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendMess.Location = new System.Drawing.Point(883, 322);
            this.btnSendMess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendMess.Name = "btnSendMess";
            this.btnSendMess.Size = new System.Drawing.Size(156, 64);
            this.btnSendMess.TabIndex = 8;
            this.btnSendMess.TabStop = false;
            this.btnSendMess.Click += new System.EventHandler(this.btnSendMess_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.open_file;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenFile.Location = new System.Drawing.Point(517, 441);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(156, 59);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.TabStop = false;
            this.btnOpenFile.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.Send;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(517, 369);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 64);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Server
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.Controls.Add(this.openandeditfile);
            this.Controls.Add(this.btnSendMess);
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.dropBox);
            this.Controls.Add(this.listMess);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1082, 591);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.openandeditfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendMess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox listMess;
        private System.Windows.Forms.ListBox dropBox;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnOpenFile;
        private System.Windows.Forms.Label lbLoading;
        private System.Windows.Forms.PictureBox btnSendMess;
        private System.Windows.Forms.PictureBox openandeditfile;
    }
}