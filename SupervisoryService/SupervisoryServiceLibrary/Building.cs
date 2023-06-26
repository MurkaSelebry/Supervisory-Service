namespace SupervisoryServiceLibrary
{
    public class Building
    {
        //Building: Id, Adress, Cadastral, Square, Date, Material, Floors, Responsible
        public int Id { get; set; } = 0;
        public string Adress { get; set; } = string.Empty;
        public string Cadastral { get; set; } = string.Empty;
        public float Square { get; set; } = 0f;
        public DateTime Date { get; set; } = DateTime.Now;
        public string Material { get; set; } = string.Empty;
        public int Floors { get; set; } = 0;
        public string Responsible { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }
}