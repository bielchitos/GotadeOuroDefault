import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ViscosidadeForm, ViscosidadeRow, ViscosidadeService } from '../../ServerTypes/Produto';

@Decorators.registerClass('GotadeOuroDefault.Produto.ViscosidadeDialog')
export class ViscosidadeDialog extends EntityDialog<ViscosidadeRow, any> {
    protected getFormKey() { return ViscosidadeForm.formKey; }
    protected getRowDefinition() { return ViscosidadeRow; }
    protected getService() { return ViscosidadeService.baseUrl; }

    protected form = new ViscosidadeForm(this.idPrefix);
}