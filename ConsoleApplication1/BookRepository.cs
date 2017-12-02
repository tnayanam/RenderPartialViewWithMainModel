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
// It is an Object Relational Mapper\

// total we have three types of workflows: database first, codefirst , model first (UWL based)


// table -> collection -> makes a Database. Now once databasew is done it needs to be accessed to outer world. that
// is taken care by MySQL (a server of MySQL DB) or SQL Server ( a server for T-SQL Databases)
// Now to access these databases we need some UI.
// MySQL WorkBench is client for MySQL Databases
// SSMS (SQL Server Management Studio) is the client for T-SQL DB.
// SQL is a language from which a language named MYSQL,Oracle came out

// Connection String. Once we host a database from SQL Server, we need to tell our application to access it
// that is done by connection string.
// It has the Database server IP,port, and then it has the Database name in that server, becasue that server might have many databases
// now also one datbase needs one user, so in connectio string we also need to tell the user name and passwoed for that databse.
// the inital catalog section of connection string talks about the database name.
