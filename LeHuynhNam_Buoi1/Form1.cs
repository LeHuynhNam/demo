using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeHuynhNam_Buoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         


            //check box
            //            string[] foods ={"Grain", "Bread", "Beans", "Eggs", "Chicken", "Milk",
            //"Fruit", "Vegetables", "Pasta", "Rice", "Fish", "Beef" };
            //            int topPosition = 10;
            //            foreach (string food in foods)
            //            {
            //                CheckBox cb = new CheckBox();
            //                cb.Left = 30;
            //                cb.Top = topPosition;
            //                topPosition += 30;
            //                cb.Text = food;
            //                Controls.Add(cb);

            //            }

            //text box
            string[] textBox = { "textBox1", "textBox2", "textBox3", "textBox4" };
            int topPosition = 50;
            foreach (string textB in textBox)
            {
                TextBox tb = new TextBox();
                tb.Left = 20;
                tb.Top = topPosition;
                tb.Size = new Size(170, 100);
                               topPosition += 50;
                              tb.Text = textB;
                              Controls.Add(tb);
            

                Controls.Add(tb);
            }
            //buton
            Button b = new Button();
            b.Text = "Process Text Boxes";
            b.Size=new Size(150, 20);
            b.Left = 20;
            b.Top = 240;
            this.Controls.Add(b);
            b.Click += new System.EventHandler(bt_click);
        }
        private void bt_click(object sender, EventArgs e)
        {
            //ham clear 
            foreach (Control item in Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = string.Empty;
                }
            }
        }
    }
}
