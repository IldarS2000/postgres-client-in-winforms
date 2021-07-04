using Devart.Data.PostgreSql;
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
    public partial class task1_v5 : Form
    {
        public task1_v5()
        {
            InitializeComponent();
        }

        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            FillGridByReader();
        }

        private void FillGridByReader()
        {
            PgSqlConnection con = new PgSqlConnection("User Id=postgres;Password=gunbai;Host=localhost;Database=estore;Initial Schema=public");
            con.Open();
            String query =
                $"select name, id_warehouse, quantity from details inner join availability_of_details aod on details.id_detail = aod.id_detail where detail_type = '{inputArgument.Text}'";
            PgSqlCommand cmd = new PgSqlCommand(query, con);
            PgSqlDataReader rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();

            BindingSource bs = new BindingSource();
            bs.DataSource = dt;

            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.Refresh();
        }

        private void task1_v5_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            FillGridByReader();
        }
    }
}
