using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GotadeOuroDefault.Cliente.VeiculoRow>;
using MyRow = GotadeOuroDefault.Cliente.VeiculoRow;

namespace GotadeOuroDefault.Cliente;

public interface IVeiculoListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class VeiculoListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IVeiculoListHandler
{
    public VeiculoListHandler(IRequestContext context)
            : base(context)
    {
    }
}