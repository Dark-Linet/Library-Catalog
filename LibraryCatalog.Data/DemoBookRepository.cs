using System.Collections.Generic;
using LibraryCatalog.Logic;

namespace LibraryCatalog.Data;

public class DemoBookRepository : IBookRepository
{
    public List<Book> GetAll()
        {
        return new List<Book>
        {
            new Book { Id = 100, Title = "Демонстрационная книга", Year = 1990}
        };
    }
}