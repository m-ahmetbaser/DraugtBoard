using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraughtBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //.GetUpperBound  :  dizideki en yüksek index sayısını return eder 

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] myButtons = new Button[8,8];
            int top=0;
            int left=0;

            for (int i = 0; i < myButtons.GetUpperBound(0)+1; i++)
            {
                for (int j = 0; j < myButtons.GetUpperBound(1) + 1; j++)
                {
                    myButtons[i, j] = new Button();
                    this.Controls.Add(myButtons[i, j]);
                    myButtons[i, j].Width = 50;
                    myButtons[i, j].Height = 50;
                    myButtons[i, j].Left = left;
                    myButtons[i, j].Top = top;
                    left = left + 50;
                    if ((i+j)%2==1)
                    {
                        myButtons[i, j].BackColor = Color.White;
                    }
                    else
                    {
                        myButtons[i, j].BackColor = Color.Black;
                    }
                }
                left = 0;
                top = top + 50;
                
            }
            
            
        }
    }
}
