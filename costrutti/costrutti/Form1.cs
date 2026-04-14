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
    }
}
