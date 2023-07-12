using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GotadeOuroDefault.Produto.MarcaRow>;
using MyRow = GotadeOuroDefault.Produto.MarcaRow;

namespace GotadeOuroDefault.Produto;

public interface IMarcaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class MarcaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMarcaRetrieveHandler
{
    public MarcaRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}