using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoContext.EntityConfigurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            Property(t => t.Description)
            .IsRequired();

            HasMany(e => e.Tags)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("TagCourses").MapLeftKey("Course_Id"));
        }
    }
}

/*
 * LINQ to query objects
 * LINQ to query Datatables
 * LINQ to query DB
 */

/*
 * Difference between IQueryable and IEnummerable
 * IEnummerable is best to query data from in-memory collections like List,Array
 * While running the Query IEnummerable loads the entire Select query from server side and all the filter will be applied on client side.
 * IEnummerable does not support Lazy Loading
 * Supports deferred execution.
 * IQuereyable
 * It supports Lazy Loading
 * It is best to query data from Remote Services and Database as the queries along with its filters gets executed on server side
 * Suppots lazy loading hence good for Paging Scenario.
 * Supports deferred execution.
 * 
 * yahan pe ek point note karo.. deferred execution dono mein hia. par ja bhi execution ho rha hai query ka thne just where part will execute in the ser ver side in the Ienumrable
 * that is why we get more results from db and then all the filter are appliec on the code/client side.
 * lekin IQueryable pe kya hota hia ki DB query mein sara filter lag ke execute hota hai. isliye less data pull hota hai DB se. 
 * So in total we have 3 main SEPERATE TOPICS
 * 1. Deferred Execution -> Allowed by both
 * 2. Query Execution => Serve side at one in IEnumerable and filter in memory, but in IQueryable filters also gets done in DB(more efficient)
 * 3. Lazy Loading => Not supported by IEnummerable. Matlab chaining objects ka bhi data load ho jaata hai.
 */

/*
 * Three type of execution we have : Lazy Loading, Eager laoding, Explicit Loading
 * Lazy Loading
 */

//// Suppose one game can have many cricket

public class Game
{
    public int GameId { get; set; }
    public string GameName { get; set; }
    public virtual ICollection<Cricket> Crickets { get; set; } // Line 1
}

public class Cricket
{
    public int CricketId { get; set; }
    public string CricketName { get; set; }
    public int GameId { get; set; }
    public virtual Game Game { get; set; }
}

// suppose we run a query as 
// var game = _context.Games.Single(g=>g.Gameid);

// In this case the the corresponding cricket is not loaded. because of Line 1's virtual keyword.
// Kindly note that when we try to see the game in debugger we will still see the crickets associated with that game. its because VS debugger runs the query. and that is misleading.

