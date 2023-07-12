using Serenity.ComponentModel;
using System.ComponentModel;

namespace GotadeOuroDefault.Produto.Columns;

[ColumnsScript("Produto.TipodeProduto")]
[BasedOnRow(typeof(TipodeProdutoRow), CheckNames = true)]
public class TipodeProdutoColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdTipoProduto { get; set; }
    [EditLink]
    public string Descricao { get; set; }
}