using System.Collections;


namespace Fatturazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList archivio = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_numero_fatture.Text = archivio.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //recupero i dati digitati dall'utente
            int numeroF = System.Convert.ToInt16(npm_numero.Value);
            int importoF = System.Convert.ToInt16(npm_importo.Value);

            string tipoF = cmb_tipo.SelectedItem.ToString();
            string clienteF = txt_cliente.Text;

            //creo la nuova fattura
            Fattura nuovaFattura = new Fattura(clienteF, importoF, numeroF, tipoF);

            //controlliamo che non esiste il numero fattura
            //Tools strumenti = new Tools();
            //if (!strumenti.controlla(archivio, numeroF))
            if (!Tools.controlla(archivio, numeroF))
            {
                archivio.Add(nuovaFattura);
                lbl_numero_fatture.Text = archivio.Count.ToString();
            }
            else
            {
                MessageBox.Show("Attenzione fattura già esistente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ricerca = System.Convert.ToInt16(nmp_Ricerca.Value);
            Fattura fatturaDaCercare = Tools.ritorna(archivio, ricerca);
            if (Tools.ritorna(archivio, ricerca) == null)
            {
                MessageBox.Show("Fattura non trovata");
            }
            else
            {
                lbl_trovata.Text = fatturaDaCercare.riepilogo();
            }
        }
    }
}
