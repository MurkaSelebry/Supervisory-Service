namespace SupervisoryServiceLibrary
{
    public partial class BuildingAddForm : Form
    {
        private string action = string.Empty;
        int id = 0;
        public BuildingAddForm()
        {
            InitializeComponent();
        }
        public BuildingAddForm(string action, int id)
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
                button.Text = "Сохранить";
                button.Text = "Редактирование существующего обьекта";
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            //Building: Id, Adress, Cadastral, Square, Date, Material, Floors, Responsible
            if (action == "add")
            {
                Tables.buildings.Add(new Building
                {
                    Id = Tables.buildings.Last().Id + 1,
                    Adress = textBoxAdress.Text,
                    Cadastral = textBoxCadastral.Text,
                    Square = (float)numericUpDownSquare.Value,
                    Date = dateTimePicker1.Value,
                    Material = textBoxMaterial.Text,
                    Floors = (int)numericUpDownFloors.Value,
                    Responsible = textBoxResponsible.Text
                });
            }
            else if (action == "edit")
            {
                int index = Tables.buildings.FindIndex(building => building.Id == id);
                if (index >= 0)
                {
                    if (!string.IsNullOrEmpty(textBoxAdress.Text))
                        Tables.buildings[index].Adress = textBoxAdress.Text;
                    if (!string.IsNullOrEmpty(textBoxCadastral.Text))
                        Tables.buildings[index].Cadastral = textBoxCadastral.Text;
                    if (numericUpDownSquare.Value > 0)
                        Tables.buildings[index].Square = (float)numericUpDownSquare.Value;
                    if (dateTimePicker1.Value != null)
                        Tables.buildings[index].Date = dateTimePicker1.Value;
                    if(!string.IsNullOrEmpty(textBoxMaterial.Text))
                        Tables.buildings[index].Material = textBoxMaterial.Text;
                    if (numericUpDownFloors.Value > 0)
                        Tables.buildings[index].Floors = (int)numericUpDownFloors.Value;
                    if(!string.IsNullOrEmpty(textBoxResponsible.Text))
                        Tables.buildings[index].Responsible = textBoxResponsible.Text;
                }
            }
        }
    }
}