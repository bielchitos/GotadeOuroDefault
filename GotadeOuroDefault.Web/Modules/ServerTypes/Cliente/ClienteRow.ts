import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ClienteRow {
    IdCliente?: number;
    Nome?: string;
    Rg?: string;
    Cpf?: string;
    Cnh?: string;
    OrgaoEmissor?: string;
    Telefone?: string;
    Estado?: string;
}

export abstract class ClienteRow {
    static readonly idProperty = 'IdCliente';
    static readonly nameProperty = 'Nome';
    static readonly localTextPrefix = 'Cliente.Cliente';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ClienteRow>();
}