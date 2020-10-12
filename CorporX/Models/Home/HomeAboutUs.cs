using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models.Home
{
    public class HomeAboutUs : BaseEntity
    {
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }

        
        [MaxLength(100)]
        public string Photo { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }

    }
}
