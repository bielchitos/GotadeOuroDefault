import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { MarcaForm, MarcaRow, MarcaService } from '../../ServerTypes/Produto';

@Decorators.registerClass('GotadeOuroDefault.Produto.MarcaDialog')
export class MarcaDialog extends EntityDialog<MarcaRow, any> {
    protected getFormKey() { return MarcaForm.formKey; }
    protected getRowDefinition() { return MarcaRow; }
    protected getService() { return MarcaService.baseUrl; }

    protected form = new MarcaForm(this.idPrefix);
}