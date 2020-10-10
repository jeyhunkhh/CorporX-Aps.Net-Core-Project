using CorporX.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class BlogLeftViewModel
    {
        public List<BlogLeft> BlogLefts { get; set; }
        public BreadcrumbViewModel BreadcrumbViewModel { get; set; }

    }
}
