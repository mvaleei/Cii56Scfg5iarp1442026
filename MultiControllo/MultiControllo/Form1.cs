namespace MultiControllo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string sport = "Rugby";
            string sport = txt_sport.Text;

            switch (sport.ToLower())  //.topUpper()
            {
                case "nuoto":
                case "pallanuoto":
                case "nuoto libero":
                    MessageBox.Show("Ti occorre la cuffia");
                    break;
                case "tennis":
                    MessageBox.Show("Non so chiamma Sinner");
                    break;
                case "rugby":
                    MessageBox.Show("Arnica");
                    break;
                default:
                    MessageBox.Show("Attenzione, sport non identificato, oppure magazzino vuoto");
                    break;
            }

            //MessageBox.Show(sport);

        }
    }
}
