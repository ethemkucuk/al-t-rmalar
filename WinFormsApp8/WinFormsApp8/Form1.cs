namespace WinFormsApp8
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
            if (checkBox1.Checked)
            {
                int carpim = sayi1 * sayi2;
                label1.Text = "\n Çarpým : " + sayi1 * sayi2;
            }
            if (checkBox2.Checked)
            {
                float bolum =sayi1 / sayi2;
                label2.Text = "\n Bölüm : " + sayi1 / sayi2;
            }
        }
    }
}