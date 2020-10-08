using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Areas.Control.Models
{
    public class Cloudinary
    {
        private readonly Account account;
        private readonly CloudinaryDotNet.Cloudinary cloudinary;
        private readonly IConfiguration _configuration;
        public Cloudinary(IConfiguration configuration)
        {
            _configuration = configuration;
            account = new Account
            (
               _configuration["Cloudinary:CloudName"],
               _configuration["Cloudinary:ApiKey"],
               _configuration["Cloudinary:ApiSecret"]
            );
            cloudinary = new CloudinaryDotNet.Cloudinary(account);
            
            
        }


        public static void Upload()
        {
        }

    }
}
