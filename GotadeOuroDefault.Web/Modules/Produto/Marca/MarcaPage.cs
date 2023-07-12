using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GotadeOuroDefault.Produto.Pages;

[PageAuthorize(typeof(MarcaRow))]
public class MarcaPage : Controller
{
    [Route("Produto/Marca")]
    public ActionResult Index()
    {
        return this.GridPage("@/Produto/Marca/MarcaPage",
            MarcaRow.Fields.PageTitle());
    }
}