using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisoryServiceLibrary
{
    public partial class BuildingViewForm : Form
    {
        public BuildingViewForm()
        {
            InitializeComponent();
        }
        public BuildingViewForm(Building building)
        {
            InitializeComponent();
            labelAdress.Text += " " + building.Adress;
            labelCadastral.Text += " " + building.Cadastral;
            labelSquare.Text += " " + building.Square.ToString();
            labelDate.Text += " " + building.Date.ToShortDateString();
            labelMaterial.Text += " " + building.Material;
            labelFloors.Text += " " + building.Floors.ToString();
            labelResponsible.Text += " " + building.Responsible;
            //if (string.IsNullOrEmpty(building.Image) == false)
            //    pictureBox1.Image = Image.FromFile(building.Image);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  string path = @$"{Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "map.html").Replace('\\', '/')}";

            var p = new Process();
            p.StartInfo = new ProcessStartInfo($"http://127.0.0.1:5500/map.html?adress={labelAdress.Text}")
            {
                UseShellExecute = true
        };
          p.Start();  
        }
    }
}
