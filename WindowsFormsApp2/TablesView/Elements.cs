
using System.Windows.Forms;

namespace WindowsFormsApp2.TablesView
{
    class Elements
    {
        public static Label getLabel(string name)
        {
            
            Label label1 = new Label(); 
            
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(614, 438);
            label1.Name = name;
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 8;
            label1.Text = name;
            return label1;
            
        }
        
        public  static TextBox gettextBox(string name)
        {
            TextBox textBox = new TextBox();

            textBox.Location = new System.Drawing.Point(751, 435);
            textBox.Name = name;
            textBox.Size = new System.Drawing.Size(170, 20);
            textBox.TabIndex = 7;

            return textBox;
        }
    }
}
