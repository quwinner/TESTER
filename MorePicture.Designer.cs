namespace WindowsFormsApp1
{
    partial class MorePicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MorePicture));
            this.BoxPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxPicture
            // 
            this.BoxPicture.BackColor = System.Drawing.Color.Transparent;
            this.BoxPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoxPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxPicture.Location = new System.Drawing.Point(0, 0);
            this.BoxPicture.Name = "BoxPicture";
            this.BoxPicture.Size = new System.Drawing.Size(1024, 720);
            this.BoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BoxPicture.TabIndex = 0;
            this.BoxPicture.TabStop = false;
            this.BoxPicture.DoubleClick += new System.EventHandler(this.MorePictureBox_DoubleClick);
            this.BoxPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MorePicture_MouseDown);
            this.BoxPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MorePicture_MouseMove);
            this.BoxPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MorePicture_MouseUp);
            // 
            // MorePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.BoxPicture);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MorePicture";
            this.Text = "MorePicture";
            this.TransparencyKey = System.Drawing.Color.Aqua;
            this.Load += new System.EventHandler(this.MorePicture_Load);
            this.VisibleChanged += new System.EventHandler(this.MorePicture_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MorePicture_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MorePicture_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MorePicture_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.BoxPicture)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox BoxPicture;
    }
}