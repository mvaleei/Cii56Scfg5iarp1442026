using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarieta
{
    abstract class Motore
    {
        string carburante = "";
        int cilindrata = 0;

        public Motore(string carburante, int cilindrata)
        {
            this.carburante = carburante;
            this.cilindrata = cilindrata;
        }
    }
}
