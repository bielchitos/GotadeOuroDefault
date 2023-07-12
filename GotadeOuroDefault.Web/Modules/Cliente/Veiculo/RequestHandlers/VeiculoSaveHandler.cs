using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GotadeOuroDefault.Cliente.VeiculoRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GotadeOuroDefault.Cliente.VeiculoRow;

namespace GotadeOuroDefault.Cliente;

public interface IVeiculoSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class VeiculoSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IVeiculoSaveHandler
{
    public VeiculoSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}