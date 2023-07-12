using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GotadeOuroDefault.Servico;

[ConnectionKey("Default"), Module("Servico"), TableName("TipoServico")]
[DisplayName("Tipode Servico"), InstanceName("Tipode Servico")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class TipodeServicoRow : Row<TipodeServicoRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id Tipo Servico"), Column("idTipoServico"), PrimaryKey, NotNull, IdProperty]
    public int? IdTipoServico
    {
        get => fields.IdTipoServico[this];
        set => fields.IdTipoServico[this] = value;
    }

    [DisplayName("Nome"), Size(50), QuickSearch, NameProperty]
    public string Nome
    {
        get => fields.Nome[this];
        set => fields.Nome[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdTipoServico;
        public StringField Nome;

    }
}