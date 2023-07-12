using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GotadeOuroDefault.Produto.ProdutoRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GotadeOuroDefault.Produto.ProdutoRow;

namespace GotadeOuroDefault.Produto;

public interface IProdutoSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ProdutoSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProdutoSaveHandler
{
    public ProdutoSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}