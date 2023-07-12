import { StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface MarcaForm {
    Nome: StringEditor;
    MarcaNacional: BooleanEditor;
}

export class MarcaForm extends PrefixedContext {
    static formKey = 'Produto.Marca';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!MarcaForm.init)  {
            MarcaForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;

            initFormType(MarcaForm, [
                'Nome', w0,
                'MarcaNacional', w1
            ]);
        }
    }
}