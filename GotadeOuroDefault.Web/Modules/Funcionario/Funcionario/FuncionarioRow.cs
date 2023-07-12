using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GotadeOuroDefault.Funcionario;

[ConnectionKey("Default"), Module("Funcionario"), TableName("Funcionario")]
[DisplayName("Funcionario"), InstanceName("Funcionario")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class FuncionarioRow : Row<FuncionarioRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id Funcionario"), Column("idFuncionario"), PrimaryKey, NotNull, IdProperty]
    public int? IdFuncionario
    {
        get => fields.IdFuncionario[this];
        set => fields.IdFuncionario[this] = value;
    }

    [DisplayName("Nome"), Column("nome"), Size(255), QuickSearch, NameProperty]
    public string Nome
    {
        get => fields.Nome[this];
        set => fields.Nome[this] = value;
    }

    [DisplayName("Cargo"), Column("cargo"), Size(100)]
    public string Cargo
    {
        get => fields.Cargo[this];
        set => fields.Cargo[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdFuncionario;
        public StringField Nome;
        public StringField Cargo;

    }
}