using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GotadeOuroDefault.Produto.ViscosidadeRow;

namespace GotadeOuroDefault.Produto;

public interface IViscosidadeDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ViscosidadeDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IViscosidadeDeleteHandler
{
    public ViscosidadeDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}