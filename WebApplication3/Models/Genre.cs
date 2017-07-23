using System;
using System.ComponentModel.DataAnnotations;
namespace WebApplication3.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime SongDate { get; set; }
    }
}

//LINK REFERRED: https://www.codeproject.com/Articles/1136464/Simplest-Way-to-Use-JQuery-Date-Picker-and-Date-Ti