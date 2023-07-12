using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GotadeOuroDefault.Produto.ProdutoRow>;
using MyRow = GotadeOuroDefault.Produto.ProdutoRow;

namespace GotadeOuroDefault.Produto;

public interface IProdutoRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ProdutoRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProdutoRetrieveHandler
{
    public ProdutoRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}