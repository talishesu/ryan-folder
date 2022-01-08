using System;

namespace ryan.AppCode.Infrastructure
{
    public class HistoryWatch : BaseEntities
    {
        public int? CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow.AddHours(4);

        public int? DeletedByUserId { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
