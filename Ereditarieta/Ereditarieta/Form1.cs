using System.Collections;

namespace Ereditarieta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList parco = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Vettura punto = new Vettura("Fiat", "Punto", 1200, "Benzina");
            Moto vfr = new Moto("Benzina", 750, 2);
            Trattori OM = new Trattori(195, 5000, "Diesel");

            parco.Add(punto);
            parco.Add(OM);
            parco.Add(vfr);

            lbl_numero.Text = parco.Count.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Motore m1 = new Motore("Elettrico", 1900);

            MessageBox.Show("Numero di veicoli nel parco: " + parco.Count);
            foreach (Object veicolo in parco)
            {
                if (veicolo is Vettura)
                {
                    MessageBox.Show("Vettura di tipo:" + ((Vettura)veicolo).modello);
                }
                if (veicolo is Moto)
                {
                    MessageBox.Show("Numero ruote della moto:" + ((Moto)veicolo).numeroRuote);
                }
                if (veicolo is Trattori)
                {
                    MessageBox.Show("Altezza del trattore:" + ((Trattori)veicolo).altezza);
                }


            }
        }
    }
}
