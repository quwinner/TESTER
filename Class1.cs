using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    class Class1
    {
        static public Size FormSize;

        static public Point vkladka_history;
        static public Point vkladka_acc;
        static public Point vkladka_tema;
        static public Point vkladka_exit;

        static public Point FullScreen;
        static public Point Screen1537x975;
        static public Point Screen1250x1250;

        static public Point Videlen;
        static public Point Normvopos;
        static public Point VoprosSotvet;
        static public Point Text1;
        static public Point Text2;
        static public Point Westigon;
        static public Point Trigon;

        static public Point Histori;
        static public Point Obzor;
        static public Point BoxObzor;
        static public Point StartTest;
        static public Point HistoriLabel;

        static public Point TestMenu;

        static public Point Variant;

        static public Image GifBox;
        static public Image ForMenu;
        static public Image StartTestImage;
        static public Image TestBackground;
        static public Image vkladka_historyImage;
        static public Image HistoryImage;

        static public Color ColorTema;

        static public Color TestPanelAdd;
        static public Color TestPanel;
        static public Color BoxOtvet;

        /////////////////////////////////////////////////////////////////////////////

        static public Color back_videl;
        static public Color color_videl;
        static public Color color_standart;
        static public Color color_vopros_s_otvet;
        static public Color text;
        static public Color text2;
        static public Color color_zakras_stand;
        static public Color color_vopros_stand;

        /////////////////////////////////////////////////////////////////////////////
        
        public static void tema()
        {
            try
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey tema = currentUserKey.OpenSubKey("tema");
                string vidTema = tema.GetValue("VidTema").ToString();
                int VidTema = Convert.ToInt16(vidTema);

            if (VidTema == 1)
            {
                FormSize = new Size(525, 525);

                vkladka_history = new Point(47, 160);
                vkladka_acc = new Point(47, 215);
                vkladka_tema = new Point(47, 277);
                vkladka_exit = new Point(47, 344);

                Videlen = new Point(211, 213);
                Normvopos = new Point(187, 258);
                VoprosSotvet = new Point(184, 300);
                Text1 = new Point(160, 343);
                Text2 = new Point(310, 343);
                Westigon = new Point(160, 390);
                Trigon = new Point(280, 390);

                StartTest = new Point(222, 223);
                BoxObzor = new Point(175, 354);
                Obzor = new Point(222, 395);
                Histori = new Point(318, 185);
                Variant = new Point(207, 160);
                HistoriLabel = new Point(320, 160);

                FullScreen = new Point(118, 160);
                Screen1537x975 = new Point(221, 160);
                Screen1250x1250 = new Point(318, 160);

                TestMenu = new Point(155, 106);

                GifBox = global::WindowsFormsApp1.Properties.Resources.westigon_5;
                ForMenu = global::WindowsFormsApp1.Properties.Resources.Benzol_menu5;
                StartTestImage = global::WindowsFormsApp1.Properties.Resources.Benzol_start2;
                vkladka_historyImage = global::WindowsFormsApp1.Properties.Resources.vkladka_history2;
                HistoryImage = global::WindowsFormsApp1.Properties.Resources.Histori_v1_1;

                ColorTema = Color.FromArgb(10, 240, 240);

                TestBackground = global::WindowsFormsApp1.Properties.Resources.TestFon;

                TestPanelAdd = Color.FromArgb(50, 50, 50);
                TestPanel = Color.FromArgb(40, 40, 40);
                BoxOtvet = Color.FromArgb(80, 80, 80);

                color_videl = Color.FromArgb(15, 249, 255);
                color_standart = Color.FromArgb(15, 249, 255);
                color_vopros_s_otvet = Color.FromArgb(20, 249, 20);
                text = Color.FromArgb(15, 249, 255);
                text2 = Color.FromArgb(92, 255, 255);
                color_zakras_stand = Color.FromArgb(15, 249, 255);
                color_vopros_stand = Color.FromArgb(15, 249, 255);
                back_videl = Color.FromArgb(20, 20, 20);
               }

            else
            {
                FormSize = new Size(650, 650);

                vkladka_history = new Point(99, 214);
                vkladka_acc = new Point(99, 269);
                vkladka_tema = new Point(99, 331);
                vkladka_exit = new Point(99, 398);

                Videlen = new Point(143, 270);
                Normvopos = new Point(143, 315);
                VoprosSotvet = new Point(143, 360);
                Text1 = new Point(143, 405);
                Text2 = new Point(229, 405);
                Westigon = new Point(392, 285);
                Trigon = new Point(392, 331);


                StartTest = new Point(163, 285);
                BoxObzor = new Point(147, 428);
                Obzor = new Point(147, 454);
                Histori = new Point(275, 250);
                Variant = new Point(148, 223); 
                HistoriLabel = new Point(275, 223);

                FullScreen = new Point(131, 238);
                Screen1537x975 = new Point(227, 238);
                Screen1250x1250 = new Point(314, 238);

                TestMenu = new Point(105, 188);

                GifBox = global::WindowsFormsApp1.Properties.Resources.Trigon_1;
                ForMenu = global::WindowsFormsApp1.Properties.Resources.Hexagon_v1;
                StartTestImage= global::WindowsFormsApp1.Properties.Resources.Start;    
                vkladka_historyImage= global::WindowsFormsApp1.Properties.Resources.vkladka_history_v1_5;
                HistoryImage = global::WindowsFormsApp1.Properties.Resources.Histori_v1;

                ColorTema = Color.FromArgb(0, 180, 110);

                TestBackground = global::WindowsFormsApp1.Properties.Resources.TestFon_v1;

                TestPanelAdd = Color.FromArgb(220, 220, 220);
                TestPanel = Color.FromArgb(200, 200, 200);
                BoxOtvet = Color.FromArgb(200, 200, 200);

                color_videl = Color.FromArgb(0, 220, 240);
                color_standart = Color.FromArgb(0, 180, 180);
                color_vopros_s_otvet = Color.FromArgb(0, 200, 20);
                text = Color.FromArgb(0, 150, 100);
                text2 = Color.FromArgb(0, 200, 150);
                color_zakras_stand = Color.FromArgb(15, 249, 255);
                color_vopros_stand = Color.FromArgb(15, 249, 255);
                back_videl = Color.FromArgb(140, 140, 140);
               }
            }
            catch (Exception)
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey tema = currentUserKey.CreateSubKey("tema");
                tema.SetValue("VidTema", "1");
                tema.Close();
                Application.Restart();
            }
        }
    }
}
