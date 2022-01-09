using ryan.AppCode.Infrastructure;

namespace ryan.Models.Entities
{
    public class  Experience : BaseEntities
    {
        public string ExperienceStart { get; set; }
        public string ExperienceEnd { get; set; }
        public string Where { get; set; }
        public string Title { get; set; }
        public string Job { get; set; }
    }
    public class  Education : BaseEntities
    {
        public string ExperienceStart { get; set; }
        public string ExperienceEnd { get; set; }
        public string Where { get; set; }
        public string Title { get; set; }
        public string Job { get; set; }
    }
    public class Design : BaseEntities
    {
        public string Name { get; set; }
        public int Percent { get; set; }
    }
    public class Languages : BaseEntities
    {
        public string Name { get; set; }
        public int Percent { get; set; }
    }
    public class Coding : BaseEntities
    {
        public string Name { get; set; }
        public int Percent { get; set; }
    }
    public class Knowledge : BaseEntities
    {
        public string Name { get; set; }
    }
    public class Testimonials : BaseEntities
    {
        public string Title { get; set; }
        public string FullName { get; set; }
        public string ImagePath { get; set; }
        public string Job { get; set; }
    }
}
