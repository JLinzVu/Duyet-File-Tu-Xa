using System.Drawing;

namespace DuyetFileTuXa
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
            this.btnClient = new System.Windows.Forms.PictureBox();
            this.btnServer = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.Client;
            this.btnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClient.Location = new System.Drawing.Point(71, 297);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(168, 49);
            this.btnClient.TabIndex = 3;
            this.btnClient.TabStop = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnServer
            // 
            this.btnServer.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.Server;
            this.btnServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnServer.Location = new System.Drawing.Point(71, 242);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(168, 49);
            this.btnServer.TabIndex = 2;
            this.btnServer.TabStop = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.TitleLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(71, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 142);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DuyetFileTuXa.Properties.Resources.IMG1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(344, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 337);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Main menu";
            ((System.ComponentModel.ISupportInitialize)(this.btnClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnServer;
        private System.Windows.Forms.PictureBox btnClient;
    }
}

