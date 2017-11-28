using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
