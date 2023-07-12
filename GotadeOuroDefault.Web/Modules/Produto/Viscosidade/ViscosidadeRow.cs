using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GotadeOuroDefault.Produto;

[ConnectionKey("Default"), Module("Produto"), TableName("Viscosidade")]
[DisplayName("Viscosidade"), InstanceName("Viscosidade")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class ViscosidadeRow : Row<ViscosidadeRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id Viscosidade"), Column("idViscosidade"), PrimaryKey, NotNull, IdProperty]
    public int? IdViscosidade
    {
        get => fields.IdViscosidade[this];
        set => fields.IdViscosidade[this] = value;
    }

    [DisplayName("Sigla Viscosidade"), Size(100), QuickSearch, NameProperty]
    public string SiglaViscosidade
    {
        get => fields.SiglaViscosidade[this];
        set => fields.SiglaViscosidade[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdViscosidade;
        public StringField SiglaViscosidade;

    }
}