using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SupervisoryServiceLibrary
{
    public static class Tables
    {
        public static List<Building> buildings = new List<Building>();
        public static List<Solution> solutions = new List<Solution>();
        public static List<User> users = new List<User>();
        public static void Fill()
        {
            buildings.Add(new Building { Id = 1, Adress = "Москва, Пушкина, 1", Cadastral = "00:00:000000:00", Square = 100f, Date = DateTime.Now, Floors = 10, Material = "Кирпич", Responsible = "Черномечников Гатс Гамбинович" });
            buildings.Add(new Building { Id = 2, Adress = "Москва, Пушкина, 2", Cadastral = "11:11:111111:11", Square = 100f, Date = DateTime.Now, Floors = 10, Material = "Кирпич", Responsible = "Аргейлов Феликс Бинович" });
            buildings.Add(new Building { Id = 3, Adress = "Москва, Пушкина, 3", Cadastral = "22:22:222222:22", Square = 100f, Date = DateTime.Now, Floors = 10, Material = "Кирпич", Responsible = "Черномечников Гатс Габинович" });
            solutions.Add(new Solution { Id = 1, Title = "Снос здания по адресу: Москва, Пушкина, 1", Date = DateTime.Now, Responsible = "Райдеров Астольф", Status = "Отклонено" });
            solutions.Add(new Solution { Id = 2, Title = "Ремонт здания по адресу: Москва, Пушкина, 2", Date = DateTime.Now, Responsible = "Соколов Гриффит", Status = "На рассмотрении" });
            solutions.Add(new Solution { Id = 3, Title = "Постройка нового здания: Москва, Пушкина, 3", Date = DateTime.Now, Responsible = "Дримурров Азриель Азгорович", Status = "Принято" });
            users.Add(new User { Id = 1, Email = "qwerty@qwerty.qwerty", Username = "qwertyAdmin", Password = "qwertyAdmin", Role = Role.Administrator });
            users.Add(new User { Id = 1, Email = "qwerty@qwerty.qwerty", Username = "qwertyWriter", Password = "qwertyWriter", Role = Role.Writer });
            users.Add(new User { Id = 1, Email = "qwerty@qwerty.qwerty", Username = "qwertyReader", Password = "qwertyReader", Role = Role.Reader });
        }
    }
}
