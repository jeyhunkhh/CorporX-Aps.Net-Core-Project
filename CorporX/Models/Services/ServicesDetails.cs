using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models.Services
{
    public class ServicesDetails 
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string Text { get; set; }
        [Required]
        [MaxLength(500)]
        public string List { get; set; }
        [Required]
        [MaxLength(100)]
        public string ShowContent { get; set; }
        [Required]
        [MaxLength(100)]
        public string ShowIcon { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
