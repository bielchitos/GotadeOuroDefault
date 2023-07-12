using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GotadeOuroDefault.Servico;

[ConnectionKey("Default"), Module("Servico"), TableName("Servico")]
[DisplayName("Servico"), InstanceName("Servico")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class ServicoRow : Row<ServicoRow.RowFields>, IIdRow, INameRow
{
    const string jTipoServico = nameof(jTipoServico);

    [DisplayName("Id Servico"), Column("idServico"), PrimaryKey, NotNull, IdProperty]
    public int? IdServico
    {
        get => fields.IdServico[this];
        set => fields.IdServico[this] = value;
    }

    [DisplayName("Tipo Servico"), ForeignKey("TipoServico", "idTipoServico"), LeftJoin(jTipoServico), TextualField(nameof(TipoServicoNome))]
    public int? TipoServico
    {
        get => fields.TipoServico[this];
        set => fields.TipoServico[this] = value;
    }

    [DisplayName("Descricao"), Column("descricao"), Size(4000), QuickSearch, NameProperty]
    public string Descricao
    {
        get => fields.Descricao[this];
        set => fields.Descricao[this] = value;
    }

    [DisplayName("Preco"), Column("preco"), Size(10), Scale(5)]
    public decimal? Preco
    {
        get => fields.Preco[this];
        set => fields.Preco[this] = value;
    }

    [DisplayName("Tipo Servico Nome"), Expression($"{jTipoServico}.[Nome]")]
    public string TipoServicoNome
    {
        get => fields.TipoServicoNome[this];
        set => fields.TipoServicoNome[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdServico;
        public Int32Field TipoServico;
        public StringField Descricao;
        public DecimalField Preco;

        public StringField TipoServicoNome;
    }
}