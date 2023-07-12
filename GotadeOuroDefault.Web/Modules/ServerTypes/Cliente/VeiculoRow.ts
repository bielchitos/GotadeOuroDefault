import { fieldsProxy } from "@serenity-is/corelib/q";

export interface VeiculoRow {
    IdVeiculo?: number;
    Placa?: string;
    Modelo?: string;
    Marca?: string;
    Ano?: number;
}

export abstract class VeiculoRow {
    static readonly idProperty = 'IdVeiculo';
    static readonly nameProperty = 'Placa';
    static readonly localTextPrefix = 'Cliente.Veiculo';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<VeiculoRow>();
}