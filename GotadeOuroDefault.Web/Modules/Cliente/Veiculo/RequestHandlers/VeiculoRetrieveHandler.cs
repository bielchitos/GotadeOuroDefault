using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GotadeOuroDefault.Cliente.VeiculoRow>;
using MyRow = GotadeOuroDefault.Cliente.VeiculoRow;

namespace GotadeOuroDefault.Cliente;

public interface IVeiculoRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class VeiculoRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IVeiculoRetrieveHandler
{
    public VeiculoRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}