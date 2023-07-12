using Serenity.ComponentModel;

namespace GotadeOuroDefault.Funcionario.Forms;

[FormScript("Funcionario.Funcionario")]
[BasedOnRow(typeof(FuncionarioRow), CheckNames = true)]
public class FuncionarioForm
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
}