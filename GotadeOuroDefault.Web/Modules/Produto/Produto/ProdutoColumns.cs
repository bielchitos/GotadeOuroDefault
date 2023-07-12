using Serenity.ComponentModel;
using System.ComponentModel;

namespace GotadeOuroDefault.Produto.Columns;

[ColumnsScript("Produto.Produto")]
[BasedOnRow(typeof(ProdutoRow), CheckNames = true)]
public class ProdutoColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdProduto { get; set; }
    public string TipoProdutoDescricao { get; set; }
    [EditLink]
    public string NomeProduto { get; set; }
    public string MarcaNome { get; set; }
    public string ViscosidadeSiglaViscosidade { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
}