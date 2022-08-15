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
    public partial class FormTest : Form
    {
        public MoreInfo start = new MoreInfo();
        public MorePicture morePicture = new MorePicture();

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

        List<string> list_vopros = new List<string>();
        int nomer_voprosa = 0;
        int skoko;
        string sps;
        bool resultat;
        bool vsi_zap = false;

        public FormTest(List<string> vvod, string asdfgh, bool reer = false)
        {
            InitializeComponent();
            list_vopros = vvod;
            resultat = reer;
            sps = asdfgh;
        }
        vopros[] voprosy;

        private void Form1_Load(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////////////////////

            this.BackgroundImage = Class1.TestBackground;

            panel3.BackColor = Class1.TestPanel;
            Panel_Vopros.BackColor = Class1.TestPanel;
            textBox1.BackColor = Class1.BoxOtvet;

            /////////////////////////////////////////////////////////////////////////////

            start.Show();
            start.Visible = false;

            morePicture.Show();
            morePicture.Visible = false;

            label2.ForeColor = Class1.text2;

            this.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width - FormMenu.Screen.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Size.Height - FormMenu.Screen.Height) / 2);
            this.Size = FormMenu.Screen;
            label_result.Visible = false;
            textBox1.ReadOnly = false;

            if (resultat)
            {
                skoko = list_vopros.Count / 5;
                voprosy = new vopros[skoko];
                for (int i = 0; i < skoko; i++)
                {
                    voprosy[i].type = Convert.ToInt32(list_vopros[i * 5]);
                    voprosy[i].vopr = list_vopros[i * 5 + 1].Replace("||#!$!#||", "|!|");
                    voprosy[i].prav_otvet = list_vopros[i * 5 + 2].Replace("||#!$!#||", "|!|");
                    voprosy[i].otvet = "";
                    if (Convert.ToInt32(list_vopros[i * 5]) == 2)
                    {
                        voprosy[i].kartinca = list_vopros[i * 5 + 3];
                    }
                    voprosy[i].otvet = list_vopros[i * 5 + 4].Replace("||#!$!#||", "|!|");
                }
                Itog_Click(sender, e);
            }
            else
            {
                skoko = list_vopros.Count / 4;
                voprosy = new vopros[skoko];
                for (int i = 0; i < skoko; i++)
                {
                    voprosy[i].type = Convert.ToInt32(list_vopros[i * 4]);
                    voprosy[i].vopr = list_vopros[i * 4 + 1].Replace("||#!$!#||", "|!|");
                    voprosy[i].prav_otvet = list_vopros[i * 4 + 2].Replace("||#!$!#||", "|!|");
                    voprosy[i].otvet = "";
                    if (Convert.ToInt32(list_vopros[i * 4]) == 2)
                    {
                        voprosy[i].kartinca = list_vopros[i * 4 + 3];
                    }
                }


            }

            gg.ForeColor = Class1.text;
            Menu_exit.ForeColor = Class1.text;
            label_result.ForeColor = Class1.text;
            Itog.ForeColor = Class1.text;
            label1.ForeColor = Class1.text2;
            Next.ForeColor = Class1.text2;

            for (int i = 0; i < skoko; i++)
            {
                Label label12 = new Label();
                label12.AutoSize = true;
                label12.Font = new Font("AR DESTINE", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                label12.ForeColor = Class1.color_standart;
                label12.Location = new Point(3, 10 + 20 * i);
                label12.Name = i.ToString();
                label12.Size = new Size(60, 20);
                label12.TabIndex = 0;
                label12.Text = " " + (1 + i).ToString();
                label12.Click += new EventHandler(this.label3_Click);
                Panel_Vopros.Controls.Add(label12);
            }
            Panel_Vopros.Controls[nomer_voprosa].Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Panel_Vopros.Controls[nomer_voprosa].BackColor = Color.FromArgb(20, 20, 20);
            Panel_Vopros.Controls[nomer_voprosa].ForeColor = Class1.color_videl;
            label1.Text = "Задание" + Panel_Vopros.Controls[nomer_voprosa].Text;
            gg.Text = voprosy[Convert.ToInt32(Panel_Vopros.Controls[nomer_voprosa].Name)].vopr;
            label2.Text = voprosy[nomer_voprosa].prav_otvet;
            textBox1.Text = voprosy[nomer_voprosa].otvet;
            try
            {
                pictureBox1.Image = new Bitmap(sps + voprosy[nomer_voprosa].kartinca);
            }
            catch (Exception)
            { pictureBox1.Image = null; }

        }

        void label3_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            morePicture.Visible = false;

            voprosy[nomer_voprosa].otvet = textBox1.Text;
            foreach (Control rr in Panel_Vopros.Controls)
            {
                if (voprosy[Convert.ToInt32(rr.Name)].otvet != "")
                {
                    rr.ForeColor = Class1.color_vopros_s_otvet;
                }
                else
                {
                    rr.ForeColor = Class1.color_standart;
                }
                rr.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
                rr.BackColor = Color.Transparent;
                if (sender.Equals(rr))
                {
                    rr.ForeColor = Class1.color_videl;
                    rr.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                    rr.BackColor = Class1.back_videl;
                    label1.Text = "Задание" + rr.Text;
                    nomer_voprosa = Convert.ToInt32(rr.Name);
                    try
                    {
                        pictureBox1.Image = new Bitmap(sps + voprosy[nomer_voprosa].kartinca);
                    }
                    catch (Exception)
                    { pictureBox1.Image = null; }
                    GC.Collect(2);
                    label2.Text = voprosy[nomer_voprosa].prav_otvet;
                    gg.Text = voprosy[Convert.ToInt32(rr.Name)].vopr;
                    
                    textBox1.Text = voprosy[nomer_voprosa].otvet;
                }
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {

            start.Visible = false;
            morePicture.Visible = false;
            if (nomer_voprosa == skoko - 1)
            {
                if(resultat || vsi_zap)
                {
                    voprosy[nomer_voprosa].otvet = textBox1.Text;
                    k_voprosy(0);
                }
                else
                {
                    for (int i = 0; i < skoko; i++)
                    {
                        if (voprosy[i].otvet == "")
                        {
                            voprosy[nomer_voprosa].otvet = textBox1.Text;
                            k_voprosy(i);
                            break;
                        }
                        else
                        {
                            vsi_zap = true;
                        }
                    }
                }
            }
            else
            {
                voprosy[nomer_voprosa].otvet = textBox1.Text;
                k_voprosy(nomer_voprosa + 1);
            }
        }
        void k_voprosy(int nom)
        {
            foreach (Control rr in Panel_Vopros.Controls)
            {
                if (voprosy[Convert.ToInt32(rr.Name)].otvet != "")
                {
                    rr.ForeColor = Class1.color_vopros_s_otvet;
                }
                else
                {
                    rr.ForeColor = Class1.color_standart;
                }
                rr.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
                rr.BackColor = Color.Transparent;
            }
            foreach (Control rr in Panel_Vopros.Controls)
            {
                if (Convert.ToInt32(rr.Name) == nom)
                {
                    rr.ForeColor = Class1.color_videl;
                    nomer_voprosa = Convert.ToInt32(rr.Name);
                    rr.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                    rr.BackColor = Class1.back_videl;
                    label1.Text = "Задание" + rr.Text;
                    try
                    {
                        pictureBox1.Image = new Bitmap(sps + voprosy[nomer_voprosa].kartinca);
                    }
                    catch (Exception)
                    { pictureBox1.Image = null; }
                    gg.Text = voprosy[Convert.ToInt32(rr.Name)].vopr;
                    textBox1.Text = voprosy[nomer_voprosa].otvet;
                    label2.Text = voprosy[nomer_voprosa].prav_otvet;
                    break;
                }
            }
            GC.Collect(2);
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

        private void Itog_Click(object sender, EventArgs e)
        {
            GC.Collect(2);
            textBox1.ReadOnly = true;
            if(!resultat)
            voprosy[nomer_voprosa].otvet = textBox1.Text;
            GC.WaitForPendingFinalizers();
            result();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_exit_Click(object sender, EventArgs e)
        {
            GC.Collect(2);
            this.Close();
            start.Close();
            morePicture.Close();
        }

        void result()
        {
            label2.Visible = true;
            int skolko_prav = new int();
            Itog.Visible = false;
            for (int i = 0; i < skoko; i++)
            {
                Label label_res = new Label();
                if (voprosy[i].otvet.ToUpper() == voprosy[i].prav_otvet.ToUpper())
                {
                    label_res.Text = " Верно ";
                    label_res.ForeColor = Color.Green;
                    skolko_prav++;
                }
                else
                {
                    label_res.Text = " Неверно ";
                    label_res.ForeColor = Color.Red;
                }
                label_res.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular);
                label_res.AutoSize = true;
                label_res.Location = new Point(0, 10 + 20 * i);
                label_res.Name = "label_res" + i;
                label_res.Size = new Size(60, 20);
                label_res.TabIndex = 0;
                panel3.Controls.Add(label_res);
            }
            label_result.Visible = true;
            label_result.Text = skolko_prav + "/" + skoko;
            if(resultat)
            {

            }
            else
            {


                string gfgf = "";
                string[] sssaa = sps.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                if (Directory.Exists("data\\" + sssaa[sssaa.Length - 1]))
                {
                    foreach (string s1 in Directory.GetFiles("data\\" + sssaa[sssaa.Length - 1]))
                    {
                        File.Delete(s1);
                    }
                    Directory.Delete("data\\" + sssaa[sssaa.Length - 1]);
                }
                CopyDir(sps, "data\\" + sssaa[sssaa.Length - 1]);
                File.Delete("data\\" + sssaa[sssaa.Length - 1] + "\\" + sssaa[sssaa.Length - 1] + ".rtesr");
                for (int i = 0; i < skoko; i++)
                {
                    gfgf += voprosy[i].type.ToString() + "|!|";
                    gfgf += voprosy[i].vopr.Replace("|!|", "||#!$!#||") + "|!|";
                    gfgf += voprosy[i].prav_otvet.Replace("|!|", "||#!$!#||") + "|!|";
                    if (voprosy[i].kartinca == null)
                    {
                        gfgf += "  |!|";
                    }
                    else
                    {
                        gfgf += voprosy[i].kartinca + "|!|";
                    }
                    if (voprosy[i].otvet == "")
                    {
                        gfgf += " " + "|!|\r\n";
                    }
                    else
                    {
                        gfgf += voprosy[i].otvet.Replace("|!|", "||#!$!#||") + "|!|\r\n";
                    }
                }
            File.WriteAllText("data\\" + sssaa[sssaa.Length - 1] + "\\" + sssaa[sssaa.Length - 1] + ".rresr", gfgf, Encoding.Default);
                string[] vvod = File.ReadAllText("data\\history.rhisr", Encoding.Default).Split(new string[] { "!@#%$)(&^+_" }, StringSplitOptions.RemoveEmptyEntries);
                string sasdas = "";
                if(vvod.Length == 5)
                {
                    foreach (string s1 in Directory.GetFiles("data\\" + vvod[vvod.Length - 1]))
                    {
                        File.Delete(s1);
                    }
                    Directory.Delete("data\\" + vvod[vvod.Length - 1]);
                }
                for(int i = 0; i < 4 && i < vvod.Length; i++)
                {
                    if(sssaa[sssaa.Length - 1] != vvod[i])
                    sasdas += "!@#%$)(&^+_" + vvod[i];
                }
                File.WriteAllText("data\\history.rhisr", sssaa[sssaa.Length - 1] + sasdas, Encoding.Default);
            }
        }

        void CopyDir(string FromDir, string ToDir)
        {
            Directory.CreateDirectory(ToDir);
            foreach (string s1 in Directory.GetFiles(FromDir))
            {
                string s2 = ToDir + "\\" + Path.GetFileName(s1);
                File.Copy(s1, s2);
            }
            foreach (string s in Directory.GetDirectories(FromDir))
            {
                CopyDir(s, ToDir + "\\" + Path.GetFileName(s));
            }
        }

        private void gg_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(0, 0);
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            this.Size = resolution;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string jh = Environment.CurrentDirectory;
            gg.Text = jh;
        }

        private void Menu_exit_MouseMove(object sender, MouseEventArgs e)
        {
            Menu_exit.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.videl1;
        }

        private void Menu_exit_MouseLeave(object sender, EventArgs e)
        {
            Menu_exit.BackgroundImage = null;
        }

        private void Next_MouseMove(object sender, MouseEventArgs e)
        {
            Next.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.videl1;
        }

        private void Next_MouseLeave(object sender, EventArgs e)
        {
            Next.BackgroundImage = null;
        }

        private void Itog_MouseMove(object sender, MouseEventArgs e)
        {
            Itog.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.videl1;
        }

        private void Itog_MouseLeave(object sender, EventArgs e)
        {
            Itog.BackgroundImage = null;
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_MouseMove(object sender, MouseEventArgs e)
        {
            Exit.BackgroundImage = Properties.Resources.Benzol1_1;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackgroundImage = Properties.Resources.Benzol1;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void gg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                MoreInfo.MoreInfoText = gg.Text;
                start.Visible = true;
            }
            catch (Exception)
            {
                start.Visible = false;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
  
            try
            {
                MorePicture.MoreImageBox = new Bitmap(sps + voprosy[nomer_voprosa].kartinca);
                morePicture.Visible = true;
            }
            catch (Exception)
            {
                morePicture.Visible = false;
            }
        }

        private void FormTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect(2);
        }

        private void FormTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect(2);
        }
    }
}
