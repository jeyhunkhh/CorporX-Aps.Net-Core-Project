using System.ComponentModel.DataAnnotations;

namespace CorporX.Models.Project
{
    public class PricingItem
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Offer { get; set; }

    }
}
