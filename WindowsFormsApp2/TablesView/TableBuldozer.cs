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
    class TableBuldozer : TableView
    {
        string[] fieldName = { "Вид", "Марка", "Поставщик", "Масса", "Габаритная длина", "Высота овала" };

        public override void CreateUI(TableLayoutPanel panel)
        {
            for (int i = 0; i < fieldName.Length; i++)
            {
                string s    = fieldName[i];
                TextBox t   = Elements.gettextBox(s);
                Label l     = Elements.getLabel(s);

                panel.Controls.Add(t, 1, i);
                panel.Controls.Add(l, 0, i);
                textBoxes.Add(t);
            }
        }

        public override void Delete()
        {
            ClearTextBoxes();
            string query = "DELETE FROM Бульдозеры WHERE Номер = " + idField;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public override void Fill(int id)
        {
            string query = "SELECT * FROM Бульдозеры WHERE Номер = " + id;
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
            string query = "SELECT Номер, Вид, Марка, Поставщик, Масса, Габаритная_длина, Высота_овала FROM Бульдозеры";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            List<Field> list = new List<Field>();
            while (reader.Read())
            {
                Buldozer buldozer   = new Buldozer();
                buldozer.id         = int.Parse(reader[0].ToString());
                buldozer.vid        = reader[1].ToString();
                buldozer.marka      = reader[2].ToString();
                buldozer.postav     = reader[3].ToString();
                buldozer.massa      = int.Parse(reader[4].ToString());
                buldozer.dlina      = int.Parse(reader[5].ToString());
                buldozer.visot      = int.Parse(reader[6].ToString());
                list.Add(buldozer);

            }
            reader.Close();
            return list;
        }

        public override void Insert()
        {
            string q = "INSERT INTO Бульдозеры (Вид, Марка, Поставщик, Масса, Габаритная_длина, Высота_овала) " +
                "VALUES ( '" + textBoxes[0].Text        + "'," +
                " '"    + textBoxes[1].Text             + "'," +
                " '"    + textBoxes[2].Text             + "'," +
                " "     + int.Parse(textBoxes[3].Text)  + "," +
                " "     + int.Parse(textBoxes[4].Text)  + "," +
                " "     + int.Parse(textBoxes[5].Text)  + ")";
            OleDbCommand command = new OleDbCommand(q, connection);
            command.ExecuteNonQuery();
        }

        public override void Update()
        {
            string query = "UPDATE Бульдозеры SET " +
                "Вид = '" + textBoxes[0].Text + "'," +
                " Марка = '" + textBoxes[1].Text + "'," +
                " Поставщик = '" + textBoxes[2].Text + "'," +
                " Масса = " + int.Parse(textBoxes[3].Text) + "," +
                " Габаритная_длина = " + int.Parse(textBoxes[4].Text) + "," +
                " Высота_овала = " + int.Parse(textBoxes[5].Text) +
                " WHERE Номер = " + idField;
            OleDbCommand command = new OleDbCommand(query, connection);

            command.ExecuteNonQuery();
        }

        public override List<Field> getFieldsSearsh(string s)
        {
            string query = "SELECT Номер, Вид, Марка, Поставщик, Масса, Габаритная_длина, Высота_овала FROM Бульдозеры where Поставщик =  '" + s + "'";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            List<Field> list = new List<Field>();
            while (reader.Read())
            {
                Buldozer buldozer   = new Buldozer();
                buldozer.id         = int.Parse(reader[0].ToString());
                buldozer.vid        = reader[1].ToString();
                buldozer.marka      = reader[2].ToString();
                buldozer.postav     = reader[3].ToString();
                buldozer.massa      = int.Parse(reader[4].ToString());
                buldozer.dlina      = int.Parse(reader[5].ToString());
                buldozer.visot      = int.Parse(reader[6].ToString());
                list.Add(buldozer);

            }
            reader.Close();

            return list;
        }
    }
}
