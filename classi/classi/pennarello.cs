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

        //costruttore
        //costruttore di default
        /*
        public pennarello()
        {

        }
        */


        //parametrizzare la costruzione dell'oggetto

        public pennarello(string colore, string testo)
        {
            //colore = coloreRicevuto;
            //testo = testoRicevuto;
            this.colore = colore;

            this.testo = testo;
        }


        public void scrivere()
        {
            MessageBox.Show("Metodo che si esegue in modo autonomo");
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
    }
}
