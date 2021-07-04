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
    public partial class task1_v3 : Form
    {
        public task1_v3()
        {
            InitializeComponent();
        }

        private void task1_v3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.availability_of_details". При необходимости она может быть перемещена или удалена.
            this.availability_of_detailsTableAdapter.Fill(this.myDataSet.availability_of_details);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.details". При необходимости она может быть перемещена или удалена.
            this.detailsTableAdapter.Fill(this.myDataSet.details);

        }

        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            myDataSet.task1Table.Clear();
            foreach (myDataSet.availability_of_detailsRow avRow in myDataSet.availability_of_details.Rows)
            {
                myDataSet.detailsRow dRow = myDataSet.details.Rows.Find(avRow.id_detail)
                    as myDataSet.detailsRow;

                if (dRow.detail_type == inputArgument.Text)
                {
                    myDataSet.task1TableRow tRow = myDataSet.task1Table.Newtask1TableRow();
                    tRow.name = dRow.name;
                    tRow.id_warehouse = avRow.id_warehouse;
                    tRow.quantity = avRow.quantity;
                    myDataSet.task1Table.Addtask1TableRow(tRow);
                }
            }
            dataGridView1.Refresh();
        }
    }
}
