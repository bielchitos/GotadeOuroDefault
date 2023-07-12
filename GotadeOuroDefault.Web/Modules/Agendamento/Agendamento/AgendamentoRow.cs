using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace GotadeOuroDefault.Agendamento;

[ConnectionKey("Default"), Module("Agendamento"), TableName("Agendamento")]
[DisplayName("Agendamento"), InstanceName("Agendamento")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class AgendamentoRow : Row<AgendamentoRow.RowFields>, IIdRow
{
    const string jCliente = nameof(jCliente);
    const string jVeiculo = nameof(jVeiculo);
    const string jServico = nameof(jServico);
    const string jIdFuncionario = nameof(jIdFuncionario);

    [DisplayName("Id Agendamento"), Column("idAgendamento"), PrimaryKey, NotNull, IdProperty]
    public int? IdAgendamento
    {
        get => fields.IdAgendamento[this];
        set => fields.IdAgendamento[this] = value;
    }

    [DisplayName("Cliente"), Column("cliente_id"), ForeignKey("Cliente", "idCliente"), LeftJoin(jCliente), TextualField(nameof(ClienteNome))]
    public int? ClienteId
    {
        get => fields.ClienteId[this];
        set => fields.ClienteId[this] = value;
    }

    [DisplayName("Veiculo"), Column("veiculo_id"), ForeignKey("Veiculo", "idVeiculo"), LeftJoin(jVeiculo), TextualField(nameof(VeiculoPlaca))]
    public int? VeiculoId
    {
        get => fields.VeiculoId[this];
        set => fields.VeiculoId[this] = value;
    }

    [DisplayName("Servico"), Column("servico_id"), ForeignKey("Servico", "idServico"), LeftJoin(jServico), TextualField(nameof(ServicoDescricao))]
    public int? ServicoId
    {
        get => fields.ServicoId[this];
        set => fields.ServicoId[this] = value;
    }

    [DisplayName("Data Agendamento"), Column("data_agendamento")]
    public DateTime? DataAgendamento
    {
        get => fields.DataAgendamento[this];
        set => fields.DataAgendamento[this] = value;
    }

    [DisplayName("Hora Agendamento"), Column("hora_agendamento")]
    public TimeSpan? HoraAgendamento
    {
        get => fields.HoraAgendamento[this];
        set => fields.HoraAgendamento[this] = value;
    }

    [DisplayName("Id Funcionario"), Column("idFuncionario"), ForeignKey("Funcionario", "idFuncionario"), LeftJoin(jIdFuncionario), TextualField(nameof(IdFuncionarioNome))]
    public int? IdFuncionario
    {
        get => fields.IdFuncionario[this];
        set => fields.IdFuncionario[this] = value;
    }

    [DisplayName("Cliente Nome"), Expression($"{jCliente}.[nome]")]
    public string ClienteNome
    {
        get => fields.ClienteNome[this];
        set => fields.ClienteNome[this] = value;
    }

    [DisplayName("Veiculo Placa"), Expression($"{jVeiculo}.[placa]")]
    public string VeiculoPlaca
    {
        get => fields.VeiculoPlaca[this];
        set => fields.VeiculoPlaca[this] = value;
    }

    [DisplayName("Servico Descricao"), Expression($"{jServico}.[descricao]")]
    public string ServicoDescricao
    {
        get => fields.ServicoDescricao[this];
        set => fields.ServicoDescricao[this] = value;
    }

    [DisplayName("Id Funcionario Nome"), Expression($"{jIdFuncionario}.[nome]")]
    public string IdFuncionarioNome
    {
        get => fields.IdFuncionarioNome[this];
        set => fields.IdFuncionarioNome[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdAgendamento;
        public Int32Field ClienteId;
        public Int32Field VeiculoId;
        public Int32Field ServicoId;
        public DateTimeField DataAgendamento;
        public TimeSpanField HoraAgendamento;
        public Int32Field IdFuncionario;

        public StringField ClienteNome;
        public StringField VeiculoPlaca;
        public StringField ServicoDescricao;
        public StringField IdFuncionarioNome;
    }
}