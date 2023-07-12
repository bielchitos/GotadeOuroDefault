using Serenity.ComponentModel;

namespace GotadeOuroDefault.Produto.Forms;

[FormScript("Produto.TipodeProduto")]
[BasedOnRow(typeof(TipodeProdutoRow), CheckNames = true)]
public class TipodeProdutoForm
{
    public string Descricao { get; set; }
}