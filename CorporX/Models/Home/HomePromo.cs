using System.ComponentModel.DataAnnotations;

namespace CorporX.Models.Home
{
    public class HomePromo : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Icon { get; set; }
    }
}
