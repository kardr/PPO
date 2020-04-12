using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.TablesField;
using WindowsFormsApp2.TablesView;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\kursova\\Sklad2.mdb;";

        public Form1()
        {
            OleDbConnection myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            InitializeComponent();
            TablePostavki p = new TablePostavki();
            p.initialiaze(myConnection);
            List<Field> list = p.getFields();

            for (int i = 0; i < list.Count; i++)
            {
                Label label = new Label();
                label.Size = new Size(536, 23);
                label.TabIndex = 7;
                label.Text = list[i].getInfo();
                this.tableLayoutPanel1.Controls.Add(label);
                this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
                
            }

            Console.WriteLine(tableLayoutPanel1.RowCount);
            Console.WriteLine(list.Count);

        }
    }
}
