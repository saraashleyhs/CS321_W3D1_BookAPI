using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CS321_W3D1_BookAPI.Models
{
    public class Book
    {
        
        public int Id { get; set; }

        [Required]
        [MaxLength(250,ErrorMessage ="The maximum length of the title is 250 characters.")]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Category { get; set; }    
    }
}
