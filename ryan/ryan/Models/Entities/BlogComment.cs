using ryan.AppCode.Infrastructure;

namespace ryan.Models.Entities
{
    public class BlogComment : BaseEntities
    {
        public int BlogId { get; set; }
        public string Comment { get; set; }
        public string FullName { get; set; }
    }
}
