using Devart.Data.PostgreSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.warehouses". При необходимости она может быть перемещена или удалена.
            this.warehousesTableAdapter.Fill(this.myDataSet.warehouses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.details". При необходимости она может быть перемещена или удалена.
            this.detailsTableAdapter.Fill(this.myDataSet.details);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.availability_of_details". При необходимости она может быть перемещена или удалена.
            this.availability_of_detailsTableAdapter.Fill(this.myDataSet.availability_of_details);
        }

        private void availability_of_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void warehouses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dgv_details_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = detailsBindingSource;
            dgv_availability_of_details.DataSource = iddetailfkBindingSource;
            lblTable.Text = "Детали";
        }

        private void dgv_warehouses_Click(object sender, EventArgs e)
        { 
            bindingNavigator1.BindingSource = warehousesBindingSource;
            dgv_availability_of_details.DataSource = idwarehousefkBindingSource;
            lblTable.Text = "Склады";
        }

        private void dgv_availability_of_details_Click(object sender, EventArgs e)
        {
            dgv_availability_of_details.DataSource = availabilityofdetailsBindingSource;
            lblTable.Text = "Наличие деталей";
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            var row = dgv_availability_of_details.CurrentCell.RowIndex;
            var col = dgv_availability_of_details.CurrentCell.ColumnIndex;

            if (row > 0)
            {
                dgv_availability_of_details.CurrentCell = dgv_availability_of_details[col, row - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var row = dgv_availability_of_details.CurrentCell.RowIndex;
            var col = dgv_availability_of_details.CurrentCell.ColumnIndex;

            if (row < dgv_availability_of_details.RowCount - 1)
            {
                dgv_availability_of_details.CurrentCell = dgv_availability_of_details[col, row + 1];
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            var col = dgv_availability_of_details.CurrentCell.ColumnIndex;
            dgv_availability_of_details.CurrentCell = dgv_availability_of_details[col, 0];
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            var col = dgv_availability_of_details.CurrentCell.ColumnIndex;
            dgv_availability_of_details.CurrentCell = dgv_availability_of_details[col, dgv_availability_of_details.RowCount - 1];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.warehousesTableAdapter.Update(this.myDataSet.warehouses);
                this.detailsTableAdapter.Update(this.myDataSet.details);
                this.availability_of_detailsTableAdapter.Update(this.myDataSet.availability_of_details);
                MessageBox.Show("Изменения сохранены!");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void availability_dataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_availability_of_details.CurrentCell != null)
            {
                var row = dgv_availability_of_details.CurrentCell.RowIndex;

                if (row == 0)
                {
                    btnPrev.Enabled = false;
                    btnFirst.Enabled = false;
                }
                else
                {
                    btnPrev.Enabled = true;
                    btnFirst.Enabled = true;
                }
                //последняя строка
                if (row == dgv_availability_of_details.RowCount - 1)
                {
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                }

            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            availability_of_detailsTableAdapter.Fill(myDataSet.availability_of_details);
            availability_dataGridView_CurrentCellChanged(dgv_availability_of_details, e);
        }

        private void lblTable_Click(object sender, EventArgs e)
        {

        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            PgSqlConnection conn = new PgSqlConnection("User Id=postgres;Password=gunbai;Host=localhost;Database=estore;Initial Schema=public");    
            PgSqlCommand cmd = new PgSqlCommand("count_warehouses_with_detail", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("type", inputData.Text);

            cmd.Parameters.Add(new PgSqlParameter()
            {
                ParameterName = "counter",
                Direction = ParameterDirection.Output,
                DbType = DbType.Int32
            });

            conn.Open();

            cmd.ExecuteNonQuery();
            var counter = cmd.Parameters["counter"].Value.ToString();
            lblAnswer.Text = $"Результат: {counter}";

            conn.Close();
        }

        private void альтернативнаяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void вариант1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t11 = new task1_v1();
            t11.ShowDialog();
        }

        private void вариант2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t12 = new task1_v2();
            t12.ShowDialog();
        }

        private void вариант3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t13 = new task1_v3();
            t13.ShowDialog();
        }

        private void вариант4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t14 = new task1_v4();
            t14.ShowDialog();
        }

        private void вариант5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var t15 = new task1_v5();
            t15.ShowDialog();
        }

        private void представлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void вариант1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var t21 = new task2_v1();
            t21.ShowDialog();
        }

        private void вариант1ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            var t21 = new task2_v1();
            t21.ShowDialog();
        }

        private void вариант2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var t22 = new task2_v2();
            t22.ShowDialog();
        }

        private void вариант1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var t31 = new task3_v1();
            t31.ShowDialog();
        }

        private void вариант2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var t32 = new task3_v2();
            t32.ShowDialog();
        }
    }
}
