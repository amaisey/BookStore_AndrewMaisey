using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please Enter a Book Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter an Author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please Enter the Publisher")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Please Enter a Book Title")]
        [RegularExpression(@"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$", ErrorMessage = "Please Enter a Valid ISBN Number")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Please Enter Categories")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please Enter a Book Price")]
        public decimal Price { get; set; }
    }
}
