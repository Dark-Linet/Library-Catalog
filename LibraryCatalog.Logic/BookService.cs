using System.Collections.Generic;
using System.ComponentModel;
using LibraryCatalog.Data;

namespace LibraryCatalog.Logic;

public class BookService
{
    private readonly BookRepository _repository = new();

    public List<Book> GetImportant()
    {
        return _repository.GetAll()
            .Where(item => item.Year < 2000)
            .ToList();
    }
}