using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models.Home
{
    public class TeamItem
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Position { get; set; }

        [Required]
        [MaxLength(300)]
        public string Content { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Facebook { get; set; }

        [Required]
        [MaxLength(100)]
        public string Linkedin { get; set; }

        [Required]
        [MaxLength(100)]
        public string Dribbble { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
