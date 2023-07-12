using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GotadeOuroDefault.Agendamento.AgendamentoRow;

namespace GotadeOuroDefault.Agendamento;

public interface IAgendamentoDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class AgendamentoDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAgendamentoDeleteHandler
{
    public AgendamentoDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}