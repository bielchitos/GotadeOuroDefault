using Serenity.ComponentModel;

namespace GotadeOuroDefault.Servico.Forms;

[FormScript("Servico.TipodeServico")]
[BasedOnRow(typeof(TipodeServicoRow), CheckNames = true)]
public class TipodeServicoForm
{
    public string Nome { get; set; }
}