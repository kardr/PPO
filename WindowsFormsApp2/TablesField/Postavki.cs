using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.TablesField
{
    class Postavki : Field
    {
        public string telefon, adress;
        public Postavki()
        {
            count = 4;
        }

        public override string getInfo()
        {
            return postav + "      " + adress + "      " + telefon;
        }
    }
}
