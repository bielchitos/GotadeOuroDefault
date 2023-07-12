using Serenity.ComponentModel;
using System.ComponentModel;

namespace GotadeOuroDefault.Cliente.Columns;

[ColumnsScript("Cliente.Cliente")]
[BasedOnRow(typeof(ClienteRow), CheckNames = true)]
public class ClienteColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdCliente { get; set; }
    [EditLink]
    public string Nome { get; set; }
    public string Rg { get; set; }
    public string Cpf { get; set; }
    public string Cnh { get; set; }
    public string OrgaoEmissor { get; set; }
    public string Telefone { get; set; }
    public string Estado { get; set; }
}