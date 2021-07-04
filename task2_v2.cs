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
    public partial class task2_v2 : Form
    {
        public task2_v2()
        {
            InitializeComponent();
        }

        private void task2_v2_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'myDataSet.details' table. You can move, or remove it, as needed.
            this.detailsTableAdapter.Fill(this.myDataSet.details);
            // TODO: This line of code loads data into the 'myDataSet.availability_of_details' table. You can move, or remove it, as needed.
            this.availability_of_detailsTableAdapter.Fill(this.myDataSet.availability_of_details);
            Query();
        }

        private void Query()
        {
            myDataSet.task2Table.Clear();
            int id = -1;
            int sum = 0;
            myDataSet.task2TableRow tRow = null;
            foreach (myDataSet.availability_of_detailsRow aRow in myDataSet.availability_of_details.Rows)
            {
                if (tRow == null)
                {
                    id = aRow.id_detail;
                    sum = aRow.quantity;
                    tRow = myDataSet.task2Table.Newtask2TableRow();

                }
                else if (aRow.id_detail == id)
                {
                    sum += aRow.quantity;
                }
                else
                {
                    string type = myDataSet.details.FindByid_detail(id).detail_type;
                    if (type == "bought")
                    {
                        tRow.general_amount = sum;
                        tRow.name = myDataSet.details.FindByid_detail(id).name;
                        myDataSet.task2Table.Addtask2TableRow(tRow);

                    }
                    id = aRow.id_detail;
                    sum = aRow.quantity;
                    tRow = myDataSet.task2Table.Newtask2TableRow();
                }
            }
            if (tRow != null)
            {
                tRow.general_amount = sum;
                tRow.name = myDataSet.details.FindByid_detail(id).name;
                myDataSet.task2Table.Addtask2TableRow(tRow);
            }
            dataGridView1.Refresh();
        }
    }
}
