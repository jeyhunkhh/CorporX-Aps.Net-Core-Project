using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models.Home
{
    public class HomePromo : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Icon { get; set; }

    }
}
