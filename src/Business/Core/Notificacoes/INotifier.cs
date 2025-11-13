using System.Collections.Generic;

namespace Business.Core.Notificacoes
{
    public interface INotifier
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}
