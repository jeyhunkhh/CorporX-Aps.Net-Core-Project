using CorporX.Models.About;
using CorporX.Models.AboutUs;
using CorporX.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.ViewModels
{
    public class AboutUsViewModel
    {
        public AboutUsTeam AboutUsTeam { get; set; }
        public List<TeamItem> TeamItems { get; set; }
        public AboutUsMission AboutUsMission { get; set; }
        public List<AboutUsPromo> AboutUsPromo { get; set; }
        public AboutUsSliderHeader AboutUsSliderHeader { get; set; }
        public AboutUsWorkProcess AboutUsWorkProcess { get; set; }
        public List<AboutUsWorkProcessItems> AboutUsWorkProcessItems { get; set; }
        public List<Client> Clients { get; set; }
        public List<SliderItems> SliderItems { get; set; }

    }
}
