import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TipodeServicoForm, TipodeServicoRow, TipodeServicoService } from '../../ServerTypes/Servico';

@Decorators.registerClass('GotadeOuroDefault.Servico.TipodeServicoDialog')
export class TipodeServicoDialog extends EntityDialog<TipodeServicoRow, any> {
    protected getFormKey() { return TipodeServicoForm.formKey; }
    protected getRowDefinition() { return TipodeServicoRow; }
    protected getService() { return TipodeServicoService.baseUrl; }

    protected form = new TipodeServicoForm(this.idPrefix);
}