using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervisoryServiceLibrary
{
    internal class SolutionFilter : IFilter
    {
        public DateTime MinDate { get; set; } = DateTime.MinValue;
        public DateTime MaxDate { get; set; } = DateTime.MaxValue;
        public string Status { get; set; } = string.Empty;
        public SolutionFilter() { }
        public SolutionFilter(DateTime minDate, DateTime maxDate, string status)
        {
            MinDate = minDate;
            MaxDate = maxDate;
            Status = status;
        }

        public object[] Find(object[] items)
        {
            List<Solution> results = new List<Solution>();
            foreach (object item in items)
            {
                if (item is Solution)
                {
                    var s = (Solution)item;
                    if (!string.IsNullOrEmpty(Status))
                    {
                        if ((MinDate <= s.Date && s.Date <= MaxDate) && s.Status.Equals(Status))
                            results.Add(s);
                    }
                    else
                    {
                        if (MinDate <= s.Date && s.Date <= MaxDate)
                            results.Add(s);
                    }
                }
            }
            return results.ToArray();
        }
    }
}
