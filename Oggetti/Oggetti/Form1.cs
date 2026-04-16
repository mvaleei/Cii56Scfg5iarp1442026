namespace Oggetti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int anni = 33;
            //string nome = "Pippo";  

            //array monodimensionale  statico nella dimensione
            int[] anni = new int[3];
            //tipodidato []  nomenuovooggetto = new(istanza) tipodidato[numero elementi];
            string[] citta = new string[4];

            anni[0] = 55;
            anni[1] = 42;
            anni[2] = 37;

            //MessageBox.Show(anni.Count().ToString());

            for (int indice = 0; indice < anni.Count(); indice++)
            {
                //MessageBox.Show("Il valore della posizione è:" + anni[indice]);
            }

            /*
            citta[0] = "Il valore della posizione è: 0";
            citta[1] = "Il valore della posizione è: 1";
            citta[2] = "Il valore della posizione è: 2";
            citta[3] = "Il valore della posizione è: 3";
            */

            //scritto nelle singole posizioni
            for (int i = 0; i < citta.Count(); i++)
            {
                citta[i] = "Valore della posizione: " + i;
            }


            //leggere dalle singole posizioni
            for (int i = 0; i < citta.Count(); i++)
            {
                //MessageBox.Show(citta[i]);
            }

            //foreach
            int variabileBase = 0;
            foreach (int variabiletempoanea in anni)
            {
                variabileBase = variabiletempoanea;
                //MessageBox.Show("Il valore letto è: " + variabiletempoanea);
                if (variabiletempoanea > 50)
                {
                    //MessageBox.Show("Sei grande");
                }
                else
                {
                    //MessageBox.Show("Sei giovane");
                }
            }

            //MessageBox.Show(variabileBase.ToString());

            foreach (Control oggettoGrafico in this.Controls)
            {
                //MessageBox.Show(oggettoGrafico.Name);
            }
            MessageBox.Show(anni.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmb_end.Items.Clear();
            foreach (string dato in cmb_start.Items)
            {
                //MessageBox.Show(dato);
                cmb_end.Items.Add(dato);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //creo il nuovo oggetto (istanziando la classe)
            Label nuovaEtichetta = new Label();    //astrazione

            //configuro il nuovo oggetto
            nuovaEtichetta.Text = "Sono una nuova etichetta creata in run-time";
            nuovaEtichetta.Size = new Size(400, 80);
            nuovaEtichetta.Location = new Point(100, 50);
            nuovaEtichetta.Name = "EtichettaNuova" + this.Controls.Count;

            //agguingiamo al form
            this.Controls.Add(nuovaEtichetta);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numero di oggetti grafici nella form:" + this.Controls.Count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control oggetto in this.Controls)
            {
                MessageBox.Show(oggetto.Name);
            }
        }
    }
}
