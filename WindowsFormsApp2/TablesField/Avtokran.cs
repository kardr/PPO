using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.TablesField
{
    class Avtokran : TovarField
    {
        public int gp, moment, mas;
        public Avtokran ()
        {
            count = 7;
        }

        public override string getInfo()
        {
            return  vid + "    " + marka + "    " + postav + "    " + gp + "    " + moment + "    " + mas;
        }
    }
}
