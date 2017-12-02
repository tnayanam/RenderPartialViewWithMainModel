using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title ="title1", Price = 12.5f},
                new Book(){Title ="title2", Price = 14.5f},
                new Book(){Title ="title3", Price = 18f}
            };
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }
}


// What is entity famework:

// It is a framework that helps in Manaing Database connection
// Manual Mapping
// It is an Object Relational Mapper