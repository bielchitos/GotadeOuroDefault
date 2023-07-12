using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GotadeOuroDefault.Cliente.ClienteRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GotadeOuroDefault.Cliente.ClienteRow;

namespace GotadeOuroDefault.Cliente;

public interface IClienteSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ClienteSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IClienteSaveHandler
{
    public ClienteSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}