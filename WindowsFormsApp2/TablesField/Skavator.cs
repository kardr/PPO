using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.TablesField
{
    class Skavator : TovarField
    {
        public string kovh, lopata, gabarit, ves;
        public Skavator()
        {
            count = 8;
        }
        public override string getInfo()
        {
            return vid + "    " + marka + "    "  + postav + "    " + ves + "    "  + lopata + "    " + kovh + "    " + gabarit;
        }
    }
}
