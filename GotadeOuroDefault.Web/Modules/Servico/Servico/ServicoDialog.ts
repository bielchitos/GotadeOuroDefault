import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ServicoForm, ServicoRow, ServicoService } from '../../ServerTypes/Servico';

@Decorators.registerClass('GotadeOuroDefault.Servico.ServicoDialog')
export class ServicoDialog extends EntityDialog<ServicoRow, any> {
    protected getFormKey() { return ServicoForm.formKey; }
    protected getRowDefinition() { return ServicoRow; }
    protected getService() { return ServicoService.baseUrl; }

    protected form = new ServicoForm(this.idPrefix);
}