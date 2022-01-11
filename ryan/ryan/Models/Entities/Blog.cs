using ryan.AppCode.Infrastructure;

namespace ryan.Models.Entities
{
    public class Blog : BaseEntities
    {
        public string ImagePath { get; set; }
        public string Head { get; set; }
        public string Title { get; set; }
    }
}
