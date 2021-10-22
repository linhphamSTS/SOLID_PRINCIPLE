using System;

namespace SingleResponsibilityPrinciple
{
    internal class ErrorManager
    {
        public void LogError(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}, Stack Trace: {ex.StackTrace}");
        }
    }
}