import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ProdutoForm, ProdutoRow, ProdutoService } from '../../ServerTypes/Produto';

@Decorators.registerClass('GotadeOuroDefault.Produto.ProdutoDialog')
export class ProdutoDialog extends EntityDialog<ProdutoRow, any> {
    protected getFormKey() { return ProdutoForm.formKey; }
    protected getRowDefinition() { return ProdutoRow; }
    protected getService() { return ProdutoService.baseUrl; }

    protected form = new ProdutoForm(this.idPrefix);
}