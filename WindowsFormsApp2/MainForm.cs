using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp2.TablesField;
using WindowsFormsApp2.TablesView;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\kursova\\Sklad2.mdb;";

        private TableView table; // Хранит в себе определенные действия для кажоый таблицы
        private OleDbConnection myConnection;

        public MainForm()
        {
            InitializeComponent(); // станд-ный метод для создания формы
            myConnection = new OleDbConnection(connectString); // создание подключения к БД
            myConnection.Open(); // открытие подключения к БД

            table = new TablePostavki();
            table.initialiaze(myConnection);
            FillTable(table.getFields());
            this.tableLayoutPanel2.Controls.Clear();
            table.CreateUI(tableLayoutPanel2);

            ActionOnFild(true);

        }

        // создание текстовых обьектов ифнормации из обьектов таблицы(БД) и добавление их в таблицу(UI на форме)
        private void FillTable(List<Field> list)
        {
            tableLayoutPanel1.Controls.Clear(); //очищаем таблицу(UI на форме)
            for (int i = 0; i < list.Count; i++)
            {
                //Создание текстового обьекта ифнормации
                MyLabel label = new MyLabel();
                label.Size = new Size(536, 23);
                label.TabIndex = 7;
                label.Id = list[i].id;
                label.Text = list[i].getInfo();
                label.Click += delegate { FillInfo(label); };
                tableLayoutPanel1.Controls.Add(label); // добавление обьекта в таблицу(UI на форме)
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F)); // добавление новой строки в таблицу(UI на форме)
            }
        }

        // Переключение на таблицу Поставки
        private void button1_Click(object sender, EventArgs e)
        {
            table = new TablePostavki();
            table.initialiaze(myConnection);
            FillTable(table.getFields());
            this.tableLayoutPanel2.Controls.Clear();
            table.CreateUI(tableLayoutPanel2);
        }

        // Переключение на таблицу 
        private void button2_Click(object sender, EventArgs e)
        {
            table = new TableAvtokran();
            table.initialiaze(myConnection);
            FillTable(table.getFields());
            this.tableLayoutPanel2.Controls.Clear();
            table.CreateUI(tableLayoutPanel2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            table.Insert();
            FillTable(table.getFields());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table = new TableBuldozer();
            table.initialiaze(myConnection);
            FillTable(table.getFields());
            this.tableLayoutPanel2.Controls.Clear();
            table.CreateUI(this.tableLayoutPanel2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table = new TableSkavator();
            table.initialiaze(myConnection);
            FillTable(table.getFields());
            this.tableLayoutPanel2.Controls.Clear();
            table.CreateUI(this.tableLayoutPanel2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            table = new TableGidrobur();
            table.initialiaze(myConnection);
            FillTable(table.getFields());
            this.tableLayoutPanel2.Controls.Clear();
            table.CreateUI(this.tableLayoutPanel2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            table = new TablePogruzki();
            table.initialiaze(myConnection);
            FillTable(table.getFields());
            this.tableLayoutPanel2.Controls.Clear();
            table.CreateUI(this.tableLayoutPanel2);
        }

        //Заполняет поля редактирования информации - информацией из определенного обьекта по id (номеру)
        private void FillInfo(MyLabel label)
        {
            table.Fill(label.Id);
            ActionOnFild(false); // переключаем активность кнопок
        }

        private void btmUpdate(object sender, EventArgs e)
        {
            table.Update();
            table.ClearTextBoxes();
            FillTable(table.getFields());
            ActionOnFild(true);
        }

        private void BtmDelete(object sender, EventArgs e)
        {
            table.Delete();
            FillTable(table.getFields());
            ActionOnFild(true);
        }

        private void btmCancle(object sender, EventArgs e)
        {
            ActionOnFild(true);
            table.ClearTextBoxes();
        }

        // переключаем активность кнопок
        private void ActionOnFild(bool action)
        {
            if (action)
            {
                buttonDelete.Enabled = false;
                buttonUpdate.Enabled = false;
                buttonInsert.Enabled = true;
            } else
            {

                buttonDelete.Enabled = true;
                buttonUpdate.Enabled = true;
                buttonInsert.Enabled = false;
            }
        }
        
    }
}
