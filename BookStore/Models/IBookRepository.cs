using System;
using System.Linq;

namespace BookStore.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
