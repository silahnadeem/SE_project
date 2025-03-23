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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FastEvents
{
    public static class SharedData
    {
        public static string SharedVariable { get; set; }
    }

    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        
        private void showorder_button_Click(object sender, EventArgs e)
        {
            string username = this.user.Text;
            SharedData.SharedVariable = username;

            string password = this.pass.Text;
            string role = "";

           // string connect = "Data Source=DESKTOP-SMU66TS\\SQLEXPRESS01;Initial Catalog=eatly;Integrated Security=True";

            // using (SqlConnection con = new SqlConnection(connect))
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-RMM214C\\SQLEXPRESS;Initial Catalog=fasteventsportal;Integrated Security=True"))
            {
                con.Open();




                string queryID = "SELECT Role FROM Userr WHERE username = @user AND password = @pass";

                using (SqlCommand cmd = new SqlCommand(queryID, con))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);


                    string query = "SELECT *FROM Userr WHERE username = '"+user.Text+"' AND password ='"+pass.Text+"'";
                    SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda1.Fill(dt);

                    // Use ExecuteScalar safely with null check
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        role = result.ToString();


                        string query3 = "delete from currentuser";
                        SqlCommand cmd3 = new SqlCommand(query3, con);
                        cmd3.ExecuteNonQuery();
                        string userType = dt.Rows[0]["role"].ToString();
                        string user_id = dt.Rows[0]["userid"].ToString();
                        string query2 = "insert into currentuser(userid,usertype) values('" + user_id + "','" + userType + "')";
                        SqlCommand cmd1 = new SqlCommand(query2, con);
                        cmd1.ExecuteNonQuery();

                        // Handle different roles
                        switch (role)
                        {
                            case "Participant":
                                this.Hide();
                                StudentPortal cust = new StudentPortal();
                                cust.Show();
                                break;

                            case "Admin":
                                this.Hide();
                                AdminPortal cash = new AdminPortal();
                                cash.Show();
                                break;

                            default:
                                this.Hide();
                                ManagingTeamPortal inv = new ManagingTeamPortal();
                                inv.Show();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {  
            this.Hide();
            Signup sign = new Signup();
            sign.Show();  
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

   
    }
}
