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
    public partial class SolutionAddForm : Form
    {
        private string action = string.Empty;
        private Solution solution = new Solution();
        public SolutionAddForm()
        {
            InitializeComponent();
        }
        public SolutionAddForm(string action, Solution solution)
        {
            InitializeComponent();
            this.action = action;
            this.solution = solution;
            if (action == Mode.Adding)
            {
                this.Icon = new Icon("icons/add.ico");
                button.Text = "Добавить";
                this.Text = "Добавление нового объекта";
            }
            else if (action == Mode.Editing)
            {
                this.Icon = new Icon("icons/edit.ico");
                textBoxTitle.Text = solution.Title;
                richTextBoxDescription.Text = solution.Description;
                dateTimePicker1.Value = solution.Date;
                textBoxResponsible.Text = solution.Responsible;
                comboBox1.Text = solution.Status;
                button.Text = "Сохранить";
                this.Text = "Редактирование существующего обьекта";
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (action == Mode.Adding)
            {
                Tables.solutions.Add(new Solution
                {
                    Id = Tables.solutions.Last().Id + 1,
                    Title = textBoxTitle.Text,
                    Description = richTextBoxDescription.Text,
                    Date = dateTimePicker1.Value,
                    Responsible = textBoxResponsible.Text,
                    Status = comboBox1.Text
                });
            }
            else if (action == Mode.Editing)
            {
                //Building: Id, Adress, Cadastral, Square, Date, Material, Floors, Responsible
                Tables.solutions.Remove(solution);
                Tables.solutions.Add(new Solution
                {
                    Id = solution.Id,
                    Title = textBoxTitle.Text,
                    Description = richTextBoxDescription.Text,
                    Date = dateTimePicker1.Value,
                    Responsible = textBoxResponsible.Text,
                    Status = comboBox1.Text
                });
            }
            Close();
        }
    }
}
