using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GotadeOuroDefault.Agendamento.AgendamentoRow>;
using MyRow = GotadeOuroDefault.Agendamento.AgendamentoRow;

namespace GotadeOuroDefault.Agendamento;

public interface IAgendamentoListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class AgendamentoListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAgendamentoListHandler
{
    public AgendamentoListHandler(IRequestContext context)
            : base(context)
    {
    }
}