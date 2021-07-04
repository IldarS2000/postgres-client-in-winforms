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
    public partial class task1_v1 : Form
    {
        public task1_v1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            try
            {
                var detail_type = inputArgument.Text;
                task1TableTableAdapter.Fill(myDataSet.task1Table, detail_type);
            }
            catch (Exception exception)
            {

            }
        }

        private void task1_v1_Load(object sender, EventArgs e)
        {

        }
    }
}
