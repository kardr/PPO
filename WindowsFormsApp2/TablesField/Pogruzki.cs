using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Pogruzki : TovarField
    {
        public int podnim, visota, mass;
        public Pogruzki()
        {
            count = 7;
        }
        public override string getInfo()
        {
            return vid + "    " + marka + "    " + postav + "    " + podnim + "    " + visota + "    " + mass;
        }
    }
}
