using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorApplication1.Models
{
    public class Book
    {
        [Key]

        public int Id { get; set; }
        [Required]
        [Display(Name="Book Name")]
        public string Name { get; set; }

        public string ISBN { get; set; }
        public int MyProperty { get; set; }
        public string  Author { get; set; }
    }
}
