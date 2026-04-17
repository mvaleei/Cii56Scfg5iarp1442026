using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta
{
    class Moto : Motore
    {
        //string carburante = "";
        //int cilindrata = 0;
        public int numeroRuote = 0;

        public Moto(string carburante, int cilindrata, int numeroRuote):base(carburante,cilindrata)
        {
            //this.carburante = carburante;
            //this.cilindrata = cilindrata;
            this.numeroRuote = numeroRuote;
        }
    }
}
