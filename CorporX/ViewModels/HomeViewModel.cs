using CorporX.Migrations;
using CorporX.Models;
using CorporX.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class HomeViewModel
    {
        public HomeAboutUs HomeAboutUs { get; set; }
        public HomeBlog HomeBlog { get; set; }
        public List<HomeBlogItem> HomeBlogItem { get; set; }
        public HomeCallToAction HomeCallToAction { get; set; }
        public HomeHeader HomeHeader { get; set; }
        public HomePortfolio HomePortfolio { get; set; }
        public List<HomePromo> HomePromo { get; set; }
        public HomeServices HomeServices { get; set; }
        public HomeTeam HomeTeam { get; set; }
        public HomeTestimonial HomeTestimonial { get; set; }
        public List<HomeTestimonialItem> HomeTestimonialItem { get; set; }

        public List<Models.Services.ServicesDetails> ServicesDetails { get; set; }
        public List<Models.Project.ProjectDetails> ProjectDetails { get; set; }
        public List<TeamItem> TeamItems { get; set; }

    }
}
