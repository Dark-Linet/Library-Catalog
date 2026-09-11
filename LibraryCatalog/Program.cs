using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryCatalog.Logic;
using LibraryCatalog.Data;
using System.IO;

namespace LibraryCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonPath = Path.Combine(AppContext.BaseDirectory, "books.json");

            IBookRepository repository = new JsonBookRepository(jsonPath);

            var service = new BookService(repository);

            Console.WriteLine("Введите название новой книги: ");
            string title = Console.ReadLine() ?? "";

            Console.WriteLine("Введите год издания: ");
            int.TryParse(Console.ReadLine(), out int year);

            service.AddBook(title, year);

            Console.WriteLine("\nОтобранные записи:");
            
            foreach (var item in service.GetImportant())
            {
                Console.WriteLine($"{item.Id}: {item.Title}");
            }
        }
    }
}
