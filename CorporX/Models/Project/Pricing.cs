using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models.Project
{
    public class Pricing
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }

    }
}
