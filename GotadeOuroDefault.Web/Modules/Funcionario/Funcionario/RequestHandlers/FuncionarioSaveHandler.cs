using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GotadeOuroDefault.Funcionario.FuncionarioRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GotadeOuroDefault.Funcionario.FuncionarioRow;

namespace GotadeOuroDefault.Funcionario;

public interface IFuncionarioSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class FuncionarioSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IFuncionarioSaveHandler
{
    public FuncionarioSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}