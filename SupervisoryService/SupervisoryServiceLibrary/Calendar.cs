using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SupervisoryServiceLibrary
{
    public partial class Calendar : Form
    {
        private List<DateTime> dates = new();
        //private List<DateTime> userDates = new();
        public Calendar()
        {
            InitializeComponent();
            foreach (var item in Tables.buildings)
                if (item.Date != null && !dates.Contains(item.Date))
                    dates.Add(item.Date);
            foreach (var item in Tables.solutions)
                if (item.Date != null && !dates.Contains(item.Date))
                    dates.Add(item.Date);
            //foreach(var item in Tables.users)
            monthCalendar1.BoldedDates = dates.ToArray();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Fill(monthCalendar1.SelectionStart);
        }
        private void Calendar_Load(object sender, EventArgs e)
        {
            Fill(monthCalendar1.TodayDate);
        }
        private void Fill(DateTime date)
        {
            var dateBuildings = Find(Table.Buildings, date);
            var dateSolutions = Find(Table.Solutions, date);
            foreach(var item in dateBuildings)
                labelBuildings.Text += item.ToString() + "\n";
            foreach (var item in dateSolutions)
                labelSolutions.Text += item.ToString() + "\n";
        }
        private object[] Find(Table table, DateTime date)
        {
            var items = new List<object>();
            if(table == Table.Buildings)
            {
                foreach(var item in Tables.buildings) 
                {
                    if(item.Date == date && !items.Contains(item))
                    {
                        items.Add(item);
                    }
                }
            }
            if(table == Table.Solutions)
            {
                foreach(var item in Tables.solutions)
                    if(item.Date == date && !items.Contains(item))
                    {
                        items.Add(item);
                    }
            }
            return items.ToArray();
        }
    }
}
