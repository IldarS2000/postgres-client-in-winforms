using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseProject
{
    public partial class task3_v1 : Form
    {
        public task3_v1()
        {
            InitializeComponent();
        }

        private void task3_v1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.task3Table' table. You can move, or remove it, as needed.
            this.task3TableAdapter.Fill(this.myDataSet.task3Table);

        }
    }
}
