using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisoryServiceLibrary
{
    public partial class SignUpForm : Form
    {
        private string mode = string.Empty;
        private User user = new User();
        public SignUpForm()
        {
            InitializeComponent();
        }
        public SignUpForm(string mode, User user)
        {
            this.mode = mode;
            this.user = user;
            InitializeComponent();
            if (mode == "add")
            {
                button.Text = "Зарегистрироваться";
                this.Text = "Регистрация";
                groupBox1.Visible = false;
            }
            else if (mode == "edit")
            {
                button.Text = "Редактирование существующего  пользователя";
                this.Text = "Сохранить";
                textBoxUsername.Text = user.Username;
                textBoxConfirmation.Text = textBoxPassword.Text = user.Password;
                textBoxEmail.Text = user.Email;
                textBoxPhone.Text = user.Phone;
                textBoxSurname.Text = user.Surname;
                textBoxName.Text = user.Name;
                textBoxPatronymic.Text = user.Patronymic;
                if (user.Role == Role.Reader)
                {
                    radioButton1.Checked = true;
                    radioButton1.Checked = radioButton2.Checked = true;
                }
                if (user.Role == Role.Writer)
                {
                    radioButton2.Checked = true;
                    radioButton1.Checked = radioButton2.Checked = true;
                }
                if (user.Role == Role.Administrator)
                {
                    radioButton3.Checked = true;
                    radioButton1.Checked = radioButton2.Checked = false;
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                if (textBoxPassword.Text == textBoxConfirmation.Text)
                {
                    Tables.users.Add(new User 
                    { 
                        Id = Tables.users.Last().Id + 1,
                        Username = textBoxUsername.Text,
                        Password = textBoxPassword.Text,
                        Role = role, Email = textBoxEmail.Text,
                        Phone = textBoxPhone,
                        Surname = textBoxSurname.Text,
                        Name = textBoxName.Text,
                        Patronymic = textBoxPatronymic.Text
                    });
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(mode == "edit")
            {
                if (textBoxPassword.Text == textBoxConfirmation.Text)
                {
                    Tables.users.Remove(user);
                    Tables.users.Add(new User
                    {
                        Id = Tables.users.Last().Id + 1,
                        Username = textBoxUsername.Text,
                        Password = textBoxPassword.Text,
                        Role = role,
                        Email = textBoxEmail.Text,
                        Phone = textBoxPhone,
                        Surname = textBoxSurname.Text,
                        Name = textBoxName.Text,
                        Patronymic = textBoxPatronymic.Text
                    });
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
