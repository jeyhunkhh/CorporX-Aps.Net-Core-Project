using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models.Blog
{
    public class BlogLeft : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }

    }
}
