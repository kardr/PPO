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
    class TableGidrobur : TableView
    {
        string[] fieldName = { "Вид", "Марка", "Поставщик", "Вес вращателя", "Давление в гидросистеме", "Длина шнека" };
       
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
            string query = "DELETE FROM Гидробуры WHERE Номер = " + idField;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public override void Fill(int id)
        {
            string query = "SELECT * FROM Гидробуры WHERE Номер = " + id;
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
            string query = "SELECT Номер, Вид, Марка, Поставщик, Вес_вращателя, Давление_в_гидросистеме, Длина_шнека FROM Гидробуры";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            List<Field> list = new List<Field>();
            while (reader.Read())
            {
                Gidrobur gidrobur = new Gidrobur();
                gidrobur.id         = int.Parse(reader[0].ToString());
                gidrobur.vid        = reader[1].ToString();
                gidrobur.marka      = reader[2].ToString();
                gidrobur.postav     = reader[3].ToString();
                gidrobur.ves        = int.Parse(reader[4].ToString());
                gidrobur.davlenie   = int.Parse(reader[5].ToString());
                gidrobur.dlina      = int.Parse(reader[6].ToString());
                list.Add(gidrobur);

            }
            reader.Close();
            return list;
        }

        public override void Insert()
        {
            string q = "INSERT INTO Гидробуры (Вид, Марка, Поставщик, Вес_вращателя, Давление_в_гидросистеме, Длина_шнека) " +
                "VALUES ( '" + textBoxes[0].Text + "'," +
                " '" + textBoxes[1].Text + "'," +
                " '" + textBoxes[2].Text + "'," +
                " " + int.Parse(textBoxes[3].Text) + "," +
                " " + int.Parse(textBoxes[4].Text) + "," +
                " " + int.Parse(textBoxes[5].Text) + ")";
            OleDbCommand command = new OleDbCommand(q, connection);
            command.ExecuteNonQuery();
        }

        public override void Update()
        {
            string query = "UPDATE Гидробуры SET " +
               "Вид = '" + textBoxes[0].Text + "'," +
               " Марка = '" + textBoxes[1].Text + "'," +
               " Поставщик = '" + textBoxes[2].Text + "'," +
               " Вес_вращателя = " + int.Parse(textBoxes[3].Text) + "," +
               " Давление_в_гидросистеме = " + int.Parse(textBoxes[4].Text) + "," +
               " Длина_шнека = " + int.Parse(textBoxes[5].Text) +
               " WHERE Номер = " + idField;
            OleDbCommand command = new OleDbCommand(query, connection);

            command.ExecuteNonQuery();
        }

        public override List<Field> getFieldsSearsh(string s)
        {
            string query = "SELECT Номер, Вид, Марка, Поставщик, Вес_вращателя, Давление_в_гидросистеме, Длина_шнека FROM Гидробуры where Поставщик =  '" + s + "'";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            List<Field> list = new List<Field>();
            while (reader.Read())
            {
                Gidrobur gidrobur = new Gidrobur();
                gidrobur.id         = int.Parse(reader[0].ToString());
                gidrobur.vid        = reader[1].ToString();
                gidrobur.marka      = reader[2].ToString();
                gidrobur.postav     = reader[3].ToString();
                gidrobur.ves        = int.Parse(reader[4].ToString());
                gidrobur.davlenie   = int.Parse(reader[5].ToString());
                gidrobur.dlina      = int.Parse(reader[6].ToString());
                list.Add(gidrobur);
            }
            reader.Close();

            return list;
        }
    }

}
