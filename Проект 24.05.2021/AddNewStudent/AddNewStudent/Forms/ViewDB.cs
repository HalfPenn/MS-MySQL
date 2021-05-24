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

namespace AddNewStudent
{
    public partial class ViewDB : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-15T47F6;Initial Catalog=ProjectDbStudent;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public ViewDB()
        {
            InitializeComponent();
        }

        private void ViewDB_Load(object sender, EventArgs e)
        {
            
            

            this.tableTableAdapter.Fill(this.projectDbStudentDataSet.Table);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from [Table]", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            QuertRes form6 = new QuertRes();
            form6.Show();
        }
    }
}
