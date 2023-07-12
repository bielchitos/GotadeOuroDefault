using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GotadeOuroDefault.Produto.Pages;

[PageAuthorize(typeof(TipodeProdutoRow))]
public class TipodeProdutoPage : Controller
{
    [Route("Produto/TipodeProduto")]
    public ActionResult Index()
    {
        return this.GridPage("@/Produto/TipodeProduto/TipodeProdutoPage",
            TipodeProdutoRow.Fields.PageTitle());
    }
}