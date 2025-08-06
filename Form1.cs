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

namespace ExportToExcelProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=StudManagement;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM dbo.MstGrades";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;
            }
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            ExcelExporter exporter = new ExcelExporter();
            exporter.ExportDataGridViewToExcel(dataGridView1);
        }
    }
}
