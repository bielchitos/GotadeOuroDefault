using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GotadeOuroDefault.Produto.MarcaRow;

namespace GotadeOuroDefault.Produto;

public interface IMarcaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class MarcaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMarcaDeleteHandler
{
    public MarcaDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}