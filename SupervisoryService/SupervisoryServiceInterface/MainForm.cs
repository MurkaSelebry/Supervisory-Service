using SupervisoryServiceLibrary;
namespace SupervisoryServiceInterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            SupervisoryServiceLibrary.Tables.Fill();
            InitializeComponent();
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
    }
}