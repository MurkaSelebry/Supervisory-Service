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
    public partial class BuildingFilterForm : Form
    {
        private BuildingFilter filter = new();
        public BuildingFilterForm()
        {
            InitializeComponent();
            //numericUpDownMinSquare.Value = (decimal)filter.MinSquare;
            //numericUpDownMaxSquare.Value = (decimal)filter.MaxSquare;
            //dateTimePickerMin.Value = filter.MinDate;
            //dateTimePickerMax.Value = filter.MaxDate;
            //numericUpDownMinFloors.Value = (decimal)filter.MinFloors;
            //numericUpDownMaxFloors.Value = (decimal)filter.MaxFloors;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filter = new BuildingFilter
                (
                (float)numericUpDownMinSquare.Value,
                (float)numericUpDownMaxSquare.Value,
                dateTimePickerMin.Value, dateTimePickerMax.Value,
                comboBoxMaterial.Text,
                (int)numericUpDownMinFloors.Value,
                (int)numericUpDownMaxFloors.Value
                );
            Filter.filter = filter;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
