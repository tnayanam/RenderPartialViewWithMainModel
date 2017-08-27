using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Camera
    {
        [Key]
        public int Id { get; set; }
        public string CameraName { get; set; }


        // here phone ID need to be nullable
        // so looking at the fluent api youu are telling that phone id can also be null, becase its optional
        // but here an int is non nullable. so we need to add a "?". if we do not that we will get
        // error as WebApplication3.Models.Phone_Cameras: : Multiplicity conflicts with the referential 
        //constraint in Role 'Phone_Cameras_Source' in relationship 'Phone_Cameras'. Because all of the
        //properties in the Dependent Role are non-nullable, multiplicity of the Principal Role must be '1'.

        //public int? PhoneId { get; set; }
        //public virtual Phone Phone { get; set; }
    }
}