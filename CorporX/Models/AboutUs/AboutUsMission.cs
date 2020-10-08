using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models.AboutUs
{
    public class AboutUsMission : BaseEntity
    {
        [Required]
        public string List { get; set; }
    }
}
