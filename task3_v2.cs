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
    public partial class task3_v2 : Form
    {
        public task3_v2()
        {
            InitializeComponent();
        }

        private void task3_v2_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'myDataSet.warehouses' table. You can move, or remove it, as needed.
            this.warehousesTableAdapter.Fill(this.myDataSet.warehouses);
            // TODO: This line of code loads data into the 'myDataSet.availability_of_details' table. You can move, or remove it, as needed.
            this.availability_of_detailsTableAdapter.Fill(this.myDataSet.availability_of_details);
            // TODO: This line of code loads data into the 'myDataSet.details' table. You can move, or remove it, as needed.
            this.detailsTableAdapter.Fill(this.myDataSet.details);
            Query();
        }

        private void Query()
        {
            bool aT, eR1, eR2;
            myDataSet.task3Table.Clear();
            foreach(myDataSet.warehousesRow wRow in myDataSet.warehouses.Rows)
            {
                aT = true;
                foreach (myDataSet.detailsRow dRow in myDataSet.details.Rows)
                {
                    aT = dRow.price <= 100;
                    if (!aT)
                    {
                        eR1 = false;
                        foreach (myDataSet.availability_of_detailsRow aRow in myDataSet.availability_of_details.Rows)
                        {
                            eR1 = aRow.quantity > 200 && aRow.id_detail == dRow.id_detail && aRow.id_warehouse == wRow.id_warehouse;
                            if (eR1)
                                break;
                        }
                        eR2 = false;
                        foreach (myDataSet.availability_of_detailsRow aRow in myDataSet.availability_of_details.Rows)
                        {
                            eR2 = aRow.quantity > 200 && aRow.id_warehouse == wRow.id_warehouse;
                            if (eR2)
                                break;
                        }
                        aT = eR1||eR2;
                    }
                    if (!aT)
                        break;
                }
                if (aT)
                {
                    myDataSet.task3TableRow tRow = myDataSet.task3Table.Newtask3TableRow();
                    tRow.id_warehouse = wRow.id_warehouse;
                    myDataSet.task3Table.Rows.Add(tRow);
                }
            }
            dataGridView1.Refresh();
        }
    }
}
