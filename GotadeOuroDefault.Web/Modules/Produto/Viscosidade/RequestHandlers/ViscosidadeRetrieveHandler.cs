using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GotadeOuroDefault.Produto.ViscosidadeRow>;
using MyRow = GotadeOuroDefault.Produto.ViscosidadeRow;

namespace GotadeOuroDefault.Produto;

public interface IViscosidadeRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ViscosidadeRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IViscosidadeRetrieveHandler
{
    public ViscosidadeRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}