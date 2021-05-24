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
    public partial class QuertRes : Form
    {
        public QuertRes()
        {
            InitializeComponent();
        }

        private void btView_Click(object sender, EventArgs e)
        {
            string SqlText;

            SqlText = "SELECT " + textBox1.Text.ToString() + " FROM Members WHERE " + textBox2.Text.ToString() + " ORDER BY " + textBox3.Text.ToString();

           string conString = null;
            SqlDataAdapter da = new SqlDataAdapter(SqlText, conString);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Table]");

            dataGridView1.DataSource = ds.Tables["[Table]"].DefaultView;
        }
    }
}
