using Serenity.ComponentModel;

namespace GotadeOuroDefault.Produto.Forms;

[FormScript("Produto.Produto")]
[BasedOnRow(typeof(ProdutoRow), CheckNames = true)]
public class ProdutoForm
{
    public int TipoProduto { get; set; }
    public string NomeProduto { get; set; }
    public int Marca { get; set; }
    public int Viscosidade { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
}