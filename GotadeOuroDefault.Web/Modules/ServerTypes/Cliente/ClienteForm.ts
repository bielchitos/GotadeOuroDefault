import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ClienteForm {
    Nome: StringEditor;
    Rg: StringEditor;
    Cpf: StringEditor;
    Cnh: StringEditor;
    OrgaoEmissor: StringEditor;
    Telefone: StringEditor;
    Estado: StringEditor;
}

export class ClienteForm extends PrefixedContext {
    static formKey = 'Cliente.Cliente';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ClienteForm.init)  {
            ClienteForm.init = true;

            var w0 = StringEditor;

            initFormType(ClienteForm, [
                'Nome', w0,
                'Rg', w0,
                'Cpf', w0,
                'Cnh', w0,
                'OrgaoEmissor', w0,
                'Telefone', w0,
                'Estado', w0
            ]);
        }
    }
}