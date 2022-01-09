using ryan.Models.Entities;
using System.Collections.Generic;

namespace ryan.Models.ViewModels
{
    public class ResumeViewModel
    {
        public List<Experience> Experience { get; set; }
        public List<Education> Education { get; set; }
        public List<Design> Design { get; set; }
        public List<Languages> Languages { get; set; }
        public List<Coding> Coding { get; set; }
        public List<Knowledge> Knowledge { get; set; }
        public List<Testimonials> Testimonials { get; set; }
    }
}
