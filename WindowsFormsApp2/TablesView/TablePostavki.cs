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
    class TablePostavki : TableView
    {
        string[] fieldName = { "Поставщик", "Юридический адрес", "Телефон" };

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
            string query = "DELETE FROM Поставщики WHERE Номер = " + idField;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public override void Fill(int id)
        {
            string query = "SELECT * FROM Поставщики WHERE Номер = " + id;
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
            string query = "SELECT Номер, Поставщик, Юридический_адрес, Телефон FROM Поставщики";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            List<Field> list = new List<Field>();
            while (reader.Read())
            {
                Postavki postavki   = new Postavki();
                postavki.id         = int.Parse(reader[0].ToString());
                postavki.postav     = reader[1].ToString();
                postavki.telefon    = reader[3].ToString();
                postavki.adress     = reader[2].ToString();
                list.Add(postavki);


            }
            reader.Close();
            return list;
        }

        public override void Insert()
        {
            string q = "INSERT INTO Поставщики (Поставщик, Юридический_адрес, Телефон ) " +
                "VALUES ( '" + textBoxes[0].Text + "'," +
                " '" + textBoxes[1].Text + "'," +
                " " + int.Parse(textBoxes[2].Text) + ")";
            OleDbCommand command = new OleDbCommand(q, connection);
            command.ExecuteNonQuery();
        }

        public override void Update()
        {
            string query = "UPDATE Поставщики SET " +
                "Поставщик = '" + textBoxes[0].Text + "'," +
                " Юридический_адрес = '" + textBoxes[1].Text + "'," +
                " Телефон = " + int.Parse(textBoxes[2].Text) +
                " WHERE Номер = " + idField;
            OleDbCommand command = new OleDbCommand(query, connection);

            command.ExecuteNonQuery();
        }

        public override List<Field> getFieldsSearsh( string s)
        {
            string query = "SELECT Номер, Поставщик, Юридический_адрес, Телефон FROM Поставщики where Поставщик =  '" + s+"'";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            List<Field> list = new List<Field>();
            while (reader.Read())
            {
                Postavki postavki   = new Postavki();
                postavki.id         = int.Parse(reader[0].ToString());
                postavki.postav     = reader[1].ToString();
                postavki.telefon    = reader[3].ToString();
                postavki.adress     = reader[2].ToString();
                list.Add(postavki);


            }
            reader.Close();

            return list;
        }
    }
}
