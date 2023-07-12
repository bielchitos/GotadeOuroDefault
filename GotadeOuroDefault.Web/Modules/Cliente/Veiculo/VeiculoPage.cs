using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GotadeOuroDefault.Cliente.Pages;

[PageAuthorize(typeof(VeiculoRow))]
public class VeiculoPage : Controller
{
    [Route("Cliente/Veiculo")]
    public ActionResult Index()
    {
        return this.GridPage("@/Cliente/Veiculo/VeiculoPage",
            VeiculoRow.Fields.PageTitle());
    }
}