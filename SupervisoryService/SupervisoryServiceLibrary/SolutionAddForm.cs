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
        private int id = 0;
        public SolutionAddForm()
        {
            InitializeComponent();
        }
        public SolutionAddForm(string action, int id)
        {
            InitializeComponent();
            this.action = action;
            this.id = id;
            if (action == "add")
            {
                button.Text = "Добавить";
                this.Text = "Добавление нового объекта";
            }
            else if (action == "edit")
            {
                Solution solution = Tables.solutions.Find(solution => solution.Id == id);
                if (solution != null)
                {
                    textBoxTitle.Text = solution.Title;
                    richTextBoxDescription.Text = solution.Description;
                    dateTimePicker1.Value = solution.Date;
                    textBoxResponsible.Text = solution.Responsible;
                    comboBox1.Text = solution.Status;
                }
                button.Text = "Сохранить";
                this.Text = "Редактирование существующего обьекта";
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (action == "add")
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
            else if (action == "edit")
            {
                //Building: Id, Adress, Cadastral, Square, Date, Material, Floors, Responsible
                Solution removable = Tables.solutions.Find(solution => solution.Id == id);
                if (removable != null)
                {
                    Tables.solutions.Remove(removable);
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
            }
            Close();
        }
    }
}
