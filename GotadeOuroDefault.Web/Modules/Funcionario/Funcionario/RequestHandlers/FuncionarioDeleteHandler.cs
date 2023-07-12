using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GotadeOuroDefault.Funcionario.FuncionarioRow;

namespace GotadeOuroDefault.Funcionario;

public interface IFuncionarioDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class FuncionarioDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IFuncionarioDeleteHandler
{
    public FuncionarioDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}