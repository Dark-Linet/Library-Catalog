namespace LibraryCatalog.Data;

public class BookRepository
{
    private readonly List<Book> _items = new()
    {
        new Book { Id = 1, Title = "Мастер и Маргарита", Year = 1967},
        new Book { Id = 2, Title = "Властелин колец", Year = 1954},
        new Book { Id = 3, Title = "Голодные игры", Year = 2008},
        new Book { Id = 4, Title = "Дюна: Батлерианский джихад", Year = 2002},
    };

    public List<Book> GetAll()
    {
        return _items;
    }
}