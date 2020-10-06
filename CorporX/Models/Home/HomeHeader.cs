﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Models.Home
{
    public class HomeHeader : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Heading { get; set; }

        [Required]
        [MaxLength(50)]
        public string Photo { get; set; }

    }
}