using CorporX.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class BlogViewModel
    {
        public List<HomeBlogItem> HomeBlogItems { get; set; }
        public BreadcrumbViewModel BreadcrumbViewModel { get; set; }
    }
}
