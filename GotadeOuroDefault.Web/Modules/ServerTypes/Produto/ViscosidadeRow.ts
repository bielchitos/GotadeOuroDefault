import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ViscosidadeRow {
    IdViscosidade?: number;
    SiglaViscosidade?: string;
}

export abstract class ViscosidadeRow {
    static readonly idProperty = 'IdViscosidade';
    static readonly nameProperty = 'SiglaViscosidade';
    static readonly localTextPrefix = 'Produto.Viscosidade';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ViscosidadeRow>();
}