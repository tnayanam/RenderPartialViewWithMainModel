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
 * 
 * 
 */