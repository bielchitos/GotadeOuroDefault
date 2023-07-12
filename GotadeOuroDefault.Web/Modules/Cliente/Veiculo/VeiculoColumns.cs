using Serenity.ComponentModel;
using System.ComponentModel;

namespace GotadeOuroDefault.Cliente.Columns;

[ColumnsScript("Cliente.Veiculo")]
[BasedOnRow(typeof(VeiculoRow), CheckNames = true)]
public class VeiculoColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdVeiculo { get; set; }
    [EditLink]
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public int Ano { get; set; }
}