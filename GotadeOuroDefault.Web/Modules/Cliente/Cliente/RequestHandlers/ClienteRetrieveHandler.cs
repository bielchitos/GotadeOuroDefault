using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GotadeOuroDefault.Cliente.ClienteRow>;
using MyRow = GotadeOuroDefault.Cliente.ClienteRow;

namespace GotadeOuroDefault.Cliente;

public interface IClienteRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ClienteRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IClienteRetrieveHandler
{
    public ClienteRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}