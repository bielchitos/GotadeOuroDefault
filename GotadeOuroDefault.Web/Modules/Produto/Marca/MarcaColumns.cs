using Serenity.ComponentModel;
using System.ComponentModel;

namespace GotadeOuroDefault.Produto.Columns;

[ColumnsScript("Produto.Marca")]
[BasedOnRow(typeof(MarcaRow), CheckNames = true)]
public class MarcaColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdMarca { get; set; }
    [EditLink]
    public string Nome { get; set; }
    public bool MarcaNacional { get; set; }
}