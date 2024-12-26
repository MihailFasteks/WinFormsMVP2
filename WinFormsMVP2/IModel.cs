using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVP2
{
    public interface IModel
    {
        string BookName { get; set; }
        string Author { get; set; }
        string Genr { get; set; }
        string Year { get; set; }
        string Data {  get; set; }
        void Save();
        string Load();
        void Delete();
        void CleanAll();
        string ShowFirstBook();
    }
}
