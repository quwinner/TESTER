namespace WindowsFormsApp1
{
    public partial class FormTest
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTest));
            this.Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Itog = new System.Windows.Forms.Button();
            this.Menu_exit = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.Panel_Vopros = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gg = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Next.Location = new System.Drawing.Point(748, 3);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(124, 38);
            this.Next.TabIndex = 1;
            this.Next.Text = "Следующий";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            this.Next.MouseLeave += new System.EventHandler(this.Next_MouseLeave);
            this.Next.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Next_MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "№";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(498, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Itog
            // 
            this.Itog.BackColor = System.Drawing.Color.Transparent;
            this.Itog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Itog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Itog.FlatAppearance.BorderSize = 0;
            this.Itog.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Itog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Itog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Itog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Itog.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Itog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Itog.Location = new System.Drawing.Point(0, 0);
            this.Itog.Name = "Itog";
            this.Itog.Size = new System.Drawing.Size(138, 38);
            this.Itog.TabIndex = 5;
            this.Itog.Text = "Итог";
            this.Itog.UseVisualStyleBackColor = false;
            this.Itog.Click += new System.EventHandler(this.Itog_Click);
            this.Itog.MouseLeave += new System.EventHandler(this.Itog_MouseLeave);
            this.Itog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Itog_MouseMove);
            // 
            // Menu_exit
            // 
            this.Menu_exit.BackColor = System.Drawing.Color.Transparent;
            this.Menu_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu_exit.FlatAppearance.BorderSize = 0;
            this.Menu_exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Menu_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Menu_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Menu_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_exit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.Menu_exit.Location = new System.Drawing.Point(3, 3);
            this.Menu_exit.Name = "Menu_exit";
            this.Menu_exit.Size = new System.Drawing.Size(114, 38);
            this.Menu_exit.TabIndex = 9;
            this.Menu_exit.Text = "Меню";
            this.Menu_exit.UseVisualStyleBackColor = false;
            this.Menu_exit.Click += new System.EventHandler(this.Menu_exit_Click);
            this.Menu_exit.MouseLeave += new System.EventHandler(this.Menu_exit_MouseLeave);
            this.Menu_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_exit_MouseMove);
            // 
            // label_result
            // 
            this.label_result.BackColor = System.Drawing.Color.Transparent;
            this.label_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_result.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label_result.Location = new System.Drawing.Point(0, 0);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(138, 38);
            this.label_result.TabIndex = 10;
            this.label_result.Text = "lrs";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_result.Visible = false;
            // 
            // Panel_Vopros
            // 
            this.Panel_Vopros.AutoScroll = true;
            this.Panel_Vopros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Panel_Vopros.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Vopros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel_Vopros.Location = new System.Drawing.Point(0, 0);
            this.Panel_Vopros.Name = "Panel_Vopros";
            this.Panel_Vopros.Size = new System.Drawing.Size(72, 553);
            this.Panel_Vopros.TabIndex = 0;
            this.Panel_Vopros.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(478, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Benzol11;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Exit.Location = new System.Drawing.Point(991, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(25, 23);
            this.Exit.TabIndex = 15;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            this.Exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Next, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Menu_exit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 603);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 44);
            this.tableLayoutPanel1.TabIndex = 16;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Itog);
            this.panel1.Controls.Add(this.label_result);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(878, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 38);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label2.Location = new System.Drawing.Point(123, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 44);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Panel_Vopros);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(858, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 553);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(78, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 553);
            this.panel3.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gg, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1019, 559);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // gg
            // 
            this.gg.AutoEllipsis = true;
            this.gg.BackColor = System.Drawing.Color.Transparent;
            this.gg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.gg.Location = new System.Drawing.Point(3, 0);
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(469, 559);
            this.gg.TabIndex = 3;
            this.gg.Text = "Vopros";
            this.gg.DoubleClick += new System.EventHandler(this.gg_DoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.Controls.Add(this.Exit, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1019, 29);
            this.tableLayoutPanel3.TabIndex = 19;
            this.tableLayoutPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseDown);
            this.tableLayoutPanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseMove);
            this.tableLayoutPanel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseUp);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1025, 650);
            this.tableLayoutPanel4.TabIndex = 20;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.TestFon_v1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 650);
            this.Controls.Add(this.tableLayoutPanel4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTest";
            this.Text = "Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTest_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTest_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormTest_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Itog;
        private System.Windows.Forms.Button Menu_exit;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Panel Panel_Vopros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gg;
        private System.Windows.Forms.Panel panel3;
    }
}

