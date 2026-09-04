using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryCatalog.Logic;

namespace LibraryCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new BookService();

            Console.WriteLine("Отобранные записи: ");
            
            foreach (var item in service.GetImportant())
            {
                Console.WriteLine($"{item.Id}: {item.Title}");
            }
        }
    }
}
