using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GotadeOuroDefault.Produto.ProdutoRow;

namespace GotadeOuroDefault.Produto;

public interface IProdutoDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ProdutoDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProdutoDeleteHandler
{
    public ProdutoDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}