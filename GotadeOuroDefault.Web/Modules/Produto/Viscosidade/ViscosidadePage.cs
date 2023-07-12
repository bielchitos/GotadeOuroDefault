using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GotadeOuroDefault.Produto.Pages;

[PageAuthorize(typeof(ViscosidadeRow))]
public class ViscosidadePage : Controller
{
    [Route("Produto/Viscosidade")]
    public ActionResult Index()
    {
        return this.GridPage("@/Produto/Viscosidade/ViscosidadePage",
            ViscosidadeRow.Fields.PageTitle());
    }
}