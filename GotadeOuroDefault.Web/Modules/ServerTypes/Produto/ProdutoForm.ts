import { IntegerEditor, StringEditor, DecimalEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ProdutoForm {
    TipoProduto: IntegerEditor;
    NomeProduto: StringEditor;
    Marca: IntegerEditor;
    Viscosidade: IntegerEditor;
    Descricao: StringEditor;
    Preco: DecimalEditor;
}

export class ProdutoForm extends PrefixedContext {
    static formKey = 'Produto.Produto';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProdutoForm.init)  {
            ProdutoForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DecimalEditor;

            initFormType(ProdutoForm, [
                'TipoProduto', w0,
                'NomeProduto', w1,
                'Marca', w0,
                'Viscosidade', w0,
                'Descricao', w1,
                'Preco', w2
            ]);
        }
    }
}