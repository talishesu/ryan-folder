using ryan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ryan.Models.ViewModels
{
    public class AboutViewModel
    {
        public List<MyServices> MyServices { get; set; }
        public List<Pricing> Pricing { get; set; }
        public List<PricingAdvantages> PricingAdvantages { get; set; }
        public List<FunFact> FunFact { get; set; }
        public List<Clients> Clients { get; set; }
        public Quote Quote { get; set; }
        public AboutMe AboutMe { get; set; }
        public About About { get; set; }
    }
}
