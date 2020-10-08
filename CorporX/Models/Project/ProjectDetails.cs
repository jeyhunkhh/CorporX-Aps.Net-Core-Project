using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models.Project
{
    public class ProjectDetails
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
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
        public string ShowHeading { get; set; }
        [Required]
        [MaxLength(50)]
        public string ShowCataroty { get; set; }

    }
}
