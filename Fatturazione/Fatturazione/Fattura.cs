using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatturazione
{
    class Fattura
    {
        public string cliente = "";
        public int numero = 0;
        public int importo = 0;
        public string tipo = "";
        private int saldo = 0;
        private int iva = 0;

        public Fattura(string cliente, int importo, int numero, string tipo)
        {
            this.cliente = cliente;
            this.importo = importo;
            this.numero = numero;
            this.tipo = tipo;
            setIva();
            CalcolaSaldo();

        }


        private void setIva()
        {
            int ivaDaverifica = 0;
            switch (tipo.ToLower())
            {
                case "alimentari":
                    ivaDaverifica = 5;
                    break;
                case "edilizia":
                    ivaDaverifica = 10;
                    break;
                case "informatica":
                    ivaDaverifica = 22;
                    break;
                default:
                    ivaDaverifica = 22;
                    break;
            }
            this.iva = ivaDaverifica;

        }


        private void CalcolaSaldo()
        {
            saldo = importo + importo * iva / 100;

        }

        public string riepilogo()
        {
            string torna = cliente;
            torna += "-";
            torna += importo;
            torna += "-";
            torna += tipo;
            torna += "-";
            torna += saldo;
            return torna;
        }

    }
}
