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
    public partial class BrowseEvents : Form
    {

        public BrowseEvents()
        {
            InitializeComponent();

            this.Load += BrowseEvents_Load;
        }

        private void BrowseEvents_Load(object sender, EventArgs e)
        {
            // Subscribe to the CellContentClick event of dataGridView2
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
        }


        private void show_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-RMM214C\\SQLEXPRESS;Initial Catalog=fasteventsportal;Integrated Security=True"))
            {
                con.Open();

                string query = "select EventID, Title, Date from events where CategoryID=1";

                SqlCommand cmd = new SqlCommand(query, con);

                var reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView2.DataSource = dataTable;

                con.Close();
            }
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-RMM214C\\SQLEXPRESS;Initial Catalog=fasteventsportal;Integrated Security=True"))
            {
                con.Open();

                string query = "select EventID, Title, Date from events where CategoryID=2";

                SqlCommand cmd = new SqlCommand(query, con);

                var reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;

                con.Close();
            }
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-RMM214C\\SQLEXPRESS;Initial Catalog=fasteventsportal;Integrated Security=True"))
            {
                con.Open();

                string query = "select EventID, Title, Date from events where CategoryID=3";

                SqlCommand cmd = new SqlCommand(query, con);

                var reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView3.DataSource = dataTable;

                con.Close();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2 != null && e.RowIndex >= 0 && dataGridView2.CurrentCell != null)
            {
                int rowIndex = dataGridViewEvents.CurrentCell.RowIndex;
                DataGridViewRow row = dataGridViewEvents.Rows[rowIndex];

                // Retrieve the EventID from the selected row
                int eventId = Convert.ToInt32(row.Cells["EventID"].Value);

                DataTable eventData = FetchEventData(eventId);

                // Show EventDetailsForm and pass event data
                ViewEventDetails eventDetailsForm = new ViewEventDetails(eventData);
                eventDetailsForm.Show();
                ;
            }
        }

        private DataTable FetchEventData(int eventId)
        {

            string query = "SELECT * FROM Events WHERE EventID = @EventID";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RMM214C\\SQLEXPRESS;Initial Catalog=fasteventsportal;Integrated Security=True");
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@EventID", eventId);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable eventData = new DataTable();
            adapter.Fill(eventData);
            return eventData;

        }

        private void button8_Click(object sender, EventArgs e)
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
