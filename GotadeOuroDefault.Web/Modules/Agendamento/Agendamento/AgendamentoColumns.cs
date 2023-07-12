using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GotadeOuroDefault.Agendamento.Columns;

[ColumnsScript("Agendamento.Agendamento")]
[BasedOnRow(typeof(AgendamentoRow), CheckNames = true)]
public class AgendamentoColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdAgendamento { get; set; }
    public string ClienteNome { get; set; }
    public string VeiculoPlaca { get; set; }
    public string ServicoDescricao { get; set; }
    public DateTime DataAgendamento { get; set; }
    public TimeSpan HoraAgendamento { get; set; }
    public string IdFuncionarioNome { get; set; }
}