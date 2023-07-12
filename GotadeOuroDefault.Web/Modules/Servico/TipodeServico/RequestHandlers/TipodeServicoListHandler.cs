using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GotadeOuroDefault.Servico.TipodeServicoRow>;
using MyRow = GotadeOuroDefault.Servico.TipodeServicoRow;

namespace GotadeOuroDefault.Servico;

public interface ITipodeServicoListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TipodeServicoListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITipodeServicoListHandler
{
    public TipodeServicoListHandler(IRequestContext context)
            : base(context)
    {
    }
}