using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GotadeOuroDefault.Produto.MarcaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GotadeOuroDefault.Produto.MarcaRow;

namespace GotadeOuroDefault.Produto;

public interface IMarcaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class MarcaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMarcaSaveHandler
{
    public MarcaSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}