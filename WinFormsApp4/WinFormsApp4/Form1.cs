namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hareket(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                panel2.Top -= 10;
            }
            if(e.KeyCode == Keys.Down)
            {
                panel2.Top += 10;
            }
            if(e.KeyCode == Keys.Left)
            {
                panel2.Left -= 10;
            }
            if (e.KeyCode == Keys.Right)
            {
                panel2.Left += 10;
            }

        }
        Random Random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {

            panel4.Location = new Point(panel4.Location.X, panel4.Location.Y);
            int xp = Random.Next(100, 900);
            int yp = Random.Next(100, 500);

            

            if(panel1.Top < panel2.Top)
            {
                panel1.Top++;
            }
            if(panel1.Top > panel2.Top)
            {
                panel1.Top--;
            }
            if(panel1.Left < panel2.Left)
            {
                panel1.Left++;
            }
            if(panel1.Left > panel2.Left)
            {
                panel1.Left--;
            }
            //
            if (panel3.Top > panel2.Top)
            {
                panel3.Top--;
            }
            if (panel3.Top < panel2.Top)
            {
                panel3.Top++;
            }
            if (panel3.Left > panel2.Left)
            {
                panel3.Left--;
            }
            if (panel3.Left < panel2.Left)
            {
                panel3.Left++;
            }
            //
            if(panel1.Location != panel4.Location)
            {
                panel4.Location = new Point((int)xp, (int)yp);
            }
            
            

        }
    }
}