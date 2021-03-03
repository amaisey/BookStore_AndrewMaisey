using System;
using System.Collections.Generic;

namespace BookStore.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string Type { get; set; }
    }
}
