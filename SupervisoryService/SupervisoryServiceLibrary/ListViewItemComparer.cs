using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace SupervisoryServiceLibrary
{
    public class ListViewItemComparer: System.Collections.IComparer
    {
        private int column = 0;
        public ListViewItemComparer() { }
        public ListViewItemComparer(int column)
        {
            this.column = column;
        }
        public int Compare(object x, object y) => string.Compare(((ListViewItem)x).SubItems[column].Text, ((ListViewItem)y).SubItems[column].Text);
    }
}
