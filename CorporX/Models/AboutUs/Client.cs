﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporX.Models.AboutUs
{
    public class Client
    {
        public int Id { get; set; }
       
        [MaxLength(100)]
        public string Photo { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
