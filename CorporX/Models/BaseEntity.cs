using System.ComponentModel.DataAnnotations;

namespace CorporX.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(300)]
        public string Content { get; set; }

    }
}
