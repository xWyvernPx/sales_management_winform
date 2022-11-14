namespace SalesWinApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit ?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter email!");
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Please enter password!");
            }
            else
            {
                //TODO : Authen & Authorize
                //var users = new HrAccountManager();
                //var user = users.GetAlls().Where(a => a.Email == txtUserName.Text
                //     && a.Password == txtPass.Text).FirstOrDefault();

                //if (user == null)
                //{
                //    MessageBox.Show("Invalid email or password!");
                //}
                //else
                //{
                //    //TODO  authorize
                //    if (user.MemberRole == 3)
                //    {


                Management form = new Management();
                //        form.Tag = user;
                this.Hide();
                form.Show();
                //    }
                //    else
                //    {
                //        MessageBox.Show("You are not allowed to access this function!");
                //    }
                //}

            }
        }
    }
}