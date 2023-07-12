using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GotadeOuroDefault.Cliente.Pages;

[PageAuthorize(typeof(ClienteRow))]
public class ClientePage : Controller
{
    [Route("Cliente/Cliente")]
    public ActionResult Index()
    {
        return this.GridPage("@/Cliente/Cliente/ClientePage",
            ClienteRow.Fields.PageTitle());
    }
}