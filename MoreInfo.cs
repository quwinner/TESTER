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
    public partial class MoreInfo : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public static string MoreInfoText;
        public MoreInfo()
        {
            InitializeComponent();
        }
        private void MoreInfo_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            
            this.BackgroundImage = Class1.TestBackground;

            MoreInfoLabel.ForeColor = Class1.text;
        }

        private void MoreInfo_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MoreInfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void MoreInfo_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MoreInfoLabel_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void MoreInfo_VisibleChanged(object sender, EventArgs e)
        {
            MoreInfoLabel.Text = MoreInfoText;
        }
    }
}
