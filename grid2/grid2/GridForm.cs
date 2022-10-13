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
        DataTable cel = new DataTable();
        public int GuessCount;
        public int guessnumber;
        public int guessinput = 0;
        public bool search;
        public int found = 0;
        public int searchrow;
        public int searcholumn;
        public bool treasure;
        public bool GameOver;

        private void Form1_Load(object sender, EventArgs e)
        {
            //columns
            cel.Columns.Add("0", typeof(int));
            cel.Columns.Add("1", typeof(int));
            cel.Columns.Add("2", typeof(int));
            cel.Columns.Add("3", typeof(int));
            cel.Columns.Add("4", typeof(int));
            cel.Columns.Add("5", typeof(int));
            cel.Columns.Add("6", typeof(int));
            cel.Columns.Add("7", typeof(int));
            cel.Columns.Add("8", typeof(int));
            cel.Columns.Add("9", typeof(int));

            //rows
            cel.Rows.Add(00, 10, 20, 30, 40, 50, 60, 70, 80, 90);
            cel.Rows.Add(01, 11, 21, 31, 41, 51, 61, 71, 81, 91);
            cel.Rows.Add(02, 12, 22, 32, 42, 52, 62, 72, 82, 92);
            cel.Rows.Add(03, 13, 23, 33, 43, 53, 63, 73, 83, 93);
            cel.Rows.Add(04, 14, 24, 34, 44, 54, 64, 74, 84, 94);
            cel.Rows.Add(05, 15, 25, 35, 45, 55, 65, 75, 85, 95);
            cel.Rows.Add(06, 16, 26, 36, 46, 56, 66, 76, 86, 96);
            cel.Rows.Add(07, 17, 27, 37, 47, 57, 67, 77, 87, 97);

            //Integrating data table into datagrid
            dataGridView1.DataSource = cel;///
        }
    }
}
