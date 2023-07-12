using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GotadeOuroDefault.Servico.Pages;

[PageAuthorize(typeof(ServicoRow))]
public class ServicoPage : Controller
{
    [Route("Servico/Servico")]
    public ActionResult Index()
    {
        return this.GridPage("@/Servico/Servico/ServicoPage",
            ServicoRow.Fields.PageTitle());
    }
}