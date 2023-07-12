using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GotadeOuroDefault.Cliente.ClienteRow>;
using MyRow = GotadeOuroDefault.Cliente.ClienteRow;

namespace GotadeOuroDefault.Cliente;

public interface IClienteListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ClienteListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IClienteListHandler
{
    public ClienteListHandler(IRequestContext context)
            : base(context)
    {
    }
}