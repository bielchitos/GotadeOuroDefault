using Serenity.ComponentModel;
using System.ComponentModel;

namespace GotadeOuroDefault.Produto.Columns;

[ColumnsScript("Produto.Viscosidade")]
[BasedOnRow(typeof(ViscosidadeRow), CheckNames = true)]
public class ViscosidadeColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdViscosidade { get; set; }
    [EditLink]
    public string SiglaViscosidade { get; set; }
}