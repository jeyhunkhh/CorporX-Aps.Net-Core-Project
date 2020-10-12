using System.ComponentModel.DataAnnotations;

namespace CorporX.Models.Services
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(1000)]
        public string MessageText { get; set; }

    }
}
