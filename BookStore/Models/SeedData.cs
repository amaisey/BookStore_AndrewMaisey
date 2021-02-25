using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    //Book 1
                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Category = "Fiction, Classic",
                        Price = 9.95m,
                        NumPages = 1488
                    },

                    //Book 2
                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Category = "Non-Fiction, Biography",
                        Price = 14.58m,
                        NumPages = 944
                    },

                    //Book 3
                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Category = "Non-Fiction, Biography",
                        Price = 21.54m,
                        NumPages = 832
                    },

                    //Book 4
                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Category = "Non-Fiction, Biography",
                        Price = 11.61m,
                        NumPages = 864
                    },

                    //Book 5
                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Category = "Non-Fiction, Historical",
                        Price = 13.33m,
                        NumPages = 528
                    },

                    //Book 6
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Category = "Fiction, Historical Fiction",
                        Price = 15.95m,
                        NumPages = 288
                    },

                    //Book 7
                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Category = "Non-Fiction, Self-Help",
                        Price = 14.99m,
                        NumPages = 304
                    },

                    //Book 8
                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Category = "Non-Fiction, Self-Help",
                        Price = 21.66m,
                        NumPages = 240
                    },

                    //Book 9
                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Category = "Non-Fiction, Business",
                        Price = 29.16m,
                        NumPages = 400
                    },

                    //Book 10
                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Category = "Fiction, Thrillers",
                        Price = 15.03m,
                        NumPages = 642
                    },

                    //Book 11
                    new Book
                    {
                        Title = "The Book of Mormon",
                        Author = "Mormon",
                        Publisher = "The Church of Jesus Christ of Latter-Day Saints",
                        ISBN = "978-1420950380",
                        Category = "Religious Text",
                        Price = 1.99m,
                        NumPages = 238
                    },

                    //Book 12
                    new Book
                    {
                        Title = "The Ice Climber",
                        Author = "Richard Ransom",
                        Publisher = "Bantam",
                        ISBN = "978-1595467984",
                        Category = "Non-Fiction, Business",
                        Price = 42.56m,
                        NumPages = 50
                    },

                    //Book 13
                    new Book
                    {
                        Title = "The Last Hoorah",
                        Author = "Andrew Kingsly",
                        Publisher = "Richardsons",
                        ISBN = "978-0553458233",
                        Category = "Fiction, Thrillers",
                        Price = 19.98m,
                        NumPages = 364
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
