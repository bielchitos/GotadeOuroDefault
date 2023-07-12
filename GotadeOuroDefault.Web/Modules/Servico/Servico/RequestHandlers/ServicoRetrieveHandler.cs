using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GotadeOuroDefault.Servico.ServicoRow>;
using MyRow = GotadeOuroDefault.Servico.ServicoRow;

namespace GotadeOuroDefault.Servico;

public interface IServicoRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ServicoRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IServicoRetrieveHandler
{
    public ServicoRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}