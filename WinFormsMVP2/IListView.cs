using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVP2
{
    public interface IListView
    {
        string BookName { get; set; }
        string Author { get; set; }
        string Genr { get; set; }
        string Year { get; set; }
        string Data { get; set; }
        public event EventHandler<EventArgs> AddRemove;
    }
}
