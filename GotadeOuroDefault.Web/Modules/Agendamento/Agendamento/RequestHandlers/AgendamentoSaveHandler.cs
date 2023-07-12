using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GotadeOuroDefault.Agendamento.AgendamentoRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GotadeOuroDefault.Agendamento.AgendamentoRow;

namespace GotadeOuroDefault.Agendamento;

public interface IAgendamentoSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class AgendamentoSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAgendamentoSaveHandler
{
    public AgendamentoSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}