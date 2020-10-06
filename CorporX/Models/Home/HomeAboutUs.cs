using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models.Home
{
    public class HomeAboutUs : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Text { get; set; }

        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }

    }
}
