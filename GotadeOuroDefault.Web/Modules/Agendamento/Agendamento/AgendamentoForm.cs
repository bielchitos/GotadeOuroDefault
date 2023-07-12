using Serenity.ComponentModel;
using System;

namespace GotadeOuroDefault.Agendamento.Forms;

[FormScript("Agendamento.Agendamento")]
[BasedOnRow(typeof(AgendamentoRow), CheckNames = true)]
public class AgendamentoForm
{
    public int ClienteId { get; set; }
    public int VeiculoId { get; set; }
    public int ServicoId { get; set; }
    public DateTime DataAgendamento { get; set; }
    public TimeSpan HoraAgendamento { get; set; }
    public int IdFuncionario { get; set; }
}