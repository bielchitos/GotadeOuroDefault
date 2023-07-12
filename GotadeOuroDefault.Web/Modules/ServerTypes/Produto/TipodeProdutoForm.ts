import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TipodeProdutoForm {
    Descricao: StringEditor;
}

export class TipodeProdutoForm extends PrefixedContext {
    static formKey = 'Produto.TipodeProduto';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TipodeProdutoForm.init)  {
            TipodeProdutoForm.init = true;

            var w0 = StringEditor;

            initFormType(TipodeProdutoForm, [
                'Descricao', w0
            ]);
        }
    }
}