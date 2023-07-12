using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GotadeOuroDefault.Produto.TipodeProdutoRow>;
using MyRow = GotadeOuroDefault.Produto.TipodeProdutoRow;

namespace GotadeOuroDefault.Produto;

public interface ITipodeProdutoListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TipodeProdutoListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITipodeProdutoListHandler
{
    public TipodeProdutoListHandler(IRequestContext context)
            : base(context)
    {
    }
}