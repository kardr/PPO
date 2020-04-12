using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.TablesField
{
    class Gidrobur : TovarField
    {
        public int ves, davlenie, dlina;
        public Gidrobur()
        {
            count = 7;
        }
        public override string getInfo()
        {
            return vid + "    " + marka + "    " + postav + "    " + ves + "    " + davlenie + "    " + dlina;
        }
    }
}
