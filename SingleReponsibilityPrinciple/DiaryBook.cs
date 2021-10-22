using System.Collections.Generic;

namespace SingleReponsibilityPrinciple
{
    internal class DiaryBook
    {
        private List<DiaryEntry> diaryEntries = new List<DiaryEntry>();

        public List<DiaryEntry> GetDiaryBook()
        {
            return diaryEntries;
        }
    }
}