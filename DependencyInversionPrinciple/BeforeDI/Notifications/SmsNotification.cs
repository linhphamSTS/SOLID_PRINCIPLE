using System;

namespace DependencyInversionPrinciple.BeforeDI.Notifications
{
    internal class SmsNotification
    {
        public void Send(NotificationItem notificationItem)
        {
            Console.WriteLine("Sms Notification");
            Console.WriteLine($"\t\tId: {notificationItem.Id}");
            Console.WriteLine($"\t\tTitle: {notificationItem.Title}");
            Console.WriteLine($"\t\tSent Date: {notificationItem.SentDate}");
            Console.WriteLine($"\t\tContent: {notificationItem.Content}");
            Console.WriteLine(" ");
        }
    }
}