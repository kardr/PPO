using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.TablesField;

namespace WindowsFormsApp2.TablesView
{
    class TableSkavator : TableView
    {
        string[] fieldName = { "Вид", "Марка", "Поставщик", "Вес", "Объем лопаты", "Объем ковша", "Габариты" };
      
        public override void CreateUI(TableLayoutPanel panel)
        {
            for (int i = 0; i < fieldName.Length; i++)
            {
                string s = fieldName[i];
                TextBox t = Elements.gettextBox(s);
                Label l = Elements.getLabel(s);

                panel.Controls.Add(t, 1, i);
                panel.Controls.Add(l, 0, i);
                textBoxes.Add(t);
            }
        }

        public override void Delete()
        {
            ClearTextBoxes();
            string query = "DELETE FROM Экскаваторы WHERE Номер = " + idField;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public override void Fill(int id)
        {
            string query = "SELECT * FROM Экскаваторы WHERE Номер = " + id;
            idField = id;
            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            
            for (int i = 0; i < textBoxes.Count; i++)
            {
                textBoxes[i].Text = reader[i + 1].ToString();
            }

            reader.Close();
        }

        public override List<Field> getFields()
        {
            string query = "SELECT Номер, Вид, Марка, Поставщик, Вес, Объём_лопаты, Объём_ковша, Габариты FROM Экскаваторы";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            List<Field> list = new List<Field>();
            while (reader.Read())
            {
                Skavator skavator = new Skavator();
                skavator.id         = int.Parse(reader[0].ToString());
                skavator.vid        = reader[1].ToString();
                skavator.marka      = reader[2].ToString();
                skavator.postav     = reader[3].ToString();
                skavator.ves        = reader[4].ToString();
                skavator.lopata     = reader[5].ToString();
                skavator.kovh       = reader[6].ToString();
                skavator.gabarit    = reader[7].ToString();
                list.Add(skavator);

            }
            reader.Close();
            return list;
        }

        public override void Insert()
        {
            string q = "INSERT INTO Экскаваторы (Вид, Марка, Поставщик, Вес, Объём_лопаты, Объём_ковша, Габариты) " +
                "VALUES ( '" + textBoxes[0].Text + "'," +
                " '" + textBoxes[1].Text + "'," +
                " '" + textBoxes[2].Text + "'," +
                " " + (textBoxes[3].Text) + "," +
                " " + (textBoxes[4].Text) + "," +
                " " + (textBoxes[5].Text) + "," +
                " " + (textBoxes[6].Text) + ")";
            OleDbCommand command = new OleDbCommand(q, connection);
            command.ExecuteNonQuery();
        }

        public override void Update()
        {
            string query = "UPDATE Экскаваторы SET " +
                "Вид = '" + textBoxes[0].Text + "'," +
                " Марка = '" + textBoxes[1].Text + "'," +
                " Поставщик = '" + textBoxes[2].Text + "'," +
                " Вес = " + textBoxes[3].Text + "," +
                " Объём_лопаты = " + textBoxes[4].Text + "," +
                " Объём_ковша = " + textBoxes[5].Text + "," +
                " Габариты = " + textBoxes[6].Text +
                " WHERE Номер = " + idField;
            OleDbCommand command = new OleDbCommand(query, connection);

            command.ExecuteNonQuery();
        }

        public override List<Field> getFieldsSearsh(string s)
        {
            string query = "SELECT Номер, Вид, Марка, Поставщик, Вес, Объём_лопаты, Объём_ковша, Габариты FROM Экскаваторы where Поставщик =  '" + s + "'";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            List<Field> list = new List<Field>();
            while (reader.Read())
            {
                Skavator skavator   = new Skavator();
                skavator.id         = int.Parse(reader[0].ToString());
                skavator.vid        = reader[1].ToString();
                skavator.marka      = reader[2].ToString();
                skavator.postav     = reader[3].ToString();
                skavator.ves        = reader[4].ToString();
                skavator.lopata     = reader[5].ToString();
                skavator.kovh       = reader[6].ToString();
                skavator.gabarit    = reader[7].ToString();
                list.Add(skavator);
            }
            reader.Close();

            return list;
        }
    }
}
