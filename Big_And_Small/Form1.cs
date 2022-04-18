using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_And_Small
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tuslar(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                label5.Top -= 10;
            }
            if(e.KeyCode == Keys.S)
            {
                label5.Top += 10;
            }
            if (e.KeyCode == Keys.D)
            {
                label5.Left += 10;
            }
            if (e.KeyCode == Keys.A)
            {
                label5.Left -= 10;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;

            label4.Location = new Point(x, y);
            if (x > px)
            {

            }
        }
    }
}
