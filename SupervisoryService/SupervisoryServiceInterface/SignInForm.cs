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
        public User me = new User();
        public SignInForm()
        {
            InitializeComponent();
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text != string.Empty && textBoxPassword.Text != string.Empty) 
            {
                me = Tables.users.Find(user => user.Username == textBoxName.Text && user.Password == textBoxPassword.Text);
                if(me != null)
                {
                    new MainForm(me).ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя и/или пароль");
                }
            }
        }
    }
}
