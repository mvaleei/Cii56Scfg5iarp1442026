namespace classi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            pennarello pennaNera = new pennarello();    

            pennarello pennaRossa = new pennarello();

            MessageBox.Show("Il colore del pennarello nero è:" + pennaNera.colore);
            MessageBox.Show("Il colore del pennarello rosso è:" + pennaRossa.colore);

            pennaNera.colore = "Nero";
            pennaRossa.colore = "rosso";

            MessageBox.Show("Il colore del pennarello nero è:" + pennaNera.colore);
            MessageBox.Show("Il colore del pennarello rosso è:" + pennaRossa.colore);
            */

            pennarello pennaRossa = new pennarello("Rosso", "Testo mio");
            pennarello pennaNera = new pennarello("Nero", "Testo cavaliere nero");
            //MessageBox.Show("Il colore del pennarello nero è:" + pennaNera.colore);
            //MessageBox.Show("Il colore del pennarello rosso è:" + pennaRossa.colore);

            //pennaNera.scrivere();
            //pennaRossa.scrivere();
            //
            //pennaNera.cambiaDimensione(120);
            //pennaRossa.cambiaDimensione(160);

            //pennaNera.scrivere();
            //pennaRossa.scrivere();

            //string testoPennaNera = pennaNera.tornaTesto();
            //string testopennaRossa = pennaRossa.tornaTesto();

            //MessageBox.Show(testoPennaNera + "-" + testopennaRossa);

            string controlloPennaNera = pennaNera.checkDimensione(500);
            string controlloPennaRossa = pennaRossa.checkDimensione(90);

            MessageBox.Show(controlloPennaNera + "-" + controlloPennaRossa);


        }
    }
}
