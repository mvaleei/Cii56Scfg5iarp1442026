namespace PrimaSchermata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bottone1_Click(object sender, EventArgs e)
        {
            int anni = 15;
            //anni = "pippo";
            /*
             riga di commento
             riga di commento
            */
            bool maggiorenne = true;
            String nome = "Carlo";
            MessageBox.Show("Sono il primo messaggio della nuova maschera");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono il secondo pulsante, per augurare buon pranzo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeDigitato = txt_nome.Text;
            MessageBox.Show("Il nome digitato é:" + nomeDigitato);
        }

        private void btn_anno_Click(object sender, EventArgs e)
        {
            int annodigitato = System.Convert.ToInt16( nmp_anno.Value);
            int annoDigitatoIncremento = annodigitato + 1;
            string annoFuturo = annoDigitatoIncremento.ToString();
            //string annoFuturo = "2027";
            int annofuturo = System.Convert.ToInt16(annoFuturo);
            MessageBox.Show("L'anno digitato è:" + annodigitato + " seguirà il: " + annofuturo);

        }
    }
}
