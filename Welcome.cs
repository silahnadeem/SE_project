namespace FastEvents
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
                this.Hide();
                Signup sign = new Signup();
                sign.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            login sign = new login();
            sign.Show();
        }
    }
}