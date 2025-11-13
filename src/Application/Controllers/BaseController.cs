using Business.Core.Notificacoes;
using System.Web.Mvc;

namespace Application.Controllers
{
    public class BaseController : Controller
    {
        private readonly INotifier _notifyer;

        public BaseController(INotifier notifyer)
        {
            _notifyer = notifyer;
        }

        protected bool OperacaoValida()
        {
            if (!_notifyer.HasNotification())
                return true;

            var notifications = _notifyer.GetNotifications();
            notifications.ForEach(n => ViewData.ModelState.AddModelError(string.Empty, n.Message));
            return false;
        }
    }
}