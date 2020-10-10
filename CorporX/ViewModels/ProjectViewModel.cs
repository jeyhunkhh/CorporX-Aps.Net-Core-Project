using System;
using System.Collections.Generic;
using CorporX.Models.Project;
using CorporX.Models.AboutUs;

namespace CorporX.ViewModels
{
    public class ProjectViewModel
    {
        public List<ProjectDetails> ProjectDetails { get; set; }
        public List<SliderItems> SliderItems { get; set; }
        public List<Client> Clients { get; set; }
        public List<Pricing> Pricings { get; set; }
        public List<PricingItem> PricingItems { get; set; }
        public BreadcrumbViewModel BreadcrumbViewModel { get; set; }

    }
}
