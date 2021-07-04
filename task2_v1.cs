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
    public partial class task2_v1 : Form
    {
        public task2_v1()
        {
            InitializeComponent();
        }

        private void task2_v1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.task2Table' table. You can move, or remove it, as needed.
            this.task2TableAdapter.Fill(this.myDataSet.task2Table);

        }
    }
}
