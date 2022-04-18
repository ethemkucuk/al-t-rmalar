namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string adi = Convert.ToString(textBox1.Text);
            string soyadý = Convert.ToString(textBox2.Text);
            int no = Convert.ToInt32(textBox3.Text);

            int[] sira = new int[10];

            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i.ToString() + ". " + adi + "\t" + soyadý + "\t" + no.ToString());
                
             
            }


            
        }
    }
}