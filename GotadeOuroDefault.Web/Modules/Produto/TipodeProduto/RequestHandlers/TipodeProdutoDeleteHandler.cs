using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GotadeOuroDefault.Produto.TipodeProdutoRow;

namespace GotadeOuroDefault.Produto;

public interface ITipodeProdutoDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TipodeProdutoDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITipodeProdutoDeleteHandler
{
    public TipodeProdutoDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}