namespace CreaLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_conferma_Click(object sender, EventArgs e)
        {
            int numeroLabel = System.Convert.ToInt16(nmp_numero.Value);
            string testo = txt_Testo.Text;
            int locationX = 50;
            int locationY = 50;

            for (int i = 0; i < numeroLabel; i++)
            {
                Label nuovaEtichetta = new Label();
                nuovaEtichetta.Text = txt_Testo.Text;
                nuovaEtichetta.Size = new Size(100, 80);
                nuovaEtichetta.Location = new Point(locationX + (100 * i), locationY);
                nuovaEtichetta.Name = "label" + i;

                this.Controls.Add(nuovaEtichetta);
            }



            /*
            int locationX = 10;
            int locationY = 10;

            


            int etichetta = System.Convert.ToInt16(nmp_numero.Value);
            int[] Array = new int[100];

            for (int i = 0; i < 100; i++)
            {
                Array[i] = 0;
            }

            for (int i = 0; i < etichetta; i++)
            {
                Array[i] = 1;
            }


            foreach (int Variabile in Array)
            {
                
                if (Variabile == 1)
                {
                    // MessageBox.Show("sto entrando nel ciclo per creare la nuova label");
                    Label nuovaEtichetta = new Label();
                    nuovaEtichetta.Text = txt_Testo.Text;
                    nuovaEtichetta.Size = new Size(40, 80);
                    nuovaEtichetta.Location = new Point(locationX, locationY);
                    
                    this.Controls.Add(nuovaEtichetta);
                    locationX += 100;
                    locationY = 10;

                }
   
        } */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Controls.Count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control oggetto in this.Controls)
            {
                if (oggetto.Name == "label0")
                {
                    MessageBox.Show("hai già cliccato sul pulsante. almeno una volta");
                }
            }
        }
        
    }
}

