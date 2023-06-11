using SupervisoryServiceLibrary;
namespace SupervisoryServiceInterface
{
    public partial class MainForm : Form
    {
        private Table currentTable = Table.Buildings;
        public MainForm()
        {
            SupervisoryServiceLibrary.Tables.Fill();
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            listView1.ColumnClick += ColumnClick;
            ListViewWorker.Set(listView1, Table.Buildings);
            comboBoxTable.Items.Add("Объекты");
            comboBoxTable.Items.Add("Решения");
            comboBoxTable.Items.Add("Пользователи");
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
    }
}