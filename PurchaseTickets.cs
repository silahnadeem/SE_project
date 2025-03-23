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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FastEvents
{
    public partial class PurchaseTickets : Form
    {
        public PurchaseTickets()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RMM214C\\SQLEXPRESS;Initial Catalog=fasteventsportal;Integrated Security=True");
            string query = "select e.eventid,e.title,e.description,e.date,e.time,e.location,c.CategoryID,c.CategoryName,t.price,t.nooftickets,t.ticketid from Events e \r\ninner join EventCategories c on c.CategoryID=e.CategoryID \r\ninner join Eventstickets t on t.eventid=e.EventID";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {


            if (!int.TryParse(textBox4.Text, out int eventId))
            {
                MessageBox.Show("Please enter a valid integer for Ticket ID.", "Error");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-RMM214C\\SQLEXPRESS;Initial Catalog=fasteventsportal;Integrated Security=True");
                con.Open();
                string eventIdCheckQuery = "select count(*) from EventsTickets where ticketid= @eventId";
                SqlCommand idCheckCmd = new SqlCommand(eventIdCheckQuery, con);
                idCheckCmd.Parameters.AddWithValue("@eventId", eventId);
                int idCount = (int)idCheckCmd.ExecuteScalar();
                if (idCount == 0)
                {
                    MessageBox.Show("Ticket ID does not exist.", "Error");
                }
                else
                {
                    string queryy = "SELECT userid FROM currentuser";
                    SqlDataAdapter sda = new SqlDataAdapter(queryy, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        int userid = Convert.ToInt32(dt.Rows[0]["userid"]);

                        string query = "INSERT INTO Payments (ticketid, userid) VALUES (@ticketid, @userid)";
                        SqlCommand sqlCommand = new SqlCommand(query, con);
                        sqlCommand.Parameters.AddWithValue("@ticketid", textBox4.Text);
                        sqlCommand.Parameters.AddWithValue("@userid", userid); // Use the converted userid
                        sqlCommand.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Ticket is Purchased", "Successfully");
                    }
                    else
                    {
                        MessageBox.Show("No current user found.", "Error");
                    }
                }
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
