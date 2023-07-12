using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GotadeOuroDefault.Funcionario.FuncionarioRow>;
using MyRow = GotadeOuroDefault.Funcionario.FuncionarioRow;

namespace GotadeOuroDefault.Funcionario;

public interface IFuncionarioRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class FuncionarioRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IFuncionarioRetrieveHandler
{
    public FuncionarioRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}