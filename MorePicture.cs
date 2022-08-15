using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MorePicture : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public static Bitmap MoreImageBox;
        public MorePicture()
        {
            InitializeComponent();
        }
        private void MorePicture_Load(object sender, EventArgs e)
        {

            ShowInTaskbar = false;

            //this.BackgroundImage = Class1.TestBackground;

        }

        private void MorePicture_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MorePicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void MorePicture_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MorePictureBox_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void MorePicture_VisibleChanged(object sender, EventArgs e)
        {
            BoxPicture.Image = MoreImageBox;
        }
    }
}
