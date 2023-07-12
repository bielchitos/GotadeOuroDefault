import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { VeiculoForm, VeiculoRow, VeiculoService } from '../../ServerTypes/Cliente';

@Decorators.registerClass('GotadeOuroDefault.Cliente.VeiculoDialog')
export class VeiculoDialog extends EntityDialog<VeiculoRow, any> {
    protected getFormKey() { return VeiculoForm.formKey; }
    protected getRowDefinition() { return VeiculoRow; }
    protected getService() { return VeiculoService.baseUrl; }

    protected form = new VeiculoForm(this.idPrefix);
}