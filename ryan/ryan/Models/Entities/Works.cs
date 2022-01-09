using ryan.AppCode.Infrastructure;

namespace ryan.Models.Entities
{
    public class Works : BaseEntities
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string ImagePath { get; set; }
        public string Head { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
