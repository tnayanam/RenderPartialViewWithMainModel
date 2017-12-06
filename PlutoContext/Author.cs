namespace PlutoContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Author
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Author()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}

/*
 * Repository Pattern: It works/mediates between the domain and data mapping layers, acting like an IN-MEMORY COLLECTION of domain objects 
 * Suppose we need to run same query again and again then we need to write that query in many controller actions, but if we use repository pattern then we can write the query at one place and
 * call it from there. thus minimizes duplicate query.
 * Entitiy Framework is a Persistance Framework
 * Different type of O/RM -> Object Relation Mapper
 * ADO.Net
 * LINQ to SQL
 * Entity Framework v1
 * nHibernate
 * Entity Framework v4
 * Using repository pattern, it decouples our application from persistence framework. so tomorrow if we want to use another framework instead of entity framework we will have to do minimal changes
 * Decouple the application from Entity Framework 
 * 
 * IRepository - put all the common data access methods here
 * Repository - put all the implementation here
 * ICourseRepository - put all the functions explicitly required by only that Course
 * IAuthorRepository - put all the functions explicitly required by only that Author
 * Now implement them as CourseRepository and AuthorRepository
 * And then we need to work on Unit of Work.
 * 
 */


