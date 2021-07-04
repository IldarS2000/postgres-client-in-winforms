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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.warehouses". При необходимости она может быть перемещена или удалена.
            this.warehousesTableAdapter.Fill(this.myDataSet.warehouses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.availability_of_details". При необходимости она может быть перемещена или удалена.
            this.availability_of_detailsTableAdapter.Fill(this.myDataSet.availability_of_details);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.details". При необходимости она может быть перемещена или удалена.
            this.detailsTableAdapter.Fill(this.myDataSet.details);
            dataGridView1.AutoGenerateColumns = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "Детали")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = detailsBindingSource;
                bindingNavigator1.BindingSource = detailsBindingSource;
                lblTableName.Text = "Детали";
            }
        }

        private void btnWarehouses_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "Склады")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = warehousesBindingSource;
                bindingNavigator1.BindingSource = warehousesBindingSource;
                lblTableName.Text = "Склады";
            }
        }

        private void btnAvailabilityOfDetails_Click(object sender, EventArgs e)
        {
            if (lblTableName.Text != "Наличие деталей")
            {
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = availabilityofdetailsBindingSource;
                bindingNavigator1.BindingSource = availabilityofdetailsBindingSource;
                lblTableName.Text = "Наличие деталей";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //tableAdapterManager.UpdateAll(myDataSet);
            //MessageBox.Show("Изменения сохранены");
            try
            {
                warehousesTableAdapter.Update(myDataSet.warehouses);
                detailsTableAdapter.Update(myDataSet.details);
                availability_of_detailsTableAdapter.Update(myDataSet.availability_of_details);
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
