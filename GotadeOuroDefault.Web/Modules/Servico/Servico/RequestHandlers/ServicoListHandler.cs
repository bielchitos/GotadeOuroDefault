using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GotadeOuroDefault.Servico.ServicoRow>;
using MyRow = GotadeOuroDefault.Servico.ServicoRow;

namespace GotadeOuroDefault.Servico;

public interface IServicoListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ServicoListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IServicoListHandler
{
    public ServicoListHandler(IRequestContext context)
            : base(context)
    {
    }
}