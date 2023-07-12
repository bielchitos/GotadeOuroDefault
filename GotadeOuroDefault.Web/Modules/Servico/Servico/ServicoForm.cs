using Serenity.ComponentModel;

namespace GotadeOuroDefault.Servico.Forms;

[FormScript("Servico.Servico")]
[BasedOnRow(typeof(ServicoRow), CheckNames = true)]
public class ServicoForm
{
    public int TipoServico { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
}