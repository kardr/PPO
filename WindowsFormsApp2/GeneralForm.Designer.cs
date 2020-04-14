namespace WindowsFormsApp2
{
    partial class GeneralForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPostavki = new System.Windows.Forms.Button();
            this.buttonAvtokran = new System.Windows.Forms.Button();
            this.buttonBuldozer = new System.Windows.Forms.Button();
            this.buttonSkavator = new System.Windows.Forms.Button();
            this.buttonGidrobur = new System.Windows.Forms.Button();
            this.buttonPogruzki = new System.Windows.Forms.Button();
            this.Output_to_Form = new System.Windows.Forms.DataGridView();
            this.Search_line = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.input_Fields = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Output_to_Form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPostavki
            // 
            this.buttonPostavki.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonPostavki.Location = new System.Drawing.Point(354, 21);
            this.buttonPostavki.Name = "buttonPostavki";
            this.buttonPostavki.Size = new System.Drawing.Size(86, 36);
            this.buttonPostavki.TabIndex = 0;
            this.buttonPostavki.Text = "Поставщики";
            this.buttonPostavki.UseVisualStyleBackColor = false;
            this.buttonPostavki.Click += new System.EventHandler(this.buttonPostavki_Click);
            // 
            // buttonAvtokran
            // 
            this.buttonAvtokran.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAvtokran.Location = new System.Drawing.Point(139, 21);
            this.buttonAvtokran.Name = "buttonAvtokran";
            this.buttonAvtokran.Size = new System.Drawing.Size(85, 36);
            this.buttonAvtokran.TabIndex = 1;
            this.buttonAvtokran.Text = "Автокраны";
            this.buttonAvtokran.UseVisualStyleBackColor = false;
            this.buttonAvtokran.Click += new System.EventHandler(this.buttonAvtokran_Click_1);
            // 
            // buttonBuldozer
            // 
            this.buttonBuldozer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonBuldozer.Location = new System.Drawing.Point(244, 21);
            this.buttonBuldozer.Name = "buttonBuldozer";
            this.buttonBuldozer.Size = new System.Drawing.Size(88, 36);
            this.buttonBuldozer.TabIndex = 2;
            this.buttonBuldozer.Text = "Бульдозеры";
            this.buttonBuldozer.UseVisualStyleBackColor = false;
            this.buttonBuldozer.Click += new System.EventHandler(this.buttonBuldozer_Click);
            // 
            // buttonSkavator
            // 
            this.buttonSkavator.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSkavator.Location = new System.Drawing.Point(462, 21);
            this.buttonSkavator.Name = "buttonSkavator";
            this.buttonSkavator.Size = new System.Drawing.Size(86, 36);
            this.buttonSkavator.TabIndex = 3;
            this.buttonSkavator.Text = "Экскаваторы";
            this.buttonSkavator.UseVisualStyleBackColor = false;
            this.buttonSkavator.Click += new System.EventHandler(this.buttonSkavator_Click);
            // 
            // buttonGidrobur
            // 
            this.buttonGidrobur.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonGidrobur.Location = new System.Drawing.Point(567, 21);
            this.buttonGidrobur.Name = "buttonGidrobur";
            this.buttonGidrobur.Size = new System.Drawing.Size(85, 36);
            this.buttonGidrobur.TabIndex = 4;
            this.buttonGidrobur.Text = "Гидробуры";
            this.buttonGidrobur.UseVisualStyleBackColor = false;
            this.buttonGidrobur.Click += new System.EventHandler(this.buttonGidrobur_Click);
            // 
            // buttonPogruzki
            // 
            this.buttonPogruzki.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonPogruzki.Location = new System.Drawing.Point(672, 21);
            this.buttonPogruzki.Name = "buttonPogruzki";
            this.buttonPogruzki.Size = new System.Drawing.Size(84, 36);
            this.buttonPogruzki.TabIndex = 5;
            this.buttonPogruzki.Text = "Погрузчики";
            this.buttonPogruzki.UseVisualStyleBackColor = false;
            this.buttonPogruzki.Click += new System.EventHandler(this.buttonPogruzki_Click);
            // 
            // Output_to_Form
            // 
            this.Output_to_Form.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Output_to_Form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Output_to_Form.Location = new System.Drawing.Point(139, 63);
            this.Output_to_Form.Name = "Output_to_Form";
            this.Output_to_Form.Size = new System.Drawing.Size(617, 155);
            this.Output_to_Form.TabIndex = 0;
            // 
            // Search_line
            // 
            this.Search_line.Location = new System.Drawing.Point(295, 479);
            this.Search_line.Name = "Search_line";
            this.Search_line.Size = new System.Drawing.Size(284, 20);
            this.Search_line.TabIndex = 6;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonDelete.Location = new System.Drawing.Point(515, 345);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(113, 70);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonInsert.Location = new System.Drawing.Point(515, 255);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(113, 70);
            this.buttonInsert.TabIndex = 8;
            this.buttonInsert.Text = "Добавить";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonUpdate.Location = new System.Drawing.Point(643, 255);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(113, 70);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Cancle
            // 
            this.Cancle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Cancle.Location = new System.Drawing.Point(643, 345);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(113, 70);
            this.Cancle.TabIndex = 10;
            this.Cancle.Text = "Отмена";
            this.Cancle.UseVisualStyleBackColor = false;
            this.Cancle.Click += new System.EventHandler(this.Cancle_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Search.Location = new System.Drawing.Point(600, 479);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 11;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // input_Fields
            // 
            this.input_Fields.ColumnCount = 2;
            this.input_Fields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.input_Fields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.input_Fields.Location = new System.Drawing.Point(156, 249);
            this.input_Fields.Name = "input_Fields";
            this.input_Fields.RowCount = 7;
            this.input_Fields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.input_Fields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.input_Fields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.input_Fields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.input_Fields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.input_Fields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.input_Fields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.input_Fields.Size = new System.Drawing.Size(314, 197);
            this.input_Fields.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Поиск по поставщикам";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources._340_3403667_gconstruct_by_gstudio_works_construction_equipment_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(780, 428);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.betonomeshalka;
            this.pictureBox2.Location = new System.Drawing.Point(776, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources._340_3403667_gconstruct_by_gstudio_works_construction_equipment_icon;
            this.pictureBox3.Location = new System.Drawing.Point(12, 175);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp2.Properties.Resources.img_537713;
            this.pictureBox4.Location = new System.Drawing.Point(16, 436);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp2.Properties.Resources.img_262258;
            this.pictureBox5.Location = new System.Drawing.Point(783, 43);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(101, 79);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp2.Properties.Resources.img_458593;
            this.pictureBox6.Location = new System.Drawing.Point(16, 304);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(98, 83);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp2.Properties.Resources.img_453811;
            this.pictureBox7.Location = new System.Drawing.Point(783, 305);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(103, 83);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WindowsFormsApp2.Properties.Resources._46818;
            this.pictureBox8.Location = new System.Drawing.Point(5, 42);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(109, 79);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(903, 530);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_Fields);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.Search_line);
            this.Controls.Add(this.Output_to_Form);
            this.Controls.Add(this.buttonPogruzki);
            this.Controls.Add(this.buttonGidrobur);
            this.Controls.Add(this.buttonSkavator);
            this.Controls.Add(this.buttonBuldozer);
            this.Controls.Add(this.buttonAvtokran);
            this.Controls.Add(this.buttonPostavki);
            this.Name = "GeneralForm";
            this.Text = "Склад строительной техники";
            ((System.ComponentModel.ISupportInitialize)(this.Output_to_Form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonPostavki;
        private System.Windows.Forms.Button buttonAvtokran;
        private System.Windows.Forms.Button buttonBuldozer;
        private System.Windows.Forms.Button buttonSkavator;
        private System.Windows.Forms.Button buttonGidrobur;
        private System.Windows.Forms.Button buttonPogruzki;

        #endregion
        private System.Windows.Forms.DataGridView Output_to_Form;
        private System.Windows.Forms.TextBox Search_line;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TableLayoutPanel input_Fields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}