using System;

namespace SingleReponsibilityPrinciple
{
    internal class DiaryEntry
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }
    }
}