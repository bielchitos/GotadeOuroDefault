using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GotadeOuroDefault.Cliente.VeiculoRow;

namespace GotadeOuroDefault.Cliente;

public interface IVeiculoDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class VeiculoDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IVeiculoDeleteHandler
{
    public VeiculoDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}