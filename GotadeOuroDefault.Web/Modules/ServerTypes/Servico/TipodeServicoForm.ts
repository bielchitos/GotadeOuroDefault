import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TipodeServicoForm {
    Nome: StringEditor;
}

export class TipodeServicoForm extends PrefixedContext {
    static formKey = 'Servico.TipodeServico';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TipodeServicoForm.init)  {
            TipodeServicoForm.init = true;

            var w0 = StringEditor;

            initFormType(TipodeServicoForm, [
                'Nome', w0
            ]);
        }
    }
}