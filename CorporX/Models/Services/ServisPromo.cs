using System.ComponentModel.DataAnnotations;

namespace CorporX.Models.Services
{
    public class ServisPromo : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Icon { get; set; }
    }
}
