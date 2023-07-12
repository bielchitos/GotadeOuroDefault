import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ServicoRow {
    IdServico?: number;
    TipoServico?: number;
    Descricao?: string;
    Preco?: number;
    TipoServicoNome?: string;
}

export abstract class ServicoRow {
    static readonly idProperty = 'IdServico';
    static readonly nameProperty = 'Descricao';
    static readonly localTextPrefix = 'Servico.Servico';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ServicoRow>();
}