namespace eta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeDigitato = txt_nome.Text;
            int annoNascita = System.Convert.ToInt16(nmp_anno.Value);

            int anniPersona = 2026-annoNascita;

            string risposta = "Il tuo nome è: " + nomeDigitato + " xxxx ed hai anni: " + anniPersona;
            MessageBox.Show(risposta);

        }
    }
}
