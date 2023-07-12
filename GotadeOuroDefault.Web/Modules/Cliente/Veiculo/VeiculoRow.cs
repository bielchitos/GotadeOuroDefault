using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace GotadeOuroDefault.Cliente;

[ConnectionKey("Default"), Module("Cliente"), TableName("Veiculo")]
[DisplayName("Veiculo"), InstanceName("Veiculo")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class VeiculoRow : Row<VeiculoRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id Veiculo"), Column("idVeiculo"), PrimaryKey, NotNull, IdProperty]
    public int? IdVeiculo
    {
        get => fields.IdVeiculo[this];
        set => fields.IdVeiculo[this] = value;
    }

    [DisplayName("Placa"), Column("placa"), Size(10), QuickSearch, NameProperty]
    public string Placa
    {
        get => fields.Placa[this];
        set => fields.Placa[this] = value;
    }

    [DisplayName("Modelo"), Column("modelo"), Size(255)]
    public string Modelo
    {
        get => fields.Modelo[this];
        set => fields.Modelo[this] = value;
    }

    [DisplayName("Marca"), Column("marca"), Size(60)]
    public string Marca
    {
        get => fields.Marca[this];
        set => fields.Marca[this] = value;
    }

    [DisplayName("Ano"), Column("ano")]
    public int? Ano
    {
        get => fields.Ano[this];
        set => fields.Ano[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdVeiculo;
        public StringField Placa;
        public StringField Modelo;
        public StringField Marca;
        public Int32Field Ano;

    }
}