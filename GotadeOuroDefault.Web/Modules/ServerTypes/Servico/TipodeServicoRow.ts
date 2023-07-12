import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TipodeServicoRow {
    IdTipoServico?: number;
    Nome?: string;
}

export abstract class TipodeServicoRow {
    static readonly idProperty = 'IdTipoServico';
    static readonly nameProperty = 'Nome';
    static readonly localTextPrefix = 'Servico.TipodeServico';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TipodeServicoRow>();
}