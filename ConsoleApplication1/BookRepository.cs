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


//Server=localhost\MSSQLSERVER01;Database=master;Trusted_Connection=True;

// Above is the connection string that got generated when I installed the SQL Server.
// Now clearly it is giving us all the infrmation. 
/*
 * serverName : localhost\MSSQLSERVER01
 * actually in one system we can install many instances of the sql server. and they all can have their set of databases
 * so here it is telling that the sql server instance that I will be working on will be "MSSQLSERVER01
 * Also it is telling that the database name is Master (by default).
 * 
 * 
 * More: Now once we installed the SQL Server and then we installed the SSMS to interact with it. more like a client.
 * 
 * Now the client does not know which server it needs to connect to, again it knows it needs to get connected to SQL Server but it does not
 * know which SQL Server instance it needs to get connected to. Because we might have multiple instance of SQL Server running.
 * SO when we launch the SSMS it asks which instance of SQL Server you need to connect to.
 * in my case when I installed the SQL SERVER my instrance name was MSSQLSERVER01. so I need to provide the instrance name so that SSMS can now connect
 * to that server and start interacting.
 * 
 */
