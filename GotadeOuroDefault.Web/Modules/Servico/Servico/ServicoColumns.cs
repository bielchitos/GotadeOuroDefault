using Serenity.ComponentModel;
using System.ComponentModel;

namespace GotadeOuroDefault.Servico.Columns;

[ColumnsScript("Servico.Servico")]
[BasedOnRow(typeof(ServicoRow), CheckNames = true)]
public class ServicoColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdServico { get; set; }
    public string TipoServicoNome { get; set; }
    [EditLink]
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
}