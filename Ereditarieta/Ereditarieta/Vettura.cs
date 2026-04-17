using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta
{
    class Vettura : Motore
    {
        string marca = "";
        public string modello = "";
        //int cilindrata = 0;
        //string carburante = "";

        public Vettura(string marca, string modello, int cilindrata, string carburante) : base(carburante, cilindrata)
        {
            this.marca = marca;
            this.modello = modello;
            //this.cilindrata = cilindrata;
            //this.carburante = carburante;
        }
    }
}
