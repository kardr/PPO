using System;
using System.Collections.Generic;
using System.Data.OleDb;
using WindowsFormsApp2.TablesField;
using System.Windows.Forms;

namespace WindowsFormsApp2.TablesView
{
     abstract class TableView
    {
        public int idField; 
        public OleDbConnection connection; 
        public List<TextBox> textBoxes = new List<TextBox>();
        
        public void initialiaze(OleDbConnection con)
        {
            connection = con;
        }

        public abstract List<Field> getFields();
        public abstract List<Field> getFieldsSearsh(string s);
        public abstract void Insert(); 
        public abstract void Update(); 
        public abstract void Delete(); 
        public abstract void Fill(int id);
        public abstract void CreateUI(TableLayoutPanel panel); 
        
        public void ClearTextBoxes()
        {
            foreach (TextBox t in textBoxes)
            {
                t.Clear();
            }
        }

    }
}
