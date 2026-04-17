using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classi
{
    class pennarello
    {
        //proprietà(field)
        public string colore = "Grigio";

        public string testo = "Marca mia";

        private int dimensione = 100;   //hiding information



        //proprietà il cui nome è Dimensione (che gestisce il field dimensione)
        public int Dimensione
        {
            get { return dimensione; }
            set
            {
                if (value > 150)
                {
                    dimensione = 150;
                }
                else
                {
                    dimensione = value;  //value =il valore che viene ricevuto nel metodo (utilizzato per assegnarlo al field)
                }
            }
        }

        //costruttore
        //costruttore di default
        /*
        public pennarello()
        {

        }
        */


        //parametrizzare la costruzione dell'oggetto
        //il nome del metodo DEVE essere IDENTICO al nome della classe
        //non ha nessuna chiave che distingue il tipo di dato (void/string/int/tipo)
        public pennarello(string colore, string testo)
        {
            //colore = coloreRicevuto;
            //testo = testoRicevuto;
            this.colore = colore;

            this.testo = testo;
        }


        public pennarello(string colore)
        {
            this.colore = colore;
        }

        public pennarello(int dimensionericevuta)
        {
            /*
            if (dimensione > 150)
            {
                this.dimensione = 150;
            }
            else
            {
                this.dimensione = dimensione;
            }
            */
            Dimensione = dimensionericevuta;
        }


        public void scrivere()
        {
            MessageBox.Show("Metodo che si esegue in modo autonomo");
            MessageBox.Show("La dimensione del pennarello di colore:" + this.colore + "è:" + this.dimensione);
        }


        //polimorfismo (overloading):
        //due metodi con lo stesso nome, MA firma diversa
        public void scrivere(string info)
        {
            MessageBox.Show("Metodo che si esegue in modo autonomo:" + info);
            MessageBox.Show("La dimensione del pennarello di colore:" + this.colore + "è:" + this.dimensione);
        }

        public void cambiaDimensione(int dimensionNuova)
        {
            this.dimensione = dimensionNuova;
        }

        public string tornaTesto()
        {
            //
            //
            //
            return this.testo;
        }


        public string checkDimensione(int dimensionaDesiderabile)
        {
            if (dimensionaDesiderabile > 150)
            {
                return "Fuori misura dello stabilimento";
            }
            else
            {
                return "Misura disponibile";
            }
        }


        public string riepilogo()
        {
            string torna = this.testo;
            torna += "-";
            torna += this.colore;
            torna += "-";
            torna += this.dimensione;
            return torna;

            //return this.testo + "-" + this.colore + "-" + this.dimensione;
        }
    }
}
