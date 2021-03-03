using System;
namespace BookStore.Models
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)(Math.Ceiling((decimal)TotalNumItems / ItemsPerPage));
    }
}
