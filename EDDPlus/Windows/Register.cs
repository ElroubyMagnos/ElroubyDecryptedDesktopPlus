using EDDPlus.DB;
using EDDPlus.DB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDPlus.Windows
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void RegisterBtn_Click(object sender, EventArgs e)
        {
            var eddplus = new eddplus();

            if (Username.Text.Length == 0 || PasswordEntry.Text.Length == 0)
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PasswordEntry.Text != ConfirmPass.Text)
            {
                MessageBox.Show("Passwords not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (eddplus.Users.Any(x => x.Name == Username.Text))
            {
                MessageBox.Show("Name already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var newuser = new User();
                newuser.Name = Username.Text;
                Username.Text = "";

                newuser.Password = PasswordEntry.Text;

                PasswordEntry.Text = "";
                ConfirmPass.Text = "";

                await eddplus.Users.AddAsync(newuser);

                await eddplus.SaveChangesAsync();

                MessageBox.Show("Succedeed", "Great!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
