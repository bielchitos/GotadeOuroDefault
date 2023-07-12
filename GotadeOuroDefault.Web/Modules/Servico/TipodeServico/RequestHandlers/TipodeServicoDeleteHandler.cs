using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GotadeOuroDefault.Servico.TipodeServicoRow;

namespace GotadeOuroDefault.Servico;

public interface ITipodeServicoDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TipodeServicoDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITipodeServicoDeleteHandler
{
    public TipodeServicoDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}