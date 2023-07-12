using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GotadeOuroDefault.Servico.ServicoRow;

namespace GotadeOuroDefault.Servico;

public interface IServicoDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ServicoDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IServicoDeleteHandler
{
    public ServicoDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}