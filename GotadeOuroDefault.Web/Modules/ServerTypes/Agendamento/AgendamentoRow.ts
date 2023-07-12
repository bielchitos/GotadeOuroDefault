import { fieldsProxy } from "@serenity-is/corelib/q";

export interface AgendamentoRow {
    IdAgendamento?: number;
    ClienteId?: number;
    VeiculoId?: number;
    ServicoId?: number;
    DataAgendamento?: string;
    HoraAgendamento?: string;
    IdFuncionario?: number;
    ClienteNome?: string;
    VeiculoPlaca?: string;
    ServicoDescricao?: string;
    IdFuncionarioNome?: string;
}

export abstract class AgendamentoRow {
    static readonly idProperty = 'IdAgendamento';
    static readonly localTextPrefix = 'Agendamento.Agendamento';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AgendamentoRow>();
}