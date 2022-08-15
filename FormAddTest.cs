using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAddTest : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public struct vopros
        {
            public int type;
            public string vopr;
            public string prav_otvet;
            public string otvet;
            public int nomer_otveta;
            public string[] otveti;
            public string kartinca;
        }

        vopros[] d = new vopros[100]; 
        List<Label> lbl = new List<Label>();
        int k = 1;
        int nomer_vopr = 0;
        
        
        public FormAddTest()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (k == 99)
            {
                MessageBox.Show("Нельзя создать больше 100 вопросов");
            }
            else
            {
                k++;
                d[nomer_vopr].otvet = TextBox_Otvet.Text;
                d[nomer_vopr].vopr = Vopros_Box.Text;

                Panel_Vopros.Controls.Clear();

                for (int i = 0; i < k; i++)
                {
                    Label label_vopros = new Label();
                    label_vopros.AutoSize = true;
                    label_vopros.Font = new Font("AR DESTINE", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                    label_vopros.ForeColor = Class1.color_standart;
                    label_vopros.Location = new Point(3, 10 + 20 * i);
                    label_vopros.Name = i.ToString();
                    label_vopros.Size = new Size(60, 20);
                    label_vopros.TabIndex = 0;
                    label_vopros.Text = " " + (i + 1).ToString();
                    label_vopros.Click += new EventHandler(this.label3_Click);
                    Panel_Vopros.Controls.Add(label_vopros);
                    lbl.Add(label_vopros);
                }
                nomer_vopr++;
                for (int i = k; i > nomer_vopr; i--)
                {
                    d[i] = d[i - 1];
                }
                d[nomer_vopr] = new vopros();
                foreach (Control rr in Panel_Vopros.Controls)
                {
                    rr.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
                    rr.BackColor = Color.Transparent;
                    if (d[Convert.ToInt32(rr.Name)].otvet == "" || d[Convert.ToInt32(rr.Name)].vopr == "")
                    {
                        rr.BackColor = Color.Red;
                    }
                }
                foreach (Control rr in Panel_Vopros.Controls)
                {
                    if (nomer_vopr == Convert.ToInt32(rr.Name))
                    {
                        rr.ForeColor = Class1.color_videl;
                        rr.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                        rr.BackColor = Class1.back_videl;
                        TextBox_Otvet.Text = d[nomer_vopr].otvet;
                        Vopros_Box.Text = d[nomer_vopr].vopr;
                        if (d[nomer_vopr].kartinca != null)
                        {
                            pictureBox1.Image = new Bitmap(d[nomer_vopr].kartinca);
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                    }
                }
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if(k==1)
            {
                if(MessageBox.Show("Вы хотите удалить последний вопрос, что приведёт к отключению конструктора. Вы уверены?", "Закрыть конструктор теста?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                k--;
                Panel_Vopros.Controls.Clear();

                for (int i = nomer_vopr; i < k; i++)
                {
                    d[i] = d[i + 1];
                }


                for (int i = 0; i < k; i++)
                {
                    Label label_vopros = new Label();
                    label_vopros.AutoSize = true;
                    label_vopros.Font = new Font("AR DESTINE", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                    label_vopros.ForeColor = Class1.color_standart;
                    label_vopros.Location = new Point(3, 10 + 20 * i);
                    label_vopros.Name = i.ToString();
                    label_vopros.Size = new Size(60, 20);
                    label_vopros.TabIndex = 0;
                    label_vopros.Text = " " + (i + 1).ToString();
                    label_vopros.Click += new EventHandler(this.label3_Click);
                    Panel_Vopros.Controls.Add(label_vopros);
                }
                if (nomer_vopr == 0)
                {
                }
                else
                {
                    nomer_vopr--;
                }
                foreach (Control rr in Panel_Vopros.Controls)
                {
                    rr.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
                    rr.BackColor = Color.Transparent;
                    if (d[Convert.ToInt32(rr.Name)].otvet == "" || d[Convert.ToInt32(rr.Name)].vopr == "")
                    {
                        rr.BackColor = Color.Red;
                    }

                }
                foreach (Control rr in Panel_Vopros.Controls)
                {
                    if (nomer_vopr == Convert.ToInt32(rr.Name))
                    {
                        rr.ForeColor = Class1.color_videl;
                        rr.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                        rr.BackColor = Class1.back_videl;
                        TextBox_Otvet.Text = d[nomer_vopr].otvet;
                        Vopros_Box.Text = d[nomer_vopr].vopr;
                        if (d[nomer_vopr].kartinca != null)
                        {
                            pictureBox1.Image = new Bitmap(d[nomer_vopr].kartinca);
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                        break;
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            d[nomer_vopr].otvet = TextBox_Otvet.Text;
            d[nomer_vopr].vopr = Vopros_Box.Text;

                foreach (Control rr in Panel_Vopros.Controls)
                {
                    rr.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
                    rr.ForeColor = Class1.color_standart;
                    rr.BackColor = Color.Transparent;
                    if (d[Convert.ToInt32(rr.Name)].otvet == "" || d[Convert.ToInt32(rr.Name)].vopr == "")
                    {
                        rr.BackColor = Color.Red;
                    }
                if (sender.Equals(rr))
                    {
                        rr.ForeColor = Class1.color_videl;
                        rr.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                        rr.BackColor = Class1.back_videl;
                        nomer_vopr = Convert.ToInt32(rr.Name);
                    }
                }
            TextBox_Otvet.Text = d[nomer_vopr].otvet;
            Vopros_Box.Text = d[nomer_vopr].vopr;
            if (d[nomer_vopr].kartinca != null)
            {
                pictureBox1.Image = new Bitmap(d[nomer_vopr].kartinca);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
        void k_vopr()
        {

        }

        private void Menu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddTest_Load(object sender, EventArgs e)
        {

            this.BackgroundImage = Class1.TestBackground;

            Vopros_Box.ForeColor = Class1.text;
            PictureRemove.ForeColor = Class1.text;
            Menu_exit.ForeColor = Class1.text;
            SaveAddTest.ForeColor = Class1.text;
            Vopros_Box.BackColor = Class1.TestPanelAdd;
            pictureBox1.BackColor = Class1.TestPanelAdd;
            Panel_Vopros.BackColor = Class1.TestPanel;
            TextBox_Otvet.BackColor = Class1.BoxOtvet;


            for (int i = 0; i < 100; i++)
            {
                d[i].type = 1;
            }
            Label label_vopros = new Label();
            label_vopros.AutoSize = true;
            label_vopros.BackColor = Class1.back_videl;
            label_vopros.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label_vopros.ForeColor = Class1.color_videl;
            label_vopros.Location = new Point(3, 10);
            label_vopros.Name = "0";
            label_vopros.Size = new Size(60, 20);
            label_vopros.TabIndex = 0;
            label_vopros.Text = " " + "1";
            label_vopros.Click += new EventHandler(this.label3_Click);
            Panel_Vopros.Controls.Add(label_vopros);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d[nomer_vopr].otvet = TextBox_Otvet.Text;
            d[nomer_vopr].vopr = Vopros_Box.Text;
            SaveFileDialog SD = new SaveFileDialog();
            SD.Filter = "Тест|*.rtesr";
            if (SD.ShowDialog() == DialogResult.OK)
            {
                string fd = "";
                string fi = SD.FileName;
                string[] fss = fi.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                string[] ddsa = fss[fss.Length - 1].Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                string ds = "";
                for (int i = 0; i < fss.Length - 1; i++)
                {
                    ds += fss[i] + "\\";
                }

                ds += ddsa[0];
                DirectoryInfo dirInfo = new DirectoryInfo(ds);
                dirInfo.Create();
                ds += "\\";
                for (int i = 0; i < k; i++)
                {
                    if (!(d[i].otvet == null || d[i].vopr == null || d[i].otvet == "" || d[i].vopr == ""))
                    {
                        fd += d[i].type.ToString() + "|!|";
                        fd += d[i].vopr.Replace("|!|", "||#!$!#||") + "|!|";
                        fd += d[i].otvet.Replace("|!|", "||#!$!#||") + "|!|";
                        if (d[i].kartinca == null)
                        {
                            fd += "  |!|\r\n";
                        }
                        else
                        {
                            string[] fq = d[i].kartinca.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                            string name = fq[fq.Length - 1].Remove(fq[fq.Length - 1].LastIndexOf('.') + 1) + "rconr";
                            FileInfo ss = new FileInfo(d[i].kartinca);
                            ss.CopyTo(ds + name);
                            File.SetAttributes(ds + name, FileAttributes.Hidden);
                            //File.Move(ds + fq[fq.Length - 1], ds + fq[fq.Length - 1].Remove( (ds + fq[fq.Length - 1]).LastIndexOf('.') + 1) +"rconr");
                            fd += name + "|!|\r\n";
                        }
                    }
                }
                if(fd == "")
                {
                    MessageBox.Show("Вы пытаетесь создать тест без вопросов", "Ошибка!");
                    dirInfo.Delete();
                }
                else
                {
                    File.WriteAllText(ds + fss[fss.Length - 1], fd, Encoding.Default);
                }
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "картинка|*.bmp;*.jpg;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                d[nomer_vopr].kartinca = dialog.FileName;
                pictureBox1.Image = new Bitmap(dialog.FileName);
                d[nomer_vopr].type = 2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            d[nomer_vopr].kartinca = null;
            d[nomer_vopr].type = 1;
        }
        private void FormTest_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        void sd()
        {
            if (this.Location.X < 0)
            {
                this.Location = new Point(0, this.Location.Y);
            }
            if (this.Location.X > System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width - this.Size.Width)
            {
                this.Location = new Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width - this.Size.Width, this.Location.Y);
            }
            if (this.Location.Y < 0)
            {
                this.Location = new Point(this.Location.X, 0);
            }
            if (this.Location.Y > System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height - this.Size.Height)
            {
                this.Location = new Point(this.Location.X, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height - this.Size.Height);
            }
        }

        private void FormTest_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormTest_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            sd();
        }

        private void Menu_exit_MouseMove(object sender, MouseEventArgs e)
        {
            Menu_exit.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.videl1;
        }

        private void Menu_exit_MouseLeave(object sender, EventArgs e)
        {
            Menu_exit.BackgroundImage = null;
        }


        private void SaveAddTest_MouseLeave(object sender, EventArgs e)
        {
            SaveAddTest.BackgroundImage = null;
        }

        private void SaveAddTest_MouseMove(object sender, MouseEventArgs e)
        {
            SaveAddTest.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.videl1;
        }

        private void Vopros_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
