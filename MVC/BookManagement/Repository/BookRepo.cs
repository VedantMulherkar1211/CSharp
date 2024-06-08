using System.Collections.Generic;
using Entities;  // Assuming that the 'Entities' namespace contains the 'Book' class

namespace Repository
{
    public static class BookRepo
    {
        public static List<Book> AllBooks = new List<Book>()
        {
            new Book { Id = 1, Title = "Let us C", Author = "Vedant", Price = 500.00f, Publication = "DPD", BookType = 'E' },
            new Book { Id = 2, Title = "Let us Java", Author = "Javahar lal", Price = 520.00f, Publication = "javaki", BookType = 'P' },
            new Book { Id = 3, Title = "Let us CPP", Author = "Manmohan Singh", Price = 800.00f, Publication = "DP sharma", BookType = 'E' },
            new Book { Id = 4, Title = "Let us C#", Author = "Narendra Modi", Price = 100.00f, Publication = "RD Sharma", BookType = 'E' }
        };
    }
}
