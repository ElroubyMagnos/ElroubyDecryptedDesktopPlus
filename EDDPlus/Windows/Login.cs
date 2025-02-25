using EDDPlus.DB;

namespace EDDPlus.Windows
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            var eddplus = new eddplus();

            if (eddplus.Users.Any(x => x.Name == Username.Text && x.Password == PasswordEntry.Text))
            {
                MessageBox.Show("Signed In Successfully!", "Great!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Hide();

                new Main(Username.Text).ShowDialog();

                Application.Exit();
            }
            else
            {
                MessageBox.Show("Wrong Account!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            Hide();
            new Register().ShowDialog();
            Show();
        }
    }
}
