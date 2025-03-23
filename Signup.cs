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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = this.Fname.Text;
            string lastname = this.Lname.Text;
            string username = this.user.Text;
            string password1 = this.pass.Text;
            string phoneNumber = this.number.Text;
            string role = roleBtn.Text;


            if (pass.Text != pass2.Text)
            {
                MessageBox.Show($"Passwords do not match");
            }
            else
            {


                // TODO: Add validation for required fields
                // connecting to sql and writing data in that
                string connect = "Data Source=DESKTOP-SMU66TS\\SQLEXPRESS01;Initial Catalog=fastevents;Integrated Security=True";
                //string connect = "Data Source =DESKTOP-RMM214C\\SQLEXPRESS; Initial Catalog = CMSEATLYDB; Integrated Security = True";
                // SqlConnection con = new SqlConnection(connect);
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-RMM214C\\SQLEXPRESS;Initial Catalog=fasteventsportal;Integrated Security=True");
                con.Open();
                string query;
                string queryID;
                int adminID = 0;
                int partID = 0;
                int memberID = 0;
                int userID = 0;

                SqlCommand cm;


                if (role == "Participant")
                {
                    queryID = "select top 1 ParticipantID from Participant order by ParticipantID desc";
                    cm = new SqlCommand(queryID, con);
                    partID = Convert.ToInt32(cm.ExecuteScalar());

                    partID++;

                    query = "INSERT INTO Participant (Fname, Lname, Username, Password, PhoneNumber) " +
                            "VALUES (@Fname, @Lname, @Username, @Password, @PhoneNumber);" +
                            "SELECT SCOPE_IDENTITY();";
                }
                else if (role == "Admin")
                {
                    queryID = "select top 1 AdminID from Admin order by AdminID desc";
                    cm = new SqlCommand(queryID, con);
                    adminID = Convert.ToInt32(cm.ExecuteScalar());
                    adminID++;

                    query = "INSERT INTO Admin (Fname, Lname, Username, Password, PhoneNumber) " +
                            "VALUES (@Fname, @Lname, @Username, @Password, @PhoneNumber);" +
                            "SELECT SCOPE_IDENTITY();";
                }
                else
                {
                    queryID = "select top 1 MemberID from ManagingTeam order by MemberID desc";
                    cm = new SqlCommand(queryID, con);
                    memberID = Convert.ToInt32(cm.ExecuteScalar());
                    memberID++;

                    query = "INSERT INTO ManagingTeam (Fname, Lname, Username, Password, PhoneNumber) " +
                            "VALUES (@Fname, @Lname, @Username, @Password, @PhoneNumber);" +
                            "SELECT SCOPE_IDENTITY();";
                }

                queryID = "select top 1 UserID from Userr order by UserID desc";
                cm = new SqlCommand(queryID, con);
                userID = Convert.ToInt32(cm.ExecuteScalar());
                userID++;

                string queryyy;
                // Insert into Userr table to get the generated userID
                queryyy = "INSERT INTO Userr (UserID, Username, Password, Role) " +
                        "VALUES (@UserID, @Username, @Password, @Role);";

                cm = new SqlCommand(queryyy, con);

                // Set parameters for the Userr table
                cm.Parameters.AddWithValue("@Userid", userID);
                cm.Parameters.AddWithValue("@Username", username);
                cm.Parameters.AddWithValue("@Password", password1);
                cm.Parameters.AddWithValue("@Role", role);





                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@partID", partID);
                cmd.Parameters.AddWithValue("@adminID", adminID);
                cmd.Parameters.AddWithValue("@memberID", memberID);
                // cmd.Parameters.AddWithValue("@invmgrID", invmgrID);
                //cmd.Parameters.AddWithValue("@Userid", userID);

                cmd.Parameters.AddWithValue("@Fname", firstname);
                cmd.Parameters.AddWithValue("@Lname", lastname);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password1);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                // cmd.Parameters.AddWithValue("@Role", role);

                // Use ExecuteScalar to get the generated identity value
                int result = cmd.ExecuteNonQuery();
                int result2 = cm.ExecuteNonQuery();

                Console.WriteLine(result);

                if (result > 0)
                {
                    MessageBox.Show($"User added successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }


            this.Hide();
            login login = new login();
            login.Show();
        }

        private void pass2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fname_click(object sender, MouseEventArgs e)
        {
            this.Fname.Text = "";
        }

        private void lname(object sender, MouseEventArgs e)
        {
            this.Lname.Text = "";
        }


        private void username(object sender, MouseEventArgs e)
        {
            this.user.Text = "";
        }

        private void password1(object sender, MouseEventArgs e)
        {
            this.pass.Text = "";
        }

        private void password2(object sender, MouseEventArgs e)
        {
            this.pass2.Text = "";
        }

        private void phone(object sender, MouseEventArgs e)
        {
            this.number.Text = "";
        }

        private void roleBtn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
