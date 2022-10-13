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
    public partial class HighscoreForm : Form
    {
        public HighscoreForm()
        {
            InitializeComponent();
        }
        DataTable HighscoreTable = new DataTable();
        
        private void HighscoreForm_Load(object sender, EventArgs e)
        {
            HighscoreTable.Columns.Add("Name", typeof(String));
            HighscoreTable.Columns.Add("HighScore", typeof(String));


            dataGridView2.DataSource = HighscoreTable;

        }
    }
}
