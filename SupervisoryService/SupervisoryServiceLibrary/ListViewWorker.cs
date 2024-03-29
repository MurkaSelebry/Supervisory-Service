﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SupervisoryServiceLibrary
{
    public class ListViewWorker
    {
        private bool isDescending = false;
        private static int idWidth = 50;
        private static int columns = 0;
        private static int width = 0;
        public static void Set(ListView listView, Table table)
        {
            listView.Items.Clear();
            listView.Columns.Clear();
            listView.Columns.Add("Ид", idWidth);
            switch (table)
            {
                //Building: Id, Adress, Cadastral, Square, Date, Material, Floors, Responsible
                case Table.Buildings:
                    {
                        columns = 8 - 1;//общее кол-во столбцов - восемь, вычитаем единицу, т.к. размер для столбца "Ид" фиксированный
                        width = (listView.Size.Width - idWidth) / columns;
                        listView.Columns.Add("Адрес", width);
                        listView.Columns.Add("Кадастровый номер", width);
                        listView.Columns.Add("Площадь, м2", width);
                        listView.Columns.Add("Дата постройки", width);
                        listView.Columns.Add("Материал", width);
                        listView.Columns.Add("Этажей", width);
                        listView.Columns.Add("Ответственный, ФИО", width);
                        
                            foreach (var item in Tables.buildings)
                            {
                                string[] strings = new string[] { item.Id.ToString(), item.Adress, item.Cadastral, item.Square.ToString(), item.Date.ToShortDateString(), item.Material, item.Floors.ToString(), item.Responsible };
                                listView.Items.Add(new ListViewItem(strings));
                              
                            }
                        SaveToXml("buildings.xml", Tables.buildings.ToArray());
                        
                        
                        break;
                    }
                //Solution: Id, Title, Date, Responsible, Status;
                //Description в карточку
                case Table.Solutions:
                    {
                        columns = 6 - 1 - 1; //общее кол-во столбцов - шесть, вычитаем единицу, т.к. размер для столбца "Ид" фиксированный, вычитаем единицу, т.к.
                        //Description в карточку;
                        width = (listView.Size.Width - idWidth) / columns;
                        listView.Columns.Add("Решение", width);
                        listView.Columns.Add("Дата", width);
                        listView.Columns.Add("Ответсвенный", width);
                        listView.Columns.Add("Статус", width);
                        foreach (var item in Tables.solutions)
                        {
                            string[] strings = new string[] { item.Id.ToString(), item.Title, item.Date.ToShortDateString(), item.Responsible, item.Status };
                            listView.Items.Add(new ListViewItem(strings));
                        }
                        SaveToXml("solutions.xml", Tables.solutions.ToArray());

                        break;
                    }
                //User: Id, Username, Password, Role, Email, Phone, Surname, Lastname, Patronymic
                //Password не отображается
                case Table.Users:
                    {
                        columns = 9 - 1 - 1; //общее кол-во столбцов - шесть, вычитаем единицу, т.к. размер для столбца "Ид" фиксированный, вычитаем единицу, т.к.
                        //Password не отображается;
                        width = (listView.Size.Width - idWidth) / columns;
                        listView.Columns.Add("Имя", width);
                        listView.Columns.Add("Роль", width);
                        listView.Columns.Add("Электронная почта", width);
                        listView.Columns.Add("Телефон", width);
                        listView.Columns.Add("Фамилия", width);
                        listView.Columns.Add("Имя", width);
                        listView.Columns.Add("Отчество", width);
                        foreach (var item in Tables.users)
                        {
                            string[] strings = new string[] { item.Id.ToString(), item.Username, item.Role.ToString(), item.Email, item.Phone, item.Surname, item.Name, item.Patronymic };
                            listView.Items.Add(new ListViewItem(strings));
                        }
                        SaveToXml("users.xml", Tables.users.ToArray());

                        break;
                    }
            }
        }
        public static void SaveToXml<T>(string myXmlFilePath, T[] table)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(T[]));

            using (FileStream stream = File.Create(myXmlFilePath))
            {
                serializer.Serialize(stream, table);
            }
        }
       
        public static void Set(ListView listView, Table table, object[] items)
        {
            listView.Items.Clear();
            listView.Columns.Clear();
            listView.Columns.Add("Ид", idWidth);
            switch (table)
            {
                //Building: Id, Adress, Cadastral, Square, Date, Material, Floors, Responsible
                case Table.Buildings:
                    {
                        columns = 8 - 1;//общее кол-во столбцов - восемь, вычитаем единицу, т.к. размер для столбца "Ид" фиксированный
                        width = (listView.Size.Width - idWidth) / columns;
                        listView.Columns.Add("Адрес", width);
                        listView.Columns.Add("Кадастровый номер", width);
                        listView.Columns.Add("Площадь, м2", width);
                        listView.Columns.Add("Дата постройки", width);
                        listView.Columns.Add("Материал", width);
                        listView.Columns.Add("Этажей", width);
                        listView.Columns.Add("Ответственный, ФИО", width);
                        foreach (Building item in items)
                        {
                            string[] strings = new string[] { item.Id.ToString(), item.Adress, item.Cadastral, item.Square.ToString(), item.Date.ToShortDateString(), item.Material, item.Floors.ToString(), item.Responsible };
                            listView.Items.Add(new ListViewItem(strings));
                        }
                        break;
                    }
                //Solution: Id, Title, Date, Responsible, Status;
                //Description в карточку
                case Table.Solutions:
                    {
                        columns = 6 - 1 - 1; //общее кол-во столбцов - шесть, вычитаем единицу, т.к. размер для столбца "Ид" фиксированный, вычитаем единицу, т.к.
                        //Description в карточку;
                        width = (listView.Size.Width - idWidth) / columns;
                        listView.Columns.Add("Решение", width);
                        listView.Columns.Add("Дата", width);
                        listView.Columns.Add("Ответсвенный", width);
                        listView.Columns.Add("Статус", width);
                        foreach (Solution item in items)
                        {
                            string[] strings = new string[] { item.Id.ToString(), item.Title, item.Date.ToShortDateString(), item.Responsible, item.Status };
                            listView.Items.Add(new ListViewItem(strings));
                        }
                        break;
                    }
                //User: Id, Username, Password, Role, Email, Phone, Surname, Lastname, Patronymic
                //Password не отображается
                case Table.Users:
                    {
                        columns = 9 - 1 - 1; //общее кол-во столбцов - шесть, вычитаем единицу, т.к. размер для столбца "Ид" фиксированный, вычитаем единицу, т.к.
                        //Password не отображается;
                        width = (listView.Size.Width - idWidth) / columns;
                        listView.Columns.Add("Имя", width);
                        listView.Columns.Add("Роль", width);
                        listView.Columns.Add("Электронная почта", width);
                        listView.Columns.Add("Телефон", width);
                        listView.Columns.Add("Фамилия", width);
                        listView.Columns.Add("Имя", width);
                        listView.Columns.Add("Отчество", width);
                        foreach (User item in Tables.users)
                        {
                            string[] strings = new string[] { item.Id.ToString(), item.Username, item.Role.ToString(), item.Email, item.Phone, item.Surname, item.Name, item.Patronymic };
                            listView.Items.Add(new ListViewItem(strings));
                        }
                        break;
                    }
            }
        }
        public static object[] Find(Table table, string wanted)
        {
            wanted = wanted.ToLower();
            List<object> results = new List<object>();
            switch (table)
            {
                case Table.Buildings:
                    {
                        foreach (var item in Tables.buildings)
                        {
                            if (item.Id.ToString().ToLower().Contains(wanted) || item.Adress.ToLower().Contains(wanted) || item.Cadastral.ToLower().Contains(wanted) || 
                                item.Date.ToString().ToLower().Contains(wanted) ||item.Floors.ToString().ToLower().Contains(wanted) || item.Material.ToLower().Contains(wanted) ||
                                item.Responsible.ToLower().Contains(wanted) || item.Square.ToString().ToLower().Contains(wanted) && !results.Contains(item))
                                results.Add(item);
                        }
                        break;
                    }
                case Table.Solutions:
                    {
                        foreach(var item in Tables.solutions)
                        {
                            if (item.Id.ToString().ToLower().Contains(wanted) || item.Title.ToLower().Contains(wanted) || item.Description.ToLower().Contains(wanted) ||
                               item.Status.ToLower().Contains(wanted) || item.Responsible.ToLower().Contains(wanted) ||
                               item.Date.ToString().ToLower().Contains(wanted) && !results.Contains(item))
                                results.Add(item);
                        }
                        break;
                    }
                case Table.Users:
                    {
                        foreach (var item in Tables.users)
                        {
                            if (item.Id.ToString().ToLower().Contains(wanted) || item.Username.ToLower().Contains(wanted) || item.Email.ToLower().Contains(wanted) ||
                               item.Phone.ToLower().Contains(wanted) || item.Surname.ToLower().Contains(wanted) || item.Name.ToLower().Contains(wanted) ||
                               item.Patronymic.ToLower().Contains(wanted) && !results.Contains(item))
                                results.Add(item);
                        }
                        break;
                    }
            }
            return results.ToArray();
        }
    }
}
