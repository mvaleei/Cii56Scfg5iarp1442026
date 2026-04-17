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
            archivio.Add(nuovaFattura);
            lbl_numero_fatture.Text=archivio.Count.ToString();
        }
    }
}
