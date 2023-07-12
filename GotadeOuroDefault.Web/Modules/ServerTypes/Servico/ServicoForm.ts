import { IntegerEditor, StringEditor, DecimalEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ServicoForm {
    TipoServico: IntegerEditor;
    Descricao: StringEditor;
    Preco: DecimalEditor;
}

export class ServicoForm extends PrefixedContext {
    static formKey = 'Servico.Servico';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ServicoForm.init)  {
            ServicoForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DecimalEditor;

            initFormType(ServicoForm, [
                'TipoServico', w0,
                'Descricao', w1,
                'Preco', w2
            ]);
        }
    }
}