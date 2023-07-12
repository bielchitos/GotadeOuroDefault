import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AgendamentoForm, AgendamentoRow, AgendamentoService } from '../../ServerTypes/Agendamento';

@Decorators.registerClass('GotadeOuroDefault.Agendamento.AgendamentoDialog')
export class AgendamentoDialog extends EntityDialog<AgendamentoRow, any> {
    protected getFormKey() { return AgendamentoForm.formKey; }
    protected getRowDefinition() { return AgendamentoRow; }
    protected getService() { return AgendamentoService.baseUrl; }

    protected form = new AgendamentoForm(this.idPrefix);
}