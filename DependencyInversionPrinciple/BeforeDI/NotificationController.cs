using DependencyInversionPrinciple.BeforeDI.Notifications;

namespace DependencyInversionPrinciple.BeforeDI
{
    internal class NotificationController
    {
        private readonly EmailNotification _emailNotification;
        private readonly SmsNotification _smsNotification;
        private readonly PushNotification _pushNotification;

        public NotificationController()
        {
            _emailNotification = new EmailNotification();
            _smsNotification = new SmsNotification();
            _pushNotification = new PushNotification();
        }

        public void SendEmailNotification(NotificationItem notificationItem)
        {
            _emailNotification.Send(notificationItem);
        }

        public void SendSmsNotification(NotificationItem notificationItem)
        {
            _smsNotification.Send(notificationItem);
        }

        public void SendPushNotification(NotificationItem notificationItem)
        {
            _pushNotification.Send(notificationItem);
        }
    }
}