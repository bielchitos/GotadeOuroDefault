import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ClienteForm, ClienteRow, ClienteService } from '../../ServerTypes/Cliente';

@Decorators.registerClass('GotadeOuroDefault.Cliente.ClienteDialog')
export class ClienteDialog extends EntityDialog<ClienteRow, any> {
    protected getFormKey() { return ClienteForm.formKey; }
    protected getRowDefinition() { return ClienteRow; }
    protected getService() { return ClienteService.baseUrl; }

    protected form = new ClienteForm(this.idPrefix);
}