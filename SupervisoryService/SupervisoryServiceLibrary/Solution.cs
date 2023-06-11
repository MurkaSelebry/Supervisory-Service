using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SupervisoryServiceLibrary
{
    public class Solution
    {
        //Solution: Id, Title, Description, Date, Responsible, Status;
        public int Id { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        public string Responsible { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
