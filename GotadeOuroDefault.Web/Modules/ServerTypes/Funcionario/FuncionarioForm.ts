import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface FuncionarioForm {
    Nome: StringEditor;
    Cargo: StringEditor;
}

export class FuncionarioForm extends PrefixedContext {
    static formKey = 'Funcionario.Funcionario';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!FuncionarioForm.init)  {
            FuncionarioForm.init = true;

            var w0 = StringEditor;

            initFormType(FuncionarioForm, [
                'Nome', w0,
                'Cargo', w0
            ]);
        }
    }
}