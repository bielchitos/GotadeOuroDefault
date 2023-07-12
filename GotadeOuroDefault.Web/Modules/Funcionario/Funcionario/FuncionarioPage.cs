using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GotadeOuroDefault.Funcionario.Pages;

[PageAuthorize(typeof(FuncionarioRow))]
public class FuncionarioPage : Controller
{
    [Route("Funcionario/Funcionario")]
    public ActionResult Index()
    {
        return this.GridPage("@/Funcionario/Funcionario/FuncionarioPage",
            FuncionarioRow.Fields.PageTitle());
    }
}