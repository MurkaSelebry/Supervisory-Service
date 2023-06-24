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
    public partial class SolutionViewForm : Form
    {
        public SolutionViewForm()
        {
            InitializeComponent();
        }
        public SolutionViewForm(Solution solution)
        {
            InitializeComponent();
            labelSolution.Text += $" {solution.Title}\n{solution.Description}";
            labelDate.Text += $" {solution.Date.ToShortDateString()}";
            labelResponsible.Text += $" {solution.Responsible}";
            labelStatus.Text += $" {solution.Status}";
        }
    }
}
