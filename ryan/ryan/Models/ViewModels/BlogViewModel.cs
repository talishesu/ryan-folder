using ryan.Models.Entities;
using System.Collections.Generic;

namespace ryan.Models.ViewModels
{
    public class BlogViewModel
    {
        public List<BlogComment> BlogComment { get; set; }
        public BlogComment SimpleComment { get; set; }
        public Blog Blog { get; set; }
    }
}
