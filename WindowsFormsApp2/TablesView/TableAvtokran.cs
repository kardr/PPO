
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
using WindowsFormsApp2.TablesField;

namespace WindowsFormsApp2.TablesView
{
    class TableAvtokran : TableView
    {
       
        string[] fieldName = { "Вид", "Марка", "Поставщик", "Гп мах.", "Мах_грузовой_момент", "Масса транс. полож." };

        public override void CreateUI(TableLayoutPanel panel)
        {
            for(int i = 0; i < fieldName.Length; i++)
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
            string query = "DELETE FROM Автокраны WHERE Номер = " + idField;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public override void Fill(int id)
        {
            string query = "SELECT * FROM Автокраны WHERE Номер = " + id;
            idField = id;
            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            
            for (int i = 0; i < textBoxes.Count; i++)
            {
                textBoxes[i].Text = reader[i+1].ToString();
            }
            
            reader.Close();
        }

        public override List<Field> getFields()
        {
            string query = "SELECT Номер, Вид, Марка, Поставщик, Гп_мах, Мах_грузовой_момент, Масса_в_транспортном_положении FROM Автокраны";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            List<Field> list = new List<Field>(); 
            while (reader.Read())
            {
                Avtokran avtokran   = new Avtokran();
                avtokran.id         = int.Parse(reader[0].ToString());
                avtokran.vid        = reader[1].ToString();
                avtokran.marka      = reader[2].ToString();
                avtokran.postav     =reader[3].ToString();
                avtokran.gp         =int.Parse(reader[4].ToString());
                avtokran.moment     =int.Parse(reader[5].ToString());
                avtokran.mas        =int.Parse(reader[6].ToString());
                list.Add(avtokran); 

            }
            reader.Close();
            return list;
        }

        public override void Insert()
        {
            string query = "INSERT INTO Автокраны (Вид, Марка, Поставщик, Гп_мах, Мах_грузовой_момент, Масса_в_транспортном_положении) " +
                "VALUES ( '" + textBoxes[0].Text        + "'," +
                " '"    + textBoxes[1].Text             + "'," +
                " '"    + textBoxes[2].Text             + "'," +
                " "     + int.Parse(textBoxes[3].Text)  + "," +
                " "     + int.Parse(textBoxes[4].Text)  + "," +
                " "     + int.Parse(textBoxes[5].Text)  + ")";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public override void Update()
        {
            string query = "UPDATE Автокраны SET " +
                "Вид = '"  + textBoxes[0].Text + "'," +
                " Марка = '" + textBoxes[1].Text + "'," +
                " Поставщик = '" + textBoxes[2].Text + "'," +
                " Гп_мах = " + int.Parse(textBoxes[3].Text) + "," +
                " Мах_грузовой_момент = " + int.Parse(textBoxes[4].Text) + "," +
                " Масса_в_транспортном_положении = " + int.Parse(textBoxes[5].Text) +
                " WHERE Номер = " + idField;
            OleDbCommand command = new OleDbCommand(query, connection);

            command.ExecuteNonQuery();
        }

        public override List<Field> getFieldsSearsh(string s)
        {
            string query = "SELECT Номер, Вид, Марка, Поставщик, " +
                "Гп_мах, Мах_грузовой_момент, Масса_в_транспортном_положении " +
                "FROM Автокраны where Поставщик =  '" + s + "'";

            OleDbCommand command = new OleDbCommand(query, connection);

            OleDbDataReader reader = command.ExecuteReader();

            List<Field> list = new List<Field>();
            while (reader.Read())
            {
                Avtokran avtokran   = new Avtokran ();
                avtokran.id = int.Parse(reader[0].ToString());
                avtokran.vid = reader[1].ToString();
                avtokran.marka = reader[2].ToString();
                avtokran.postav = reader[3].ToString();
                avtokran.gp = int.Parse(reader[4].ToString());
                avtokran.moment = int.Parse(reader[5].ToString());
                avtokran.mas = int.Parse(reader[6].ToString());
                list.Add(avtokran);

            }
            reader.Close();

            return list;
        }
    }
}

