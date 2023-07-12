using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GotadeOuroDefault.Agendamento.AgendamentoRow>;
using MyRow = GotadeOuroDefault.Agendamento.AgendamentoRow;

namespace GotadeOuroDefault.Agendamento;

public interface IAgendamentoRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class AgendamentoRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAgendamentoRetrieveHandler
{
    public AgendamentoRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}