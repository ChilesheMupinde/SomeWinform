using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grid2
{
    public partial class GridForm : Form
    {
        public GridForm()
        {
            InitializeComponent();
        }


        //declarations
        public int GuessCount;
        public int guess;
        string text1;

        public bool treasure ;
        public bool GameOver;
        public bool easy = Form2.easy;
        int[] av = new int[70];
        
        Button[] seper = new Button[60];
 
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();           
            int treasurenum = rand.Next(1, 70);
            text1 = Guessbox.Text;
            
            

            //Grid
            for (int b= 1;b<=70;b++)
            {
                Button but = new Button();
                

                if (text1 != "")
                {
                    guess = int.Parse(text1);
                }


                but.Location = new System.Drawing.Point(3, 3);
                but.Name = "btn" + b.ToString();
                but.Size = new System.Drawing.Size(57, 32);
                but.TabIndex = 0;
                but.UseVisualStyleBackColor = true;
                if (treasurenum == b && treasure && guess == treasurenum)
                {
                    but.Tag = true;
                    but.BackColor = Color.Green;
                }


                else if(treasurenum != b && treasure && guess != treasurenum){
                    but.Tag = false;
                    but.BackColor = Color.Red;
                }
                label2.Text = treasure.ToString();

                but.Click += But_Click;

                flowLayoutPanel1.Controls.Add(but);
            }
            
            
           
            
        }

        private void But_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            bool tag = (bool)but.Tag;

            if (tag)
            {
                but.BackColor = Color.Green;
            }
            else
            {
                but.BackColor = Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            treasure = true;
            Guessbox.Text = "";
        }
    }
}
