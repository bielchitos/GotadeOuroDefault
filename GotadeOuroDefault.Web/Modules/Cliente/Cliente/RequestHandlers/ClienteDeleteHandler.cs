using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GotadeOuroDefault.Cliente.ClienteRow;

namespace GotadeOuroDefault.Cliente;

public interface IClienteDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ClienteDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IClienteDeleteHandler
{
    public ClienteDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}