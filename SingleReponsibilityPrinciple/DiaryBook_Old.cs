using SingleReponsibilityPrinciple;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    class DiaryBook_Old
    {
        private readonly List<DiaryEntry> diaryEntries = new List<DiaryEntry>();

        public List<DiaryEntry> GetDiaryBook()
        {
            return diaryEntries;
        }

        public void AddDiary(DiaryEntry diaryEntry, List<DiaryEntry> diaryEntries)
        {
            try
            {
                diaryEntries.Add(diaryEntry);
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        public void RemoveDiary(DiaryEntry diaryEntry, List<DiaryEntry> diaryEntries)
        {
            try
            {
                diaryEntries.Remove(diaryEntry);
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        public void SaveToText(string fileName, List<DiaryEntry> diaryEntries)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(fileName))
                {
                    foreach (var s in diaryEntries)
                    {
                        tw.WriteLine($"Date: {s.CreatedDate:dd/MM/yyyy}");
                        tw.WriteLine($"Title: {s.Title}");
                        tw.WriteLine($"Content: {s.Content}");

                        if (diaryEntries.IndexOf(s) != diaryEntries.Count - 1)
                        {
                            tw.WriteLine(Environment.NewLine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        public void LogError(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}, Stack Trace: {ex.StackTrace}");
        }
    }
}
