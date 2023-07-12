using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GotadeOuroDefault.Produto.ViscosidadeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GotadeOuroDefault.Produto.ViscosidadeRow;

namespace GotadeOuroDefault.Produto;

public interface IViscosidadeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ViscosidadeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IViscosidadeSaveHandler
{
    public ViscosidadeSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}