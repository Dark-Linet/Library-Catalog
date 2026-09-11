using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryCatalog.Logic;
using LibraryCatalog.Data;

namespace LibraryCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookRepository repository = new BookRepository();

            var service = new BookService(repository);

            Console.WriteLine("Отобранные записи: ");
            
            foreach (var item in service.GetImportant())
            {
                Console.WriteLine($"{item.Id}: {item.Title}");
            }
        }
    }
}
