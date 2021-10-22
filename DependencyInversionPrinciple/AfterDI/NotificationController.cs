using DependencyInversionPrinciple.AfterDI.Interfaces;
using DependencyInversionPrinciple.AfterDI.Notifications;
using System.Collections.Generic;

namespace DependencyInversionPrinciple.AfterDI
{
    internal class NotificationController
    {
        private readonly List<IMessenger<NotificationItem>> _notificationMessengers;

        public NotificationController()
        {
            _notificationMessengers = NotificationFactory.CreateMessengers();
        }

        public NotificationController(List<IMessenger<NotificationItem>> messengers)
        {
            _notificationMessengers = messengers;
        }

        public void AddToQueue(List<NotificationItem> messageitems)
        {
            foreach (var message in messageitems)
            {
                foreach (var messenger in _notificationMessengers)
                {
                    messenger.AddMessage(message);
                }
            }
        }

        public void Send()
        {
            foreach (var messenger in _notificationMessengers)
            {
                messenger.Send();
            }
        }
    }
}