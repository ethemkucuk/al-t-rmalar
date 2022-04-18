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
            char[] sesli = {'a','e','ý','i','o','ö','u','ü' }; 
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

            string harf = textBox1.Text; // String deðiþkenine textbox atadýk.

            if (harf == "a" || harf == "e" || harf == "ý" || harf == "i" || harf == "o" || harf == "ö" || harf == "u" || harf == "ü") // Textboxdaki deðer burada varsa yani sesli harf ise listbox1'e ekliyoruz.
            {
                listBox1.Items.Add(harf);
            }
            else // deðilse sessiz harf oluyor ve listbox2'e ekliyoruz.
            {
                listBox2.Items.Add(harf);
            }


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}