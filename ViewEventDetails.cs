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

namespace FastEvents
{
    public partial class ViewEventDetails : Form
    {
        public ViewEventDetails()
        {
            InitializeComponent();
        }
        public ViewEventDetails(DataTable eventData)
        {
            InitializeComponent();

            // Bind event data to DataGridView
            dataGridView2.DataSource = eventData;
        }

        private void ViewEventDetails_Load(object sender, EventArgs e)
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
    }
}
