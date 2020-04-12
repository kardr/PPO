using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp2.TablesField;
using WindowsFormsApp2.TablesView;

namespace WindowsFormsApp2
{
    public partial class GeneralForm : Form
    {

        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\kursova\\Sklad2.mdb;"; 

        private TableView table;
        private OleDbConnection myConnection;
        private DataGridView GW;

        public GeneralForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            table = new TablePostavki();
            GW = new DataGridView();
            table.initialiaze(myConnection);
            FillTable(table.getFields());
            this.tableLayoutPanel2.Controls.Clear();
            table.CreateUI(tableLayoutPanel2);

            ActionOnFild(true);
            dataGridView1.Visible = false;

        }
        private void FillTable(List<Field> list)
        {

            dataGridView1.Rows.Clear();
            if (list.Count == 0)
            {
                dataGridView1.RowCount = 1;
                GW.RowCount = 1;
            }
            else
            {
                dataGridView1.RowCount = list.Count;
                GW.RowCount = list.Count;
            }

            dataGridView1.ColumnCount = list[0].count;

            GW.ColumnCount = list[0].count;
            GW.Size = dataGridView1.Size;
            GW.Location = dataGridView1.Location;
            GW.RowHeadersVisible = false;
            GW.BackgroundColor = dataGridView1.BackgroundColor;

            if (list[0] is Postavki)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Postavki a = list[i] as Postavki;
                    GW.CellClick += delegate { FillInfo(a.id); };
                    GW[0, i].Value = a.id;
                    GW[1, i].Value = a.postav;
                    GW[2, i].Value = a.adress;
                    GW[3, i].Value = a.telefon;
                }

                GW.Columns[1].HeaderText = "Поставщик";
                GW.Columns[2].HeaderText = "Юридический адрес";
                GW.Columns[3].HeaderText = "Телефон";
                GW.Columns[0].Visible = false;

            }
            else if (list[0] is Avtokran)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Avtokran a = list[i] as Avtokran;
                    GW.CellClick += delegate { FillInfo(a.id); };
                    GW[0, i].Value = a.id;
                    GW[1, i].Value = a.vid;
                    GW[2, i].Value = a.marka;
                    GW[3, i].Value = a.postav;
                    GW[4, i].Value = a.gp;
                    GW[5, i].Value = a.moment;
                    GW[6, i].Value = a.mas;

                }

                GW.Columns[1].HeaderText = "Вид";
                GW.Columns[2].HeaderText = "Марка";
                GW.Columns[3].HeaderText = "Поставщик";
                GW.Columns[4].HeaderText = "Г/п, мах";
                GW.Columns[5].HeaderText = "Мах грузовой момент";
                GW.Columns[6].HeaderText = "Масса в транспортном положении";
                GW.Columns[0].Visible = false;
            }

            else if (list[0] is Buldozer)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Buldozer a = list[i] as Buldozer;
                    GW.CellClick += delegate { FillInfo(a.id); };
                    GW[0, i].Value = a.id;
                    GW[1, i].Value = a.vid;
                    GW[2, i].Value = a.marka;
                    GW[3, i].Value = a.postav;
                    GW[4, i].Value = a.massa;
                    GW[5, i].Value = a.dlina;
                    GW[6, i].Value = a.visot;

                }

                GW.Columns[1].HeaderText = "Вид";
                GW.Columns[2].HeaderText = "Марка";
                GW.Columns[3].HeaderText = "Поставщик";
                GW.Columns[4].HeaderText = "Масса";
                GW.Columns[5].HeaderText = "Габаритная длина";
                GW.Columns[6].HeaderText = "Высота овала";
                GW.Columns[0].Visible = false;
            }

            else if (list[0] is Gidrobur)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Gidrobur a = list[i] as Gidrobur;
                    GW.CellClick += delegate { FillInfo(a.id); };
                    GW[0, i].Value = a.id;
                    GW[1, i].Value = a.vid;
                    GW[2, i].Value = a.marka;
                    GW[3, i].Value = a.postav;
                    GW[4, i].Value = a.ves;
                    GW[5, i].Value = a.davlenie;
                    GW[6, i].Value = a.dlina;

                }

                GW.Columns[1].HeaderText = "Вид";
                GW.Columns[2].HeaderText = "Марка";
                GW.Columns[3].HeaderText = "Поставщик";
                GW.Columns[4].HeaderText = "Вес вращателя";
                GW.Columns[5].HeaderText = "Давление в гидросистеме";
                GW.Columns[6].HeaderText = "Длина шнека";
                GW.Columns[0].Visible = false;
            }

            else if (list[0] is Pogruzki)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Pogruzki a = list[i] as Pogruzki;
                    GW.CellClick += delegate { FillInfo(a.id); };
                    GW[0, i].Value = a.id;
                    GW[1, i].Value = a.vid;
                    GW[2, i].Value = a.marka;
                    GW[3, i].Value = a.postav;
                    GW[4, i].Value = a.podnim;
                    GW[5, i].Value = a.visota;
                    GW[6, i].Value = a.mass;

                }

                GW.Columns[1].HeaderText = "Вид";
                GW.Columns[2].HeaderText = "Марка";
                GW.Columns[3].HeaderText = "Поставщик";
                GW.Columns[4].HeaderText = "Поднимаемый груз";
                GW.Columns[5].HeaderText = "Высота подъема груза";
                GW.Columns[6].HeaderText = "Масса";
                GW.Columns[0].Visible = false;
            }

            else if (list[0] is Skavator)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Skavator a = list[i] as Skavator;
                    GW.CellClick += delegate { FillInfo(a.id); };
                    GW[0, i].Value = a.id;
                    GW[1, i].Value = a.vid;
                    GW[2, i].Value = a.marka;
                    GW[3, i].Value = a.postav;
                    GW[4, i].Value = a.ves;
                    GW[5, i].Value = a.lopata;
                    GW[6, i].Value = a.kovh;
                    GW[7, i].Value = a.gabarit;
                }

                GW.Columns[1].HeaderText = "Вид";
                GW.Columns[2].HeaderText = "Марка";
                GW.Columns[3].HeaderText = "Поставщик";
                GW.Columns[4].HeaderText = "Вес";
                GW.Columns[5].HeaderText = "Объем лопаты";
                GW.Columns[6].HeaderText = "Объем ковша";
                GW.Columns[7].HeaderText = "Габариты";
                GW.Columns[0].Visible = false;
            }

            this.Controls.Add(GW);
        }
        
        private void ActionOnFild(bool action)
        {
            if (action)
            {
                buttonDelete.Enabled = false;
                buttonUpdate.Enabled = false;
                buttonInsert.Enabled = true;
            }
            else
            {

                buttonDelete.Enabled = true;
                buttonUpdate.Enabled = true;
                buttonInsert.Enabled = false;
            }
        }
        
        private void button11_Click_1(object sender, EventArgs e)
        {
            FillTable(table.getFieldsSearsh(textBox1.Text.Trim())); 
        }
        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            table.Delete();
            FillTable(table.getFields());
            ActionOnFild(true);
        }

        private void Cancle_Click(object sender, EventArgs e)
        {
            ActionOnFild(true);
            table.ClearTextBoxes();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            table.Update();
            table.ClearTextBoxes();
            FillTable(table.getFields());
            ActionOnFild(true);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            table.Insert();
            FillTable(table.getFields());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table = new TablePostavki();
            table.initialiaze(myConnection);
            FillTable(table.getFields());
            this.tableLayoutPanel2.Controls.Clear();
            table.CreateUI(tableLayoutPanel2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table = new TableAvtokran();
            table.initialiaze(myConnection);
            FillTable(table.getFields());
            this.tableLayoutPanel2.Controls.Clear();
            table.CreateUI(tableLayoutPanel2);
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
        private void FillInfo(int my_id)
        {
            int k = GW.CurrentRow.Index;
            table.Fill(Convert.ToInt32(GW[0, k].Value));
            ActionOnFild(false);
        }
        
    }
}

        
    

