using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVP2
{
    public class Model:IModel
    {
       public string BookName { get; set; }
       public string Author { get; set; }
       public string Genr { get; set; }
       public string Year { get; set; }
        public string Data {  get; set; }

        public void Save()
        {
            StreamWriter sw = new StreamWriter("Database.txt", true);
            sw.WriteLine($"{BookName} - {Author} - {Genr} - {Year}");
            sw.Close();
        }
        public string Load()
        {
            try
            {

                string[] lines = File.ReadAllLines("Database.txt", Encoding.UTF8);
                return string.Join(Environment.NewLine, lines);


            }
            catch (Exception)
            {

            }
            return Data;
        }
        public void Delete()
        {
            try
            {
                var lines = File.ReadAllLines("Database.txt", Encoding.UTF8).ToList();
                lines = lines.Where(line => !line.StartsWith(BookName + " -")).ToList();
                File.WriteAllLines("Database.txt", lines, Encoding.UTF8 );
            }
            catch (Exception)
            {

            }
        }
        public void CleanAll()
        {
            try
            {

                File.WriteAllText("Database.txt", "");
            }
            catch (Exception)
            {

            }
        }
        public string ShowFirstBook()
        {
            var books=File.ReadAllLines("Database.txt", Encoding.UTF8).ToArray();
            return books[0];
        }

    }
}
