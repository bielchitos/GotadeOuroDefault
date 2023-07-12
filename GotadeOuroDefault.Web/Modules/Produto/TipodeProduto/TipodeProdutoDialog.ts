import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TipodeProdutoForm, TipodeProdutoRow, TipodeProdutoService } from '../../ServerTypes/Produto';

@Decorators.registerClass('GotadeOuroDefault.Produto.TipodeProdutoDialog')
export class TipodeProdutoDialog extends EntityDialog<TipodeProdutoRow, any> {
    protected getFormKey() { return TipodeProdutoForm.formKey; }
    protected getRowDefinition() { return TipodeProdutoRow; }
    protected getService() { return TipodeProdutoService.baseUrl; }

    protected form = new TipodeProdutoForm(this.idPrefix);
}