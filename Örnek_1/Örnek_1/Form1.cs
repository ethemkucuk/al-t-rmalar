namespace Örnek_1
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
            long sonuc = 1;
            long sonuc2 = 1;
            int kontrol = 0;

            if (radioButton1.Checked)
            {
                for(int i = 1; i<max; i++)
                {
                    if(sayi1%i == 0 && sayi2%i == 0)
                    {
                        ebob = i;
                    }
                }
                label3.Text = "\n" + "Ebob : " + ebob.ToString();
            }

            if (radioButton2.Checked)
            {
                for( int i = max; i>0; i--)
                {
                    if(i%sayi1 ==0 && i%sayi2 == 0)
                    {
                        ekok = i;
                    }
                }
                label3.Text = "\n" + "Ekok : " + ekok.ToString();
            }

            if (radioButton3.Checked)
            {
                for(int i = 1; i <= sayi1; i++)
                {
                    sonuc = sonuc * i;

                    
                }
                
                label4.Text = "\n" + "1.Sayı Faktööriyeli : " + sonuc.ToString();
                for (int i = 1; i <= sayi2; i++)
                {
                    sonuc2 = sonuc2 * i;
                    
                }
                label3.Text = "\n" + "2.Sayı Faktööriyeli : " + sonuc2.ToString();

            }
            if (radioButton4.Checked)
            {
                for(int i = 1; i <= sayi1; i++)
                {
                    if(sayi1 % 2 == 0)
                    {
                        break;
                    }
                }
                if (kontrol == 2)
                {
                    label3.Text = "1.SAYI ASAL";
                }
                if(kontrol != 2)
                {
                    label3.Text = "1. Sayı ASal değil";
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}