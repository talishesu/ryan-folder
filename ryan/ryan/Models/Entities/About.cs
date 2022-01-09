using ryan.AppCode.Infrastructure;

namespace ryan.Models.Entities
{
    
    public class AboutMe :  BaseEntities
    {
        public string Info { get; set; }
        public int Age { get; set; }
        public string Residence { get; set; }
        public string Freelance { get; set; }
        public string Address { get; set; }
    }
    public class MyServices : BaseEntities
    {
        public string Head { get; set; }
        public string Title { get; set; }
    }
    public class Pricing : BaseEntities
    {
        public string Head { get; set; }
        public string Price { get; set; }
    }

    public class PricingAdvantages : BaseEntities
    {
        public int PricingId { get; set; }
        public string Title { get; set; }
        public bool New { get; set; }
    }

    public class FunFact : BaseEntities
    {
        public string Title { get; set; }
    }
    public class Clients : BaseEntities
    {
        public string ImagePath { get; set; }
    }

    public class Quote :  BaseEntities
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Job { get; set; }
        public string ImagePath { get; set; }

    }
}
