using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GotadeOuroDefault.Servico.ServicoRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GotadeOuroDefault.Servico.ServicoRow;

namespace GotadeOuroDefault.Servico;

public interface IServicoSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ServicoSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IServicoSaveHandler
{
    public ServicoSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}