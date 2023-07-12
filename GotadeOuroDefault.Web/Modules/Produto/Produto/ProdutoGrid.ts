import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProdutoColumns, ProdutoRow, ProdutoService } from '../../ServerTypes/Produto';
import { ProdutoDialog } from './ProdutoDialog';

@Decorators.registerClass('GotadeOuroDefault.Produto.ProdutoGrid')
export class ProdutoGrid extends EntityGrid<ProdutoRow, any> {
    protected getColumnsKey() { return ProdutoColumns.columnsKey; }
    protected getDialogType() { return ProdutoDialog; }
    protected getRowDefinition() { return ProdutoRow; }
    protected getService() { return ProdutoService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}