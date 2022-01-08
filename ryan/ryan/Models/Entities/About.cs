using ryan.AppCode.Infrastructure;

namespace ryan.Models.Entities
{
    public class About
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ImagePath { get; set; }
    }
    public class AboutMe
    {
        public string Info { get; set; }
        public int Age { get; set; }
        public string Residence { get; set; }
        public string Freelance { get; set; }
        public string Address { get; set; }
    }
    public class MyServices : HistoryWatch
    {
        public int Id { get; set; }
        public string Head { get; set; }
        public string Title { get; set; }
    }
    public class Pricing : HistoryWatch
    {
        public int Id { get; set; }
        public string Head { get; set; }
        public string Price { get; set; }
    }

    public class PricingAdvantages : HistoryWatch
    {
        public int Id { get; set; }
        public int PricingId { get; set; }
        public string Title { get; set; }
        public bool New { get; set; }
    }

    public class FunFact : HistoryWatch
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
    public class Clients : HistoryWatch
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
    }

    public class Quote
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Job { get; set; }
    }
}
