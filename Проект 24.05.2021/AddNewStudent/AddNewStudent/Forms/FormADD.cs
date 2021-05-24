using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AddNewStudent
{
    public partial class FormADD : Form
    {
        public string conString = "Data Source=DESKTOP-15T47F6;Initial Catalog=ProjectDbStudent;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FormADD()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Students(Student_ID, Surname, Name, " + " Age, Year, Groupp)" + "values('" + tbID.Text.ToString() + "','" + tbSurname.Text.ToString() + "','" + tbName.Text.ToString() + "','" + tbFather.Text.ToString() + "','" + tbAge.Text.ToString() + "','" + tbKurs.Text.ToString() + "','" + tbGroup.Text.ToString() + "') ";

                SqlCommand cmd = new SqlCommand(q, con);
                
                MessageBox.Show("Connection was successful!");
            }

            con.Close();


            this.Hide();

            ViewDB formDb = new ViewDB();
            formDb.Show();
           
           
        }
    }
}
