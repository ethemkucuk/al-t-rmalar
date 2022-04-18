namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int max = sayi1 * sayi2;
             int ebob = 0;
            int ekok = 0;

            for(int i = max; i > 0; i--)
            {
                if(i % sayi1 == 0 && i % sayi2 == 0)
                {
                    ekok = i;
                }
            }

            for(int i = 1; i < max; i++)
            {
                if(sayi1 % i == 0 && sayi2 % i == 0)
                {
                    ebob = i;
                }
            }

            label1.Text = "Ebob " + ebob;
            label2.Text = "Ekok " + ekok;
        }
    }
}