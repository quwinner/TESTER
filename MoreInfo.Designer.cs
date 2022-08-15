namespace WindowsFormsApp1
{
    partial class MoreInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreInfo));
            this.MoreInfoPanel = new System.Windows.Forms.Panel();
            this.MoreInfoLabel = new System.Windows.Forms.Label();
            this.MoreInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoreInfoPanel
            // 
            this.MoreInfoPanel.AutoScroll = true;
            this.MoreInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.MoreInfoPanel.Controls.Add(this.MoreInfoLabel);
            this.MoreInfoPanel.Location = new System.Drawing.Point(12, 12);
            this.MoreInfoPanel.Name = "MoreInfoPanel";
            this.MoreInfoPanel.Size = new System.Drawing.Size(1001, 626);
            this.MoreInfoPanel.TabIndex = 1;
            this.MoreInfoPanel.DoubleClick += new System.EventHandler(this.MoreInfoLabel_DoubleClick);
            this.MoreInfoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoreInfo_MouseDown);
            this.MoreInfoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoreInfo_MouseMove);
            this.MoreInfoPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoreInfo_MouseUp);
            // 
            // MoreInfoLabel
            // 
            this.MoreInfoLabel.AutoSize = true;
            this.MoreInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoreInfoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoreInfoLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoreInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MoreInfoLabel.Location = new System.Drawing.Point(-4, 0);
            this.MoreInfoLabel.Name = "MoreInfoLabel";
            this.MoreInfoLabel.Size = new System.Drawing.Size(136, 26);
            this.MoreInfoLabel.TabIndex = 0;
            this.MoreInfoLabel.Text = "MoreInfoLabel";
            this.MoreInfoLabel.DoubleClick += new System.EventHandler(this.MoreInfoLabel_DoubleClick);
            this.MoreInfoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoreInfo_MouseDown);
            this.MoreInfoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoreInfo_MouseMove);
            this.MoreInfoLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoreInfo_MouseUp);
            // 
            // MoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 650);
            this.Controls.Add(this.MoreInfoPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoreInfo";
            this.Text = "MoreInfo";
            this.Load += new System.EventHandler(this.MoreInfo_Load);
            this.VisibleChanged += new System.EventHandler(this.MoreInfo_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoreInfo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoreInfo_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoreInfo_MouseUp);
            this.MoreInfoPanel.ResumeLayout(false);
            this.MoreInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        public System.Windows.Forms.Label MoreInfoLabel;
        public System.Windows.Forms.Panel MoreInfoPanel;
    }
}