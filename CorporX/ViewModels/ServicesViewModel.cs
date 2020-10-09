using System.Collections.Generic;
using CorporX.Models.AboutUs;
using CorporX.Models.Home;
using CorporX.Models.Services;

namespace CorporX.ViewModels
{
    public class ServicesViewModel
    {
        public List<ServicesDetails> ServicesDetails { get; set; }
        public List<Client> Clients { get; set; }
        public ServicesDetailsHeader ServicesDetailsHeaders { get; set; }
        public List<ServisPromo> ServisPromos { get; set; }
        public Message Message { get; set; }
        public Setting Settings { get; set; }

    }
}
