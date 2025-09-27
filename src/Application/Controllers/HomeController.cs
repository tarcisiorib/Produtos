using Application.ViewModels;
using System.Web.Mvc;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route("erro/{id:length(3,3)}")]
        public ActionResult Erro(int id)
        {
            var modelErro = new ErroViewModel();

            switch(id)
            {
                case 500:
                    modelErro.Mensagem = "Erro! Tente novamente ou contate nosso suporte.";
                    modelErro.Titulo = "Ocorreu um erro!";
                    modelErro.CodigoErro = id;
                    break;
                case 404:
                    modelErro.Mensagem = "O recurso que você tentou acessar não existe ou não foi encontrado!";
                    modelErro.Titulo = "Página não encontrada";
                    modelErro.CodigoErro = id;
                    break;
                case 403:
                    modelErro.Mensagem = "Você não tem permissão para fazer isso";
                    modelErro.Titulo = "Acesso negado";
                    modelErro.CodigoErro = id;
                    break;
                default:
                    return new HttpStatusCodeResult(500);
            }

            return View("Error", modelErro);
        }
    }
}