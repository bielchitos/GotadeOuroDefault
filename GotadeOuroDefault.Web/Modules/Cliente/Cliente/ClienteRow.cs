using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GotadeOuroDefault.Cliente;

[ConnectionKey("Default"), Module("Cliente"), TableName("Cliente")]
[DisplayName("Cliente"), InstanceName("Cliente")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class ClienteRow : Row<ClienteRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id Cliente"), Column("idCliente"), PrimaryKey, NotNull, IdProperty]
    public int? IdCliente
    {
        get => fields.IdCliente[this];
        set => fields.IdCliente[this] = value;
    }

    [DisplayName("Nome"), Column("nome"), Size(255), QuickSearch, NameProperty]
    public string Nome
    {
        get => fields.Nome[this];
        set => fields.Nome[this] = value;
    }

    [DisplayName("Rg"), Column("rg"), Size(20)]
    public string Rg
    {
        get => fields.Rg[this];
        set => fields.Rg[this] = value;
    }

    [DisplayName("Cpf"), Column("cpf"), Size(11)]
    public string Cpf
    {
        get => fields.Cpf[this];
        set => fields.Cpf[this] = value;
    }

    [DisplayName("Cnh"), Column("cnh"), Size(10)]
    public string Cnh
    {
        get => fields.Cnh[this];
        set => fields.Cnh[this] = value;
    }

    [DisplayName("Orgao Emissor"), Column("orgaoEmissor"), Size(10)]
    public string OrgaoEmissor
    {
        get => fields.OrgaoEmissor[this];
        set => fields.OrgaoEmissor[this] = value;
    }

    [DisplayName("Telefone"), Column("telefone"), Size(20)]
    public string Telefone
    {
        get => fields.Telefone[this];
        set => fields.Telefone[this] = value;
    }

    [DisplayName("Estado"), Column("estado"), Size(20)]
    public string Estado
    {
        get => fields.Estado[this];
        set => fields.Estado[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdCliente;
        public StringField Nome;
        public StringField Rg;
        public StringField Cpf;
        public StringField Cnh;
        public StringField OrgaoEmissor;
        public StringField Telefone;
        public StringField Estado;

    }
}