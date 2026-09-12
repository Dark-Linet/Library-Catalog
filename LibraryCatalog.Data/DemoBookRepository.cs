using LibraryCatalog.Logic;

namespace LibraryCatalog.Data;

public class DemoBookRepository : IBookRepository
{
    public List<Book> GetAll() => new()
    {
        new() { Id = 100, Title = "Демонстрационная книга", Year = 1990 }
    };

    public void Add(Book item)
    {
        // Демонстрационное хранилище доступно только для чтения
    }
}
