using System.ComponentModel.DataAnnotations;

namespace CorporX.Models.AboutUs
{
    public class AboutUsPromo : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Icon { get; set; }
    }
}
