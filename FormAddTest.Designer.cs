namespace WindowsFormsApp1
{
    partial class FormAddTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTest));
            this.Panel_Vopros = new System.Windows.Forms.Panel();
            this.TextBox_Otvet = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.Menu_exit = new System.Windows.Forms.Button();
            this.Vopros_Box = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveAddTest = new System.Windows.Forms.Button();
            this.PictureRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Vopros
            // 
            this.Panel_Vopros.AutoScroll = true;
            this.Panel_Vopros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Panel_Vopros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel_Vopros.Location = new System.Drawing.Point(905, 26);
            this.Panel_Vopros.Name = "Panel_Vopros";
            this.Panel_Vopros.Size = new System.Drawing.Size(117, 536);
            this.Panel_Vopros.TabIndex = 0;
            // 
            // TextBox_Otvet
            // 
            this.TextBox_Otvet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TextBox_Otvet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Otvet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBox_Otvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Otvet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextBox_Otvet.Location = new System.Drawing.Point(594, 594);
            this.TextBox_Otvet.Name = "TextBox_Otvet";
            this.TextBox_Otvet.Size = new System.Drawing.Size(291, 31);
            this.TextBox_Otvet.TabIndex = 5;
            this.TextBox_Otvet.Text = "ответ";
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Transparent;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(128)))));
            this.plus.Location = new System.Drawing.Point(440, 594);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(40, 40);
            this.plus.TabIndex = 6;
            this.plus.Text = "+1";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Transparent;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(21)))), ((int)(((byte)(91)))));
            this.minus.Location = new System.Drawing.Point(531, 593);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(40, 40);
            this.minus.TabIndex = 7;
            this.minus.Text = "-1";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // Menu_exit
            // 
            this.Menu_exit.BackColor = System.Drawing.Color.Transparent;
            this.Menu_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu_exit.FlatAppearance.BorderSize = 0;
            this.Menu_exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Menu_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Menu_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Menu_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_exit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Menu_exit.Location = new System.Drawing.Point(10, 585);
            this.Menu_exit.Name = "Menu_exit";
            this.Menu_exit.Size = new System.Drawing.Size(120, 40);
            this.Menu_exit.TabIndex = 9;
            this.Menu_exit.Text = "Меню";
            this.Menu_exit.UseVisualStyleBackColor = false;
            this.Menu_exit.Click += new System.EventHandler(this.Menu_exit_Click);
            this.Menu_exit.MouseLeave += new System.EventHandler(this.Menu_exit_MouseLeave);
            this.Menu_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_exit_MouseMove);
            // 
            // Vopros_Box
            // 
            this.Vopros_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Vopros_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Vopros_Box.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Vopros_Box.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vopros_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Vopros_Box.Location = new System.Drawing.Point(10, 26);
            this.Vopros_Box.Multiline = true;
            this.Vopros_Box.Name = "Vopros_Box";
            this.Vopros_Box.Size = new System.Drawing.Size(393, 536);
            this.Vopros_Box.TabIndex = 10;
            this.Vopros_Box.Text = "Вопрос";
            this.Vopros_Box.TextChanged += new System.EventHandler(this.Vopros_Box_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(413, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SaveAddTest
            // 
            this.SaveAddTest.BackColor = System.Drawing.Color.Transparent;
            this.SaveAddTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveAddTest.FlatAppearance.BorderSize = 0;
            this.SaveAddTest.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.SaveAddTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaveAddTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAddTest.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAddTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SaveAddTest.Location = new System.Drawing.Point(902, 585);
            this.SaveAddTest.Name = "SaveAddTest";
            this.SaveAddTest.Size = new System.Drawing.Size(120, 40);
            this.SaveAddTest.TabIndex = 9;
            this.SaveAddTest.Text = "Сохранить";
            this.SaveAddTest.UseVisualStyleBackColor = false;
            this.SaveAddTest.Click += new System.EventHandler(this.button1_Click);
            this.SaveAddTest.MouseLeave += new System.EventHandler(this.SaveAddTest_MouseLeave);
            this.SaveAddTest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SaveAddTest_MouseMove);
            // 
            // PictureRemove
            // 
            this.PictureRemove.BackColor = System.Drawing.Color.Transparent;
            this.PictureRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureRemove.FlatAppearance.BorderSize = 0;
            this.PictureRemove.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PictureRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PictureRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PictureRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PictureRemove.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PictureRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PictureRemove.Location = new System.Drawing.Point(413, 527);
            this.PictureRemove.Name = "PictureRemove";
            this.PictureRemove.Size = new System.Drawing.Size(489, 35);
            this.PictureRemove.TabIndex = 9;
            this.PictureRemove.Text = "Удалить картинку";
            this.PictureRemove.UseVisualStyleBackColor = false;
            this.PictureRemove.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FormAddTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.TestFon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 650);
            this.Controls.Add(this.PictureRemove);
            this.Controls.Add(this.SaveAddTest);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Vopros_Box);
            this.Controls.Add(this.Menu_exit);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.TextBox_Otvet);
            this.Controls.Add(this.Panel_Vopros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddTest";
            this.Load += new System.EventHandler(this.FormAddTest_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Vopros;
        private System.Windows.Forms.TextBox TextBox_Otvet;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button Menu_exit;
        private System.Windows.Forms.TextBox Vopros_Box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SaveAddTest;
        private System.Windows.Forms.Button PictureRemove;
    }
}