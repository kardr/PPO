using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    /// <summary>
    /// Обычный элемент пользовательского интерфейса (текста) 
    /// </summary>
    class MyLabel : Label
    {
        //ид(номер) определенной строки
        public int Id { set; get; }
    }
}
