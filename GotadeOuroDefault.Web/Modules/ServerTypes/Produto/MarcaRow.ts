import { fieldsProxy } from "@serenity-is/corelib/q";

export interface MarcaRow {
    IdMarca?: number;
    Nome?: string;
    MarcaNacional?: boolean;
}

export abstract class MarcaRow {
    static readonly idProperty = 'IdMarca';
    static readonly nameProperty = 'Nome';
    static readonly localTextPrefix = 'Produto.Marca';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<MarcaRow>();
}