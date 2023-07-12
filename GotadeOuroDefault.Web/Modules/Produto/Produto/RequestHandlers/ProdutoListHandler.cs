using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GotadeOuroDefault.Produto.ProdutoRow>;
using MyRow = GotadeOuroDefault.Produto.ProdutoRow;

namespace GotadeOuroDefault.Produto;

public interface IProdutoListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ProdutoListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProdutoListHandler
{
    public ProdutoListHandler(IRequestContext context)
            : base(context)
    {
    }
}