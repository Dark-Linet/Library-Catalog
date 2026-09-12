using LibraryCatalog.Logic;

namespace LibraryCatalog.Data;

public class BookRepository : IBookRepository
{
    private readonly List<Book> _items = new()
    {
        new() { Id = 1, Title = "Мастер и Маргарита", Year = 1967 },
        new() { Id = 2, Title = "Властелин колец", Year = 1954 },
        new() { Id = 3, Title = "Голодные игры", Year = 2008 },
        new() { Id = 4, Title = "Дюна: Батлерианский джихад", Year = 2002 }
    };

    public List<Book> GetAll() => _items;

    public void Add(Book item) => _items.Add(item);
}