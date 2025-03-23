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

namespace FastEvents
{
    public partial class SearchEvents : Form
    {
        public SearchEvents()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RMM214C\\SQLEXPRESS;Initial Catalog=fasteventsportal;Integrated Security=True");
            string query = "SELECT *FROM currentuser";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string userType = dt.Rows[0]["usertype"].ToString();
            this.Close();
            if (userType == "Admin")
            {
                AdminPortal adminPortal = new AdminPortal();
                adminPortal.Show();
            }
            else if (userType == "Managing Team")
            {
                ManagingTeamPortal managingTeamPortal = new ManagingTeamPortal();
                managingTeamPortal.Show();
            }
            else if (userType == "Participant")
            {
                StudentPortal studentPortal = new StudentPortal();
                studentPortal.Show();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-RMM214C\\SQLEXPRESS;Initial Catalog=fasteventsportal;Integrated Security=True"))
            {
                con.Open();

                string name = this.name.Text;

                string query = "SELECT * FROM Events WHERE Title = @name";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView2.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
