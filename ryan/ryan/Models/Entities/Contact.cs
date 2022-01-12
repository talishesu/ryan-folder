using ryan.AppCode.Infrastructure;

namespace ryan.Models.Entities
{
    public class Contact : BaseEntities
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Freelance { get; set; }
    }
}
