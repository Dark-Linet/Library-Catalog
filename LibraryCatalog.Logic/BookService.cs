using System.Collections.Generic;
using System.Linq;

namespace LibraryCatalog.Logic;

public class BookService
{
    private readonly IBookRepository _repository;
    
    public BookService(IBookRepository repository) => _repository = repository;
    
    public List<Book> GetImportant() => _repository.GetAll()
        .Where(item => item.Year < 2000)
        .ToList();

    public void AddBook(string title, int year)
    {
        if (string.IsNullOrWhiteSpace(title)) return;

        int nextId = _repository.GetAll().Count + 1;

        _repository.Add(new Book
        {
            Id = nextId,
            Title = title,
            Year = year
        });
    }
   
    public Book? GetOldestBook()
    {
        var books = _repository.GetAll();
        return books.Count == 0 ? null : books.OrderBy(b => b.Year).First();
    }
}
