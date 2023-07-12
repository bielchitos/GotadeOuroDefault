using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GotadeOuroDefault.Produto;

[ConnectionKey("Default"), Module("Produto"), TableName("Marca")]
[DisplayName("Marca"), InstanceName("Marca")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class MarcaRow : Row<MarcaRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id Marca"), Column("idMarca"), PrimaryKey, NotNull, IdProperty]
    public int? IdMarca
    {
        get => fields.IdMarca[this];
        set => fields.IdMarca[this] = value;
    }

    [DisplayName("Nome"), Size(100), QuickSearch, NameProperty]
    public string Nome
    {
        get => fields.Nome[this];
        set => fields.Nome[this] = value;
    }

    [DisplayName("Marca Nacional")]
    public bool? MarcaNacional
    {
        get => fields.MarcaNacional[this];
        set => fields.MarcaNacional[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdMarca;
        public StringField Nome;
        public BooleanField MarcaNacional;

    }
}