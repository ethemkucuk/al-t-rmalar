namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {

            if(label1.Top > label2.Top)
            {
                label1.Top--;
            }
            if(label1.Top < label2.Top)
            {
                label1.Top++;
            }
            if(label1.Left > label2.Left)
            {
                label1.Left--;
            }
            if(label1.Left < label2.Left)
            {
                label1.Left++;
            }

            if(label1.Location != label2.Location)
            {
                label3.Text = random.Next(1, 10).ToString();
                label4.Text = random.Next(1, 10).ToString();
                label5.Text = random.Next(1, 10).ToString();
            }
            if(label1.Location == label2.Location)
            {
                label6.Text = "Bravo !";
            }

        }

        private void hareket(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                label2.Top -= 10;
            }
            if(e.KeyCode == Keys.Down)
            {
                label2.Top += 10;
            }
            if (e.KeyCode == Keys.Left)
            {
                label2.Left -= 10;
            }
            if(e.KeyCode == Keys.Right)
            {
                label2.Left += 10;
            }



        }
    }
}