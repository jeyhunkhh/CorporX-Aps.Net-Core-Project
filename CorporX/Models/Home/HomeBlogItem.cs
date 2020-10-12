using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models.Home
{
    public class HomeBlogItem : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Heading { get; set; }

        [Required]
        [MaxLength(25)]
        public string Label { get; set; }

        
        [MaxLength(100)]
        public string Photo { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime AddDateTime { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
