using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models.Home
{
    public class HomeHeader : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Heading { get; set; }

        
        [MaxLength(100)]
        public string Photo { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }

    }
}
