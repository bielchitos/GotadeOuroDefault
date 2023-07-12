using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GotadeOuroDefault.Produto;

[ConnectionKey("Default"), Module("Produto"), TableName("TipoProduto")]
[DisplayName("Tipode Produto"), InstanceName("Tipode Produto")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class TipodeProdutoRow : Row<TipodeProdutoRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id Tipo Produto"), Column("idTipoProduto"), PrimaryKey, NotNull, IdProperty]
    public int? IdTipoProduto
    {
        get => fields.IdTipoProduto[this];
        set => fields.IdTipoProduto[this] = value;
    }

    [DisplayName("Descricao"), Column("descricao"), Size(4000), QuickSearch, NameProperty]
    public string Descricao
    {
        get => fields.Descricao[this];
        set => fields.Descricao[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdTipoProduto;
        public StringField Descricao;

    }
}