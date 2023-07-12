using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GotadeOuroDefault.Produto.Pages;

[PageAuthorize(typeof(ProdutoRow))]
public class ProdutoPage : Controller
{
    [Route("Produto/Produto")]
    public ActionResult Index()
    {
        return this.GridPage("@/Produto/Produto/ProdutoPage",
            ProdutoRow.Fields.PageTitle());
    }
}