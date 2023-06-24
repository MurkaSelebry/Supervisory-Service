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
                int index = Tables.buildings.FindIndex(building => building.Id == id);
                if (index >= 0)
                {
                    textBoxAdress.Text = Tables.buildings[index].Adress;
                    textBoxCadastral.Text = Tables.buildings[index].Cadastral;
                    numericUpDownSquare.Value = (decimal)Tables.buildings[index].Square;
                    dateTimePicker1.Value = Tables.buildings[index].Date;
                    textBoxMaterial.Text = Tables.buildings[index].Material;
                    numericUpDownFloors.Value = (decimal)Tables.buildings[index].Floors;
                    textBoxResponsible.Text = Tables.buildings[index].Responsible;
                }
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
                //Building: Id, Adress, Cadastral, Square, Date, Material, Floors, Responsible
                Building removable = Tables.buildings.Find(building => building.Id == id);
                if (removable != null)
                {
                    Tables.buildings.Remove(removable);
                    Tables.buildings.Add(new Building
                    {
                        Id = id,
                        Adress = textBoxAdress.Text,
                        Cadastral = textBoxCadastral.Text,
                        Square = (float)numericUpDownSquare.Value,
                        Date = dateTimePicker1.Value,
                        Material = textBoxMaterial.Text,
                        Floors = (int)numericUpDownFloors.Value,
                        Responsible = textBoxResponsible.Text
                    });
                }
            }
        }

    }
}