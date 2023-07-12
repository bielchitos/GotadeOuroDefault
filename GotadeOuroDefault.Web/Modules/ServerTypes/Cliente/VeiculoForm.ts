import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface VeiculoForm {
    Placa: StringEditor;
    Modelo: StringEditor;
    Marca: StringEditor;
    Ano: IntegerEditor;
}

export class VeiculoForm extends PrefixedContext {
    static formKey = 'Cliente.Veiculo';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!VeiculoForm.init)  {
            VeiculoForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(VeiculoForm, [
                'Placa', w0,
                'Modelo', w0,
                'Marca', w0,
                'Ano', w1
            ]);
        }
    }
}