using System.Collections.Generic;

namespace LibraryCatalog.Logic;

public interface IBookRepository
{
    List<Book> GetAll();
    void Add(Book item);
}