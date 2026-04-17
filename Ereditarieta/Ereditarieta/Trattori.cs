using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta
{
    class Trattori:Motore
    {
        public int altezza = 0;
        //int cilindrata = 0;
        //string carburante = "";

        public Trattori(int altezza, int cilindrata, string carburante) : base(carburante, cilindrata)
        {
            this.altezza = altezza;
            //this.cilindrata = cilindrata;
            //this.carburante = carburante;

        }
    }
}
