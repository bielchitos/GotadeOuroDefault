using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GotadeOuroDefault.Produto.MarcaRow>;
using MyRow = GotadeOuroDefault.Produto.MarcaRow;

namespace GotadeOuroDefault.Produto;

public interface IMarcaListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class MarcaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMarcaListHandler
{
    public MarcaListHandler(IRequestContext context)
            : base(context)
    {
    }
}