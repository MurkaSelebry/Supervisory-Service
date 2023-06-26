using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupervisoryServiceLibrary;
namespace SupervisoryServiceInterface
{
    public partial class SignInForm : Form
    {
        public User? me = new User();
        public SignInForm()
        {
            InitializeComponent();
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxPassword.Text)) 
            {
                me = Tables.users.Find(user => user.Username == textBoxName.Text && user.Password == textBoxPassword.Text);
                if(me != null)
                {
                    new MainForm(me).ShowDialog();
                    Close();
                }
                else
                    MessageBox.Show("Неверное имя пользователя и/или пароль");
            }
            else
                MessageBox.Show("Неверное имя пользователя и/или пароль");
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            new SignUpForm("add", new User()).ShowDialog();
        }
    }
}
