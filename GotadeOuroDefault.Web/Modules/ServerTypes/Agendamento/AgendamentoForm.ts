import { IntegerEditor, DateEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AgendamentoForm {
    ClienteId: IntegerEditor;
    VeiculoId: IntegerEditor;
    ServicoId: IntegerEditor;
    DataAgendamento: DateEditor;
    HoraAgendamento: StringEditor;
    IdFuncionario: IntegerEditor;
}

export class AgendamentoForm extends PrefixedContext {
    static formKey = 'Agendamento.Agendamento';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AgendamentoForm.init)  {
            AgendamentoForm.init = true;

            var w0 = IntegerEditor;
            var w1 = DateEditor;
            var w2 = StringEditor;

            initFormType(AgendamentoForm, [
                'ClienteId', w0,
                'VeiculoId', w0,
                'ServicoId', w0,
                'DataAgendamento', w1,
                'HoraAgendamento', w2,
                'IdFuncionario', w0
            ]);
        }
    }
}