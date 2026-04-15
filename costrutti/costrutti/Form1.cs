namespace costrutti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anni = 13;

            if (anni > 17)
            {
                MessageBox.Show("Risulti essere maggiorenne");
            }
            else
            {
                MessageBox.Show("Sei minorenne, chiama i tuoi genitori");
            }

            //string citta = "roma";
            string citta = txt_citta.Text;

            if (citta.Equals("roma") == true)   //citta.Equals("roma")
            {
                MessageBox.Show("Sei nato nel lazio");
            }
            else if (citta.Equals("firenze") == true)
            {
                MessageBox.Show("Sei nato in toscana");
            }
            else if (citta.Equals("bari") == true)
            {
                MessageBox.Show("Sei nato in puglia");
            }
            else
            {
                MessageBox.Show("Città non gestita");
            }


            citta = "Bologna";


            if (citta.Equals("roma") != true)   //!citta.Equals("roma")
            {
                MessageBox.Show("Sei nato in altre regioni");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            int anniDigitati = System.Convert.ToInt16(nmp_anni.Value);

            /*
            if (anniDigitati < 12)
            {
                MessageBox.Show("Non assicurabile");
            }
            else if (anniDigitati >= 12 && anniDigitati <= 17)
            {
                MessageBox.Show("Premio relativo ai teen ager");
            }
            else if (anniDigitati >= 18 && anniDigitati <= 25)
            {
                MessageBox.Show("Premio relativo ai ragazzi");
            }
            else if (anniDigitati >= 26 && anniDigitati <= 50)
            {
                MessageBox.Show("Premio relativo aagli adulti");
            }
            else if (anniDigitati > 50 && anniDigitati <= 70)
            {
                MessageBox.Show("Premio relativo ai grandi");
            }
            else
            {
                MessageBox.Show("Premio non conveniente");
            }
            */


            if (anniDigitati == 18 && anniDigitati == 25)
            {
                MessageBox.Show("Appartieni ai ragazzi");
            }
            else
            {
                MessageBox.Show("Altro tipo di persona");
            }


        }
    }
}
