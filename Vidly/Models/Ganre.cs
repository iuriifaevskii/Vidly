using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Ganre
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(253)]
        public string Name { get; set; }
        

    }
}