using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GotadeOuroDefault.Produto.ViscosidadeRow>;
using MyRow = GotadeOuroDefault.Produto.ViscosidadeRow;

namespace GotadeOuroDefault.Produto;

public interface IViscosidadeListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ViscosidadeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IViscosidadeListHandler
{
    public ViscosidadeListHandler(IRequestContext context)
            : base(context)
    {
    }
}