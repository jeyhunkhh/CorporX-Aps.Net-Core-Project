using CorporX.Models.FAQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class FAQViewModel
    {
        public List<FAQ> FAQs { get; set; }
        public List<PricingFAQ> PricingFAQs { get; set; }
        public BreadcrumbViewModel BreadcrumbViewModel { get; set; }

    }
}
