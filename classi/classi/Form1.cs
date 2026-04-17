using System.Collections;

namespace classi
{
    public partial class Form1 : Form
    {

        //costruttore
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList scatola = new ArrayList();

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

        private void button2_Click(object sender, EventArgs e)
        {
            pennarello pennaVerde = new pennarello("Verde", "Pennarello brutto");

            pennaVerde.scrivere("Oggetto del secondo pulsante");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pennarello pennaColore = new pennarello("Giallo");
            pennaColore.scrivere();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pennarello pennaDimensione = new pennarello(400);
            pennaDimensione.scrivere();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pennarello pennaDim = new pennarello(200);
            pennaDim.scrivere();
            //pennaDim.dimensione = 250;
            //pennaDim.scrivere();
            pennaDim.Dimensione = 600;
            pennaDim.scrivere();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //oggetto che getisce multi oggetti
            //strutture dati
            //arraylist (TOTALMENTE DINAMICO)
            //ArrayList scatola = new ArrayList();

            pennarello pen1 = new pennarello(120);
            pennarello pen2 = new pennarello(85);
            pennarello pen3 = new pennarello(200);

            //aggiungere oggetto all'arraylist
            scatola.Add(pen1);
            scatola.Add(pen2);
            scatola.Add(pen3);

            //MessageBox.Show(scatola.Count.ToString());

            pennarello pen4 = new pennarello(189);
            scatola.Add(pen4);
            //MessageBox.Show(scatola.Count.ToString());
            lbl_numero.Text = scatola.Count.ToString();

            scatola.Add("Ciao");
            scatola.Add(1500);
            //accesso alle posizioni:
            //MessageBox.Show(  ( (pennarello) scatola[0]   ).riepilogo()    );

            foreach (Object pennaLettura in scatola)
            {
                if (pennaLettura is pennarello)
                {
                    MessageBox.Show(((pennarello)pennaLettura).riepilogo());
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(scatola.Count.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {

            string cittaNascita = "Roma";

            string cittaLavoro = cittaNascita;

            //MessageBox.Show(cittaNascita + "-" + cittaLavoro);

            cittaLavoro = "Ancona";
            //MessageBox.Show(cittaNascita + "-" + cittaLavoro);


            pennarello penna1 = new pennarello("Nero", "Testo del pennarello 1");
            //gli oggetti non si possono copiare, perchè
            //hanno un riferimento (indirizzo di memoria)
            pennarello penna2 = penna1;
            //MessageBox.Show(penna1.riepilogo());
            //MessageBox.Show(penna2.riepilogo());

            penna2.testo = "Ciao da penna 2";
            //MessageBox.Show(penna1.riepilogo());
            //MessageBox.Show(penna2.riepilogo());


            pennarello penna3 = penna2;
            penna3.colore = "Giallo verde";
            //MessageBox.Show(penna1.riepilogo());
            //MessageBox.Show(penna2.riepilogo());
            //MessageBox.Show(penna3.riepilogo());

            pennarello pennaNuova = new pennarello(penna1.colore, penna1.testo);
            pennaNuova.Dimensione = penna1.Dimensione;
            pennaNuova.testo = "Sono la nuova penna";
            MessageBox.Show(penna1.riepilogo());
            MessageBox.Show(pennaNuova.riepilogo());

        }
    }
}
