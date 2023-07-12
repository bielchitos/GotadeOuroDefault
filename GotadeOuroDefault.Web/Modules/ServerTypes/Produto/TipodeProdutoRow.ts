import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TipodeProdutoRow {
    IdTipoProduto?: number;
    Descricao?: string;
}

export abstract class TipodeProdutoRow {
    static readonly idProperty = 'IdTipoProduto';
    static readonly nameProperty = 'Descricao';
    static readonly localTextPrefix = 'Produto.TipodeProduto';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TipodeProdutoRow>();
}