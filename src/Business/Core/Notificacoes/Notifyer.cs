using System.Collections.Generic;
using System.Linq;

namespace Business.Core.Notificacoes
{
    public class Notifyer : INotifyer
    {
        private List<Notification> _notifications;

        public Notifyer()
        {
            _notifications = new List<Notification>();
        }

        public List<Notification> GetNotifications()
        {
            return _notifications;
        }

        public void Handle(Notification notification)
        {
            _notifications.Add(notification);
        }

        public bool HasNotification()
        {
            return _notifications.Any();
        }
    }
}
