using Serenity.ComponentModel;
using System.ComponentModel;

namespace GotadeOuroDefault.Servico.Columns;

[ColumnsScript("Servico.TipodeServico")]
[BasedOnRow(typeof(TipodeServicoRow), CheckNames = true)]
public class TipodeServicoColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdTipoServico { get; set; }
    [EditLink]
    public string Nome { get; set; }
}