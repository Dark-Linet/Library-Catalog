using System.Collections.Generic;
using System.ComponentModel;

namespace LibraryCatalog.Logic;

public class BookService
{
    private readonly IBookRepository _repository;

    public BookService(IBookRepository repository)
    {
        _repository = repository;
    }

    public List<Book> GetImportant()
    {
        return _repository.GetAll()
            .Where(item => item.Year < 2000)
            .ToList();
    }
}