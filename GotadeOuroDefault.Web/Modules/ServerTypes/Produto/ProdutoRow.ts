import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ProdutoRow {
    IdProduto?: number;
    TipoProduto?: number;
    NomeProduto?: string;
    Marca?: number;
    Viscosidade?: number;
    Descricao?: string;
    Preco?: number;
    TipoProdutoDescricao?: string;
    MarcaNome?: string;
    ViscosidadeSiglaViscosidade?: string;
}

export abstract class ProdutoRow {
    static readonly idProperty = 'IdProduto';
    static readonly nameProperty = 'NomeProduto';
    static readonly localTextPrefix = 'Produto.Produto';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ProdutoRow>();
}