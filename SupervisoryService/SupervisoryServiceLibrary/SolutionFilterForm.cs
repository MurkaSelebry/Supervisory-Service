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
    public partial class SolutionFilterForm : Form
    {
        private SolutionFilter filter = new();
        public SolutionFilterForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            filter = new SolutionFilter(dateTimePickerMin.Value, dateTimePickerMax.Value, comboBoxStatus.Text);
            Filter.filter = filter;
            DialogResult= DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }
    }
}
