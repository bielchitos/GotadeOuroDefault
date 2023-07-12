using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GotadeOuroDefault.Produto.TipodeProdutoRow>;
using MyRow = GotadeOuroDefault.Produto.TipodeProdutoRow;

namespace GotadeOuroDefault.Produto;

public interface ITipodeProdutoRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TipodeProdutoRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITipodeProdutoRetrieveHandler
{
    public TipodeProdutoRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}