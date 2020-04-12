using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.TablesField
{
    abstract class Field
    {
        public string postav;
        public int id;
        public abstract string getInfo();
        public int count;
    }
}
