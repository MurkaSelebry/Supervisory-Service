using SupervisoryServiceLibrary;
using System.Data;
using System.Drawing.Design;
using System.Xml.Serialization;
using static System.Windows.Forms.ListView;

namespace SupervisoryServiceInterface
{
    public partial class MainForm : Form
    {
        private User me = new User();
        private Table currentTable = Table.Buildings;
        public MainForm(User user)
        {
            InitializeComponent();
            me = user;
            SetVisibility();
        }
        public MainForm()
        {
            InitializeComponent();
            SetVisibility();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            listView1.ColumnClick += ColumnClick;
            ListViewWorker.Set(listView1, currentTable);
        }
        private void ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }
        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTable.SelectedIndex == 0)
            {
                currentTable = Table.Buildings;
                this.Text = "������������ �������";
                this.Icon = new Icon("icons/building.ico");
            }
            if (comboBoxTable.SelectedIndex == 1)
            {
                currentTable = Table.Solutions;
                this.Text = "�������";
                this.Icon = new Icon("icons/solution.ico");
            }
            if (comboBoxTable.SelectedIndex == 2)
            {
                currentTable = Table.Users;
                this.Text = "������������";
                this.Icon = new Icon("icons/user.ico");
            }
            if (currentTable == Table.Users)
                buttonView.Visible = false;
            else
                buttonView.Visible = true;
            ListViewWorker.Set(listView1, currentTable);
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            ListViewWorker.Set(listView1, currentTable);
        }
        private void SetVisibility()
        {
            comboBoxTable.Items.Add("�������");
            comboBoxTable.Items.Add("�������");
            if (me.Role == Role.Reader)
            {
                buttonAdd.Visible = false;
                buttonEdit.Visible = false;
                buttonDelete.Visible = false;
            }
            else if (me.Role == Role.Administrator)
            {
                comboBoxTable.Items.Add("������������");
            }
        }
        private void buttonView_Click(object sender, EventArgs e)
        {
            if (currentTable == Table.Buildings)
            {
                Building? selected = Tables.buildings.Find(building => building.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                if (selected != null)
                    new BuildingViewForm(selected).Show();
            }
            else if (currentTable == Table.Solutions)
            {
                Solution? selected = Tables.solutions.Find(solution => solution.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                if (selected != null)
                    new SolutionViewForm(selected).Show();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (currentTable == Table.Buildings)
            {
                new BuildingAddForm(Mode.Adding, new Building()).ShowDialog();
                //SaveToXml("buildings.xml", Tables.buildings.ToArray());
                //LoadFromXml("buildings.xml", Tables.buildings.ToArray());
            }
            else if (currentTable == Table.Solutions)
                new SolutionAddForm(Mode.Adding, new Solution()).ShowDialog();
            ListViewWorker.Set(listView1, currentTable);
            
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (currentTable == Table.Buildings)
            {
                Building? selected = Tables.buildings.Find(building => building.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                if (selected != null)
                    new BuildingAddForm(Mode.Editing, selected).ShowDialog();
            }
            else if (currentTable == Table.Solutions)
            {
                Solution? selected = Tables.solutions.Find(solution => solution.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                if (selected != null)
                    new SolutionAddForm(Mode.Editing, selected).ShowDialog();
            }
            else if (currentTable == Table.Users)
            {
                User? selected = Tables.users.Find(user => user.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                if (selected != null)
                    new SignUpForm(Mode.Editing, selected).ShowDialog();
            }
            ListViewWorker.Set(listView1, currentTable);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (currentTable == Table.Buildings)
            {
                Building? selected = Tables.buildings.Find(building => building.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                if (selected != null)
                    Tables.buildings.Remove(selected);
            }
            else if (currentTable == Table.Solutions)
            {
                Solution? selected = Tables.solutions.Find(solution => solution.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                if (selected != null)
                    Tables.solutions.Remove(selected);
            }
            else if (currentTable == Table.Users)
            {
                User? selected = Tables.users.Find(user => user.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                if (selected != null)
                    if (selected.Role != Role.Administrator)
                        Tables.users.Remove(selected);
                    else
                        MessageBox.Show("������ ������� ���������������", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListViewWorker.Set(listView1, currentTable);
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            ListViewWorker.Set(listView1, currentTable, ListViewWorker.Find(currentTable, toolStripTextBox1.Text));
        }

        private void toolStripButtonCalendar_Click(object sender, EventArgs e)
        {
            new Calendar().Show();
        }

        private void toolStripButtonFilter_Click(object sender, EventArgs e)
        {
            if (currentTable == Table.Buildings)
            {
                BuildingFilterForm buildingFilterForm = new BuildingFilterForm();
                buildingFilterForm.ShowDialog();
                if (buildingFilterForm.DialogResult == DialogResult.OK)
                    ListViewWorker.Set(listView1, currentTable, Filter.filter.Find(Tables.buildings.ToArray()));
            }
            if (currentTable == Table.Solutions)
            {
                SolutionFilterForm solutionFilterForm = new SolutionFilterForm();
                solutionFilterForm.ShowDialog();
                if (solutionFilterForm.DialogResult == DialogResult.OK)
                    ListViewWorker.Set(listView1, currentTable, Filter.filter.Find(Tables.solutions.ToArray()));
            }
        }
        




        //public void LoadFromXML(string myXmlFilePath)
        //{
        //    if (File.Exists(myXmlFilePath))
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(ListViewItemCollection));

        //        using (FileStream stream = File.OpenRead(myXmlFilePath))
        //        {
        //           // listView1.Items = (ListViewItemCollection)serializer.Deserialize(stream);
        //        };
        //    };
        //}
    }
}