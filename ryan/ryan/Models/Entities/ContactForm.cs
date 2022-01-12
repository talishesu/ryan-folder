using ryan.AppCode.Infrastructure;

namespace ryan.Models.Entities
{
    public class ContactForm :BaseEntities
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

    }
}
