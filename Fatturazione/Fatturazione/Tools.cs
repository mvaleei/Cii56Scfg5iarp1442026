using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatturazione
{
    class Tools
    {
        public static bool controlla(ArrayList archivioDaControllare, int numerodaControllare)
        {
            bool verifica = false;  //false che non esiste
            foreach (Fattura fat in archivioDaControllare)
            {
                if (fat.numero == numerodaControllare)
                {
                    verifica = true;
                }
            }
            return verifica;
        }

        public static Fattura ritorna(ArrayList archivioDaControllare, int numerodaControllare)
        {
            
            foreach (Fattura fat in archivioDaControllare)
            {
                if (fat.numero == numerodaControllare)
                {
                    return fat; ;
                }
            }
            return null;
        }




    }
}
