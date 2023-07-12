using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GotadeOuroDefault.Servico.TipodeServicoRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GotadeOuroDefault.Servico.TipodeServicoRow;

namespace GotadeOuroDefault.Servico;

public interface ITipodeServicoSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TipodeServicoSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITipodeServicoSaveHandler
{
    public TipodeServicoSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}