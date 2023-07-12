using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GotadeOuroDefault.Agendamento.Pages;

[PageAuthorize(typeof(AgendamentoRow))]
public class AgendamentoPage : Controller
{
    [Route("Agendamento/Agendamento")]
    public ActionResult Index()
    {
        return this.GridPage("@/Agendamento/Agendamento/AgendamentoPage",
            AgendamentoRow.Fields.PageTitle());
    }
}