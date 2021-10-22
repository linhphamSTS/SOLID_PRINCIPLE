using DependencyInversionPrinciple.AfterDI.Interfaces;
using System.Collections.Generic;

namespace DependencyInversionPrinciple.AfterDI.Notifications
{
    internal static class NotificationFactory
    {
        public static List<IMessenger<NotificationItem>> CreateMessengers()
        {
            var messengers = new List<IMessenger<NotificationItem>>
            {
                new EmailNotification(),
                new SmsNotification(),
                new PushNotification()
            };
            return messengers;
        }
    }
}