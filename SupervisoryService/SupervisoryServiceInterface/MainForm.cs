using SupervisoryServiceLibrary;
using System.Data;

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
                currentTable = Table.Buildings;
            else if (comboBoxTable.SelectedIndex == 1)
                currentTable = Table.Solutions;
            else if (comboBoxTable.SelectedIndex == 2)
                currentTable = Table.Users;
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
            comboBoxTable.Items.Add("Объекты");
            comboBoxTable.Items.Add("Решения");
            if (me.Role == Role.Reader)
            {
                buttonAdd.Visible = false;
                buttonEdit.Visible = false;
                buttonDelete.Visible = false;
            }
            else if (me.Role == Role.Administrator)
            {
                comboBoxTable.Items.Add("Пользователи");
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
                new BuildingAddForm(Mode.Adding, new Building()).ShowDialog();
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
                        MessageBox.Show("Нельзя удалить администрпатора", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListViewWorker.Set(listView1, currentTable);
        }
    }
}