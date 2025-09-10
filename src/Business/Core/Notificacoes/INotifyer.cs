using System.Collections.Generic;

namespace Business.Core.Notificacoes
{
    public interface INotifyer
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}
