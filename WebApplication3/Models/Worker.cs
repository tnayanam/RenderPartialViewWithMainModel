using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Worker
    {
        [Key]
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }

        // I need to make mangerid FK nullable. because bydefalt managerid is interger and 
        // and integer is non nullable by default
        // so in fluent api code I am telling that MangerID is optional, but here i am telling that its
        // manadatory,

        // so I will get error as 

        //WebApplication3.Models.Manager_Workers: : Multiplicity conflicts with the re
        //ferential constraint in Role 'Manager_Workers_Source' in relationship 'Manager_Workers'.
        //Because all of the properties in the Dependent 
        //Role are non-nullable, multiplicity of the Principal Role must be '1'

        // so to fix it add "?"
        public int? ManagerId { get; set; }
        public Manager Manager { get; set; }
    }
}