using Serenity.ComponentModel;

namespace GotadeOuroDefault.Cliente.Forms;

[FormScript("Cliente.Cliente")]
[BasedOnRow(typeof(ClienteRow), CheckNames = true)]
public class ClienteForm
{
    public string Nome { get; set; }
    public string Rg { get; set; }
    public string Cpf { get; set; }
    public string Cnh { get; set; }
    public string OrgaoEmissor { get; set; }
    public string Telefone { get; set; }
    public string Estado { get; set; }
}