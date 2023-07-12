import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ViscosidadeForm {
    SiglaViscosidade: StringEditor;
}

export class ViscosidadeForm extends PrefixedContext {
    static formKey = 'Produto.Viscosidade';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ViscosidadeForm.init)  {
            ViscosidadeForm.init = true;

            var w0 = StringEditor;

            initFormType(ViscosidadeForm, [
                'SiglaViscosidade', w0
            ]);
        }
    }
}