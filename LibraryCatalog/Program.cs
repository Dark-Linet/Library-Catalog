using System;
using System.IO;
using LibraryCatalog.Logic;
using LibraryCatalog.Data;

namespace LibraryCatalog;

internal class Program
{
    static void Main(string[] args)
    {
        string jsonPath = Path.Combine(AppContext.BaseDirectory, "books.json");
        string xmlPath = Path.Combine(AppContext.BaseDirectory, "books.xml");
       
        string kind = args.Length > 0 ? args[0] : "json";
        
        IBookRepository repository = kind switch
        {
            "xml" => new XmlBookRepository(xmlPath),
            "memory" => new BookRepository(),
            "demo" => new DemoBookRepository(),
            _ => new JsonBookRepository(jsonPath)
        };

        Console.WriteLine($"Выбранный тип хранилища: {kind}\n");

        var service = new BookService(repository);

        Console.WriteLine("Введите название новой книги: ");
        string title = Console.ReadLine() ?? "";

        Console.WriteLine("Введите год издания: ");
        int.TryParse(Console.ReadLine(), out int year);

        service.AddBook(title, year);

        Console.WriteLine("\nОтобранные записи (до 2000 года):");
        foreach (var item in service.GetImportant())
        {
            Console.WriteLine($"{item.Id}: {item.Title} ({item.Year})");
        }
       
        Console.WriteLine("\nСамая старая книга в каталоге:");
        Book? oldestBook = service.GetOldestBook();
        if (oldestBook != null)
        {
            Console.WriteLine($"\"{oldestBook.Title}\", изданная в {oldestBook.Year} году.");
        }
        else
        {
            Console.WriteLine("Каталог пуст.");
        }
    }
}
