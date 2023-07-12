using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GotadeOuroDefault.Produto.TipodeProdutoRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GotadeOuroDefault.Produto.TipodeProdutoRow;

namespace GotadeOuroDefault.Produto;

public interface ITipodeProdutoSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TipodeProdutoSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITipodeProdutoSaveHandler
{
    public TipodeProdutoSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}