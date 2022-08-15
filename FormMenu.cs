using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    public partial class FormMenu : Form
    {
        public static Size Screen = new Size(1025, 650);
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        public FormMenu()
        {
            InitializeComponent();
        }

        string sdf;
        bool ddsa = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1.tema();

            this.Size = Class1.FormSize;
            vkladka_acc.Location = Class1.vkladka_acc;
            vkladka_history.Location = Class1.vkladka_history;
            vkladka_tema.Location = Class1.vkladka_tema;
            vkladka_exit.Location = Class1.vkladka_exit;

            Videlen.Location = Class1.Videlen;
            Normvopos.Location = Class1.Normvopos;
            VoprosSotvet.Location = Class1.VoprosSotvet;
            Text1.Location = Class1.Text1;
            Text2.Location = Class1.Text2;
            Westigon.Location = Class1.Westigon;
            Trigon.Location = Class1.Trigon;

            StartTest.Location = Class1.StartTest;
            BoxObzor.Location = Class1.BoxObzor;
            Obzor.Location = Class1.Obzor;
            Histori.Location = Class1.Histori;
            HistoriLabel.Location = Class1.HistoriLabel;

            FullScreen.Location = Class1.FullScreen;
            Screen1537x975.Location = Class1.Screen1537x975;
            Screen1250x1250.Location = Class1.Screen1250x1250;

            TestMenu.Location = Class1.TestMenu;

            Variant.Location = Class1.Variant;

            GifBox.Image = Class1.GifBox;
            this.BackgroundImage = Class1.ForMenu;
            StartTest.BackgroundImage = Class1.StartTestImage;
            vkladka_history.BackgroundImage = Class1.vkladka_historyImage;
            Histori.BackgroundImage = Class1.HistoryImage;

            //Videlen.ForeColor =
            //Normvopos.ForeColor =
            //VoprosSotvet.ForeColor =
            //Text1.ForeColor =
            //Text2.ForeColor =
            //Histori.ForeColor =

            HistoriLabel.ForeColor = Class1.ColorTema;
            Westigon.ForeColor = Class1.ColorTema;
            Trigon.ForeColor = Class1.ColorTema;
            Obzor.ForeColor = Class1.ColorTema;
            FullScreen.ForeColor = Class1.ColorTema;
            Screen1537x975.ForeColor = Class1.ColorTema;
            Screen1250x1250.ForeColor = Class1.ColorTema;
            TestMenu.ForeColor = Class1.ColorTema;
            Variant.ForeColor = Class1.ColorTema;

            sleep();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            string[] hfhoa = File.ReadAllText("data\\history.rhisr", Encoding.Default).Split(new string[] { "!@#%$)(&^+_" }, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < hfhoa.Length && i < 5; i++)
            {
                Label label12 = new Label();
                label12.AutoSize = true;
                label12.Font = new Font("AR DESTINE", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                label12.ForeColor = Class1.color_standart;
                label12.Location = new Point(3, 10 + 20 * i);
                label12.Name = i.ToString();
                label12.Size = new Size(60, 20);
                label12.TabIndex = 0;
                label12.Text = hfhoa[i];
                label12.Click += new EventHandler(this.vClick);
                Histori.Controls.Add(label12);
            }
            

            if (1025 > System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width || 650 > System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height)
            {
                Screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            }
            else
            {
                Screen = new Size(1025, 650);
            }
            Screen1250x1250.Checked = true;
            VoprosSotvet.ForeColor = Class1.color_vopros_s_otvet;
            Text1.ForeColor = Class1.text;
            Text2.ForeColor = Class1.text2;
            Videlen.ForeColor = Class1.color_videl;
            Normvopos.ForeColor = Class1.color_standart;
            

            foreach(Control crt in this.Controls)
            {
                if(crt.Tag.ToString() != "norm" && crt.Tag.ToString() != "cxsdf")
                {
                    crt.Visible = false;
                }
            }
            TestMenu.Visible = false;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private async void sleep()
        {
            await Task.Delay(3000);
            GifBox.Visible = false;
            this.Controls.Remove(GifBox);
            this.TransparencyKey = System.Drawing.Color.FromArgb(9, 173, 174);
        }

        private void Start_test_Click(object sender, EventArgs e)
        {
            try
            {
                string vvod = File.ReadAllText(sdf, Encoding.Default);
                List<string> vvodlist = new List<string>(vvod.Split(new string[] { "|!|" }, StringSplitOptions.RemoveEmptyEntries));
                string[] qwwq = BoxObzor.Text.Split('\\');
                string dsas = "";
                for(int i = 0; i < qwwq.Length - 1; i++)
                {
                    dsas += qwwq[i] + "\\";
                }
                FormTest start = new FormTest(vvodlist, dsas);
                this.Visible = false;
                start.ShowDialog();
                try
                {
                    GC.Collect(2);
                    this.Visible = true;
                    Histori.Controls.Clear();
                    string[] hfhoa = File.ReadAllText("data\\history.rhisr", Encoding.Default).Split(new string[] { "!@#%$)(&^+_" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < hfhoa.Length && i < 5; i++)
                    {
                        Label label12 = new Label();
                        label12.AutoSize = true;
                        label12.Font = new Font("AR DESTINE", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                        label12.ForeColor = Class1.color_standart;
                        label12.Location = new Point(3, 10 + 20 * i);
                        label12.Name = i.ToString();
                        label12.Size = new Size(60, 20);
                        label12.TabIndex = 0;
                        label12.Text = hfhoa[i];
                        label12.Click += new EventHandler(this.vClick);
                        Histori.Controls.Add(label12);
                    }
                }
                catch (Exception)
                {

                }
            }
            catch(Exception)
            {

            }
        }

        private void vClick(object sender, EventArgs e)
        {
            foreach ( Control eded in Histori.Controls)
            {
                if (sender.Equals(eded))
                {
                    string vvod = File.ReadAllText("data\\" + eded.Text + "\\" + eded.Text + ".rresr", Encoding.Default);
                    List<string> vvodlist = new List<string>(vvod.Split(new string[] { "|!|" }, StringSplitOptions.RemoveEmptyEntries));
                    FormTest start = new FormTest(vvodlist, "data\\" + eded.Text + "\\", true);
                    this.Visible = false;
                    start.ShowDialog();
                    try
                    {
                        GC.Collect(2);
                        this.Visible = true;
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void vkladka_tema_Click(object sender, EventArgs e)
        {
            TestMenu.Text = "Настройка темы";
            foreach(Control ctr in this.Controls)
            {
                if(ctr.Tag.ToString() != "norm")
                {
                    if(ctr.Tag.ToString() == "f")
                    {
                        ctr.Visible = !ctr.Visible;
                    }
                    else
                    {
                        ctr.Visible = false;
                    }
                    TestMenu.Visible = Videlen.Visible;
                }
            }
        }

        private void vkladka_history_Click(object sender, EventArgs e)
        {
            TestMenu.Text = "Тестовое начало";
            
            foreach (Control ctr in this.Controls)
            {
                if (ctr.Tag.ToString() != "norm")
                {
                    if (ctr.Tag.ToString() == "h")
                    {
                        ctr.Visible = !ctr.Visible;
                    }
                    else
                    {
                        ctr.Visible = false;
                    }
                }
            }
            TestMenu.Visible = Obzor.Visible;
            if(BoxObzor.Text != "" && Obzor.Visible)
            {
                StartTest.Visible = true;
            }
            else
            {
                StartTest.Visible = false;
            }
        }

        private void vkladka_acc_Click(object sender, EventArgs e)
        {
            FormAddTest start = new FormAddTest();
            this.Visible = false;
            start.ShowDialog();
            try
            {
                this.Visible = true;
            }
            catch (Exception)
            {

            }
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

        private void vkladka_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Tect-файлы|*.rtesr";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sdf = dialog.FileName;
                BoxObzor.Text = dialog.FileName;
            }
            if (BoxObzor.Text != "")
            {
                sdf = BoxObzor.Text;
                StartTest.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                sdf = BoxObzor.Text;
                StartTest.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Class1.color_videl = f.Color;
                Videlen.ForeColor = f.Color;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            if(f.ShowDialog() == DialogResult.OK)
            {
                Class1.color_standart = f.Color;
                Normvopos.ForeColor = f.Color;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Class1.color_vopros_s_otvet = f.Color;
                VoprosSotvet.ForeColor = f.Color;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Class1.text = f.Color;
                Text1.ForeColor = f.Color;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Class1.text2 = f.Color;
                Text2.ForeColor = f.Color;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(ddsa)
            {
                this.Size = new Size(this.Size.Width * 2, this.Size.Height);
            }
            else
            {
                this.Size = new Size(this.Size.Width / 2, this.Size.Height);
            }
            ddsa = !ddsa;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string vvod = File.ReadAllText("var1\\var1.rtesr", Encoding.Default);
            List<string> vvodlist = new List<string>(vvod.Split(new string[] { "|!|" }, StringSplitOptions.RemoveEmptyEntries));
            FormTest start = new FormTest(vvodlist, "var1\\");
            this.Visible = false;
            start.ShowDialog();
            try
            {
                Histori.Controls.Clear();
                string[] hfhoa = File.ReadAllText("data\\history.rhisr", Encoding.Default).Split(new string[] { "!@#%$)(&^+_" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < hfhoa.Length && i < 5; i++)
                {
                    Label label12 = new Label();
                    label12.AutoSize = true;
                    label12.Font = new Font("AR DESTINE", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                    label12.ForeColor = Class1.color_standart;
                    label12.Location = new Point(3, 10 + 20 * i);
                    label12.Name = i.ToString();
                    label12.Size = new Size(60, 20);
                    label12.TabIndex = 0;
                    label12.Text = hfhoa[i];
                    label12.Click += new EventHandler(this.vClick);
                    Histori.Controls.Add(label12);
                }
                this.Visible = true;
            }
            catch (Exception)
            {

            }
        }


        private void FullScreen_CheckedChanged(object sender, EventArgs e)
        {
            Screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
        }

        private void Screen1537x975_CheckedChanged(object sender, EventArgs e)
        {
            if(1537 > System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width || 975 > System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height)
            {
                Screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            }
            else
            {
                Screen = new Size(1537, 975);
            }
        }

        private void Screen1250x1250_CheckedChanged(object sender, EventArgs e)
        {
            if (1025 > System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width || 650 > System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height)
            {
                Screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            }
            else
            {
                Screen = new Size(1025, 650);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void westigon_Click(object sender, EventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey tema = currentUserKey.CreateSubKey("tema");
            tema.SetValue("VidTema", "1");
            tema.Close();
            Application.Restart();
        }

        private void trigon_Click(object sender, EventArgs e)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey tema = currentUserKey.CreateSubKey("tema");
            tema.SetValue("VidTema", "2");
            tema.Close();
            Application.Restart();
        }
    }
}
