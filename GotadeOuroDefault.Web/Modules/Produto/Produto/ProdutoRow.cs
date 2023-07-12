using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GotadeOuroDefault.Produto;

[ConnectionKey("Default"), Module("Produto"), TableName("Produto")]
[DisplayName("Produto"), InstanceName("Produto")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class ProdutoRow : Row<ProdutoRow.RowFields>, IIdRow, INameRow
{
    const string jTipoProduto = nameof(jTipoProduto);
    const string jMarca = nameof(jMarca);
    const string jViscosidade = nameof(jViscosidade);

    [DisplayName("Id Produto"), Column("idProduto"), PrimaryKey, NotNull, IdProperty]
    public int? IdProduto
    {
        get => fields.IdProduto[this];
        set => fields.IdProduto[this] = value;
    }

    [DisplayName("Tipo Produto"), ForeignKey("TipoProduto", "idTipoProduto"), LeftJoin(jTipoProduto), TextualField(nameof(TipoProdutoDescricao))]
    public int? TipoProduto
    {
        get => fields.TipoProduto[this];
        set => fields.TipoProduto[this] = value;
    }

    [DisplayName("Nome Produto"), Size(100), QuickSearch, NameProperty]
    public string NomeProduto
    {
        get => fields.NomeProduto[this];
        set => fields.NomeProduto[this] = value;
    }

    [DisplayName("Marca"), ForeignKey("Marca", "idMarca"), LeftJoin(jMarca), TextualField(nameof(MarcaNome))]
    public int? Marca
    {
        get => fields.Marca[this];
        set => fields.Marca[this] = value;
    }

    [DisplayName("Viscosidade"), ForeignKey("Viscosidade", "idViscosidade"), LeftJoin(jViscosidade), TextualField(nameof(ViscosidadeSiglaViscosidade))]
    public int? Viscosidade
    {
        get => fields.Viscosidade[this];
        set => fields.Viscosidade[this] = value;
    }

    [DisplayName("Descricao"), Column("descricao"), Size(2147483647)]
    public string Descricao
    {
        get => fields.Descricao[this];
        set => fields.Descricao[this] = value;
    }

    [DisplayName("Preco"), Column("preco"), Size(10), Scale(2)]
    public decimal? Preco
    {
        get => fields.Preco[this];
        set => fields.Preco[this] = value;
    }

    [DisplayName("Tipo Produto Descricao"), Expression($"{jTipoProduto}.[descricao]")]
    public string TipoProdutoDescricao
    {
        get => fields.TipoProdutoDescricao[this];
        set => fields.TipoProdutoDescricao[this] = value;
    }

    [DisplayName("Marca Nome"), Expression($"{jMarca}.[Nome]")]
    public string MarcaNome
    {
        get => fields.MarcaNome[this];
        set => fields.MarcaNome[this] = value;
    }

    [DisplayName("Viscosidade Sigla Viscosidade"), Expression($"{jViscosidade}.[SiglaViscosidade]")]
    public string ViscosidadeSiglaViscosidade
    {
        get => fields.ViscosidadeSiglaViscosidade[this];
        set => fields.ViscosidadeSiglaViscosidade[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdProduto;
        public Int32Field TipoProduto;
        public StringField NomeProduto;
        public Int32Field Marca;
        public Int32Field Viscosidade;
        public StringField Descricao;
        public DecimalField Preco;

        public StringField TipoProdutoDescricao;
        public StringField MarcaNome;
        public StringField ViscosidadeSiglaViscosidade;
    }
}