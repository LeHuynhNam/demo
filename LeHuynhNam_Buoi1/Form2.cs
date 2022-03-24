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
    public partial class Form2 : Form
    {
        Panel pn = new Panel();
        

        public Form2()
        {
            InitializeComponent();
             int dong = 10;
            //

        int cot =10;
        int topPosition = 10;
     
        for(int i=0; i< dong; i++)
        {
            int LeftPosition = 10;
            for( int j=0; j<cot;j++)
            {
                 Button b = new Button();
          
            b.Size=new Size(30, 30);
            b.Left = 20;   
            b.Left=LeftPosition;
            LeftPosition +=30;
            b.Top = topPosition;
            this.Controls.Add(b);
            b.Click += new System.EventHandler(bt_click);
            }
            topPosition += 30;
        }


        }

private void bt_click(object sender, EventArgs e)
{
 	
}
       
    

    }
    }

