using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
     class Buldozer : TovarField
    {
        public int massa, dlina, visot;
        public Buldozer()
        {
            count = 7;
        }
        public override string getInfo()
        {
            return vid + "    " + marka + "    " + postav + "    " + massa + "    " + dlina + "    " + visot;
        }

    }
}
