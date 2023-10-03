namespace SupervisoryServiceLibrary
{
    public partial class BuildingAddForm : Form
    {
        private string action = string.Empty;
        Building building = new Building();
        public BuildingAddForm()
        {
            InitializeComponent();
        }
        public BuildingAddForm(string action, Building building)
        {
            InitializeComponent();
            this.action = action;
            this.building = building;
            if (action == Mode.Adding)
            {
                this.Icon = new Icon("icons/add.ico");
                button.Text = "Добавить";
                this.Text = "Добавление нового объекта";
            }
            else if (action == Mode.Editing)
            {
                this.Icon = new Icon("icons/edit.ico");
                textBoxAdress.Text = building.Adress;
                textBoxCadastral.Text = building.Cadastral;
                numericUpDownSquare.Value = (decimal)building.Square;
                dateTimePicker1.Value = building.Date;
                textBoxMaterial.Text = building.Material;
                numericUpDownFloors.Value = (decimal)building.Floors;
                textBoxResponsible.Text = building.Responsible;
                button.Text = "Сохранить";
                this.Text = "Редактирование существующего обьекта";
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            //Building: Id, Adress, Cadastral, Square, Date, Material, Floors, Responsible
            if (action == Mode.Adding)
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
            else if (action == Mode.Editing)
            {
                //Building: Id, Adress, Cadastral, Square, Date, Material, Floors, Responsible
                Tables.buildings.Remove(building);
                Tables.buildings.Add(new Building
                {
                    Id = building.Id,
                    Adress = textBoxAdress.Text,
                    Cadastral = textBoxCadastral.Text,
                    Square = (float)numericUpDownSquare.Value,
                    Date = dateTimePicker1.Value,
                    Material = textBoxMaterial.Text,
                    Floors = (int)numericUpDownFloors.Value,
                    Responsible = textBoxResponsible.Text
                });
            }
            Close();
        }
    }
}