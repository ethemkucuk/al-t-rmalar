namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            char[] sesli = {'a','e','�','i','o','�','u','�' }; 
            string cumle = Convert.ToString(textBox1.Text);
            int adet = 0;
            for(int i = 0; i < cumle.Length; i++)
            {
                for(int j = 0; j < sesli.Length; j++)
                        {
                    if(sesli[j] == cumle[i])
                    {
                        adet++;
                        
                    }

                   }
            }
            textBox2.Text = adet.ToString(); */

            string harf = textBox1.Text; // String de�i�kenine textbox atad�k.

            if (harf == "a" || harf == "e" || harf == "�" || harf == "i" || harf == "o" || harf == "�" || harf == "u" || harf == "�") // Textboxdaki de�er burada varsa yani sesli harf ise listbox1'e ekliyoruz.
            {
                listBox1.Items.Add(harf);
            }
            else // de�ilse sessiz harf oluyor ve listbox2'e ekliyoruz.
            {
                listBox2.Items.Add(harf);
            }


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}