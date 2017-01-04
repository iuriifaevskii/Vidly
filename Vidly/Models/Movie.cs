using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(253)]
        public string Name { get;set; }

        public Ganre Ganre { get; set; }
        
        [Display(Name = "Ganre")]
        [Required]
        public int GanreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }
         
    }
}