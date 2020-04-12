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
    class TablePogruzki : TableView
    {
        string[] fieldName = { "Вид", "Марка", "Поставщик", "Поднимаемый груз", "Высота подъема груза", "Масса" };
        
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
            string query = "DELETE FROM Погрузчики WHERE Номер = " + idField;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public override void Fill(int id)
        {
            string query = "SELECT * FROM Погрузчики WHERE Номер = " + id;
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
            string query = "SELECT Номер, Вид, Марка, Поставщик, Поднимаемый_груз, Высота_подъема_груза, Масса FROM Погрузчики";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            List<Field> list = new List<Field>();
            while (reader.Read())
            {
                Pogruzki pogruzki   = new Pogruzki();
                pogruzki.id         = int.Parse(reader[0].ToString());
                pogruzki.vid        = reader[1].ToString();
                pogruzki.marka      = reader[2].ToString();
                pogruzki.postav     = reader[3].ToString();
                pogruzki.podnim     = int.Parse(reader[4].ToString());
                pogruzki.visota     = int.Parse(reader[5].ToString());
                pogruzki.mass       = int.Parse(reader[6].ToString());
                list.Add(pogruzki);

            }
            reader.Close();
            return list;
        }

        public override void Insert()
        {
            string q = "INSERT INTO Погрузчики (Вид, Марка, Поставщик, Поднимаемый_груз, Высота_подъема_груза, Масса) " +
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
            string query = "UPDATE Погрузчики SET " +
                "Вид = '" + textBoxes[0].Text + "'," +
                " Марка = '" + textBoxes[1].Text + "'," +
                " Поставщик = '" + textBoxes[2].Text + "'," +
                " Поднимаемый_груз = " + int.Parse(textBoxes[3].Text) + "," +
                " Высота_подъема_груза = " + int.Parse(textBoxes[4].Text) + "," +
                " Масса = " + int.Parse(textBoxes[5].Text) +
                " WHERE Номер = " + idField;
            OleDbCommand command = new OleDbCommand(query, connection);

            command.ExecuteNonQuery();
        }

        public override List<Field> getFieldsSearsh(string s)
        {
            string query = "SELECT Номер, Вид, Марка, Поставщик, Поднимаемый_груз, Высота_подъема_груза, Масса FROM Погрузчики where Поставщик =  '" + s + "'";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            List<Field> list = new List<Field>();
            while (reader.Read())
            {
                Pogruzki pogruzki   = new Pogruzki();
                pogruzki.id         = int.Parse(reader[0].ToString());
                pogruzki.vid        = reader[1].ToString();
                pogruzki.marka      = reader[2].ToString();
                pogruzki.postav     = reader[3].ToString();
                pogruzki.podnim     = int.Parse(reader[4].ToString());
                pogruzki.visota     = int.Parse(reader[5].ToString());
                pogruzki.mass       = int.Parse(reader[6].ToString());
                list.Add(pogruzki);
            }
            reader.Close();

            return list;
        }
    }

}
