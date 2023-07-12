using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GotadeOuroDefault.Servico.TipodeServicoRow>;
using MyRow = GotadeOuroDefault.Servico.TipodeServicoRow;

namespace GotadeOuroDefault.Servico;

public interface ITipodeServicoRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TipodeServicoRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITipodeServicoRetrieveHandler
{
    public TipodeServicoRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}