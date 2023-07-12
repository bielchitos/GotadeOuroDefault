import { fieldsProxy } from "@serenity-is/corelib/q";

export interface FuncionarioRow {
    IdFuncionario?: number;
    Nome?: string;
    Cargo?: string;
}

export abstract class FuncionarioRow {
    static readonly idProperty = 'IdFuncionario';
    static readonly nameProperty = 'Nome';
    static readonly localTextPrefix = 'Funcionario.Funcionario';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<FuncionarioRow>();
}