using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GotadeOuroDefault.Servico.Pages;

[PageAuthorize(typeof(TipodeServicoRow))]
public class TipodeServicoPage : Controller
{
    [Route("Servico/TipodeServico")]
    public ActionResult Index()
    {
        return this.GridPage("@/Servico/TipodeServico/TipodeServicoPage",
            TipodeServicoRow.Fields.PageTitle());
    }
}