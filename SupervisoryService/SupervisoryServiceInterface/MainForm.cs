using SupervisoryServiceLibrary;
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
            ListViewWorker.Set(listView1, Table.Buildings);
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
                buttonAdd.Visible= false;
                buttonEdit.Visible= false;
                buttonDelete.Visible = false;
            }
            else if(me.Role == Role.Administrator)
            {
                comboBoxTable.Items.Add("������������");
            }
        }
        private void buttonView_Click(object sender, EventArgs e)
        {
            if(currentTable == Table.Buildings)
            {
                Building selected = Tables.buildings.Find(building => building.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                if (selected != null)
                    new BuildingViewForm(selected).ShowDialog();
            }
        }
    }
}