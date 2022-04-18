namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Increment(1);

            for (int i = 0; i <= 70; i++)
            {
                progressBar1.Value = i;
                label1.Text = "%" + i.ToString();

            }
            if(progressBar1.Value == 70)
            {
                timer1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}