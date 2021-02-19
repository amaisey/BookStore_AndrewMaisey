using System;
using System.Linq;

namespace BookStore.Models
{
    public class EFBoookRepository : IBookRepository
    {
        private BookDbContext _context;

        //constructor
        public EFBoookRepository(BookDbContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
