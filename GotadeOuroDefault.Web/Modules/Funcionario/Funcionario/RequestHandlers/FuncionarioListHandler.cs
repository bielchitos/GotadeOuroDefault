using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GotadeOuroDefault.Funcionario.FuncionarioRow>;
using MyRow = GotadeOuroDefault.Funcionario.FuncionarioRow;

namespace GotadeOuroDefault.Funcionario;

public interface IFuncionarioListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class FuncionarioListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IFuncionarioListHandler
{
    public FuncionarioListHandler(IRequestContext context)
            : base(context)
    {
    }
}