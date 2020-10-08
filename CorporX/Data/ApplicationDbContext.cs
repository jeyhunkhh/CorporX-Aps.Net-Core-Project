using CorporX.Controllers;
using CorporX.Models;
using CorporX.Models.Home;
using CorporX.Models.Project;
using CorporX.Models.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<HomeAboutUs> HomeAboutUs { get; set; }
        public DbSet<HomeBlog> HomeBlog { get; set; }
        public DbSet<HomeBlogItem> HomeBlogItem { get; set; }
        public DbSet<HomeCallToAction> HomeCallToAction { get; set; }
        public DbSet<HomeHeader> HomeHeader { get; set; }
        public DbSet<HomePortfolio> HomePortfolio { get; set; }
        public DbSet<HomePromo> HomePromo { get; set; }
        public DbSet<HomeServices> HomeServices { get; set; }
        public DbSet<HomeTeam> HomeTeam { get; set; }
        public DbSet<TeamItem> TeamItems { get; set; }
        public DbSet<HomeTestimonial> HomeTestimonial { get; set; }
        public DbSet<HomeTestimonialItem> HomeTestimonialItem { get; set; }
        public DbSet<Setting> Setting { get; set; }

        public DbSet<ServicesDetails> ServicesDetail { get; set; }
        public DbSet<ProjectDetails> ProjectDetails { get; set; }

    }
}
