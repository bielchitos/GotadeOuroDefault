using Serenity.ComponentModel;
using System.ComponentModel;

namespace GotadeOuroDefault.Funcionario.Columns;

[ColumnsScript("Funcionario.Funcionario")]
[BasedOnRow(typeof(FuncionarioRow), CheckNames = true)]
public class FuncionarioColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdFuncionario { get; set; }
    [EditLink]
    public string Nome { get; set; }
    public string Cargo { get; set; }
}