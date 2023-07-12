import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TipodeProdutoColumns, TipodeProdutoRow, TipodeProdutoService } from '../../ServerTypes/Produto';
import { TipodeProdutoDialog } from './TipodeProdutoDialog';

@Decorators.registerClass('GotadeOuroDefault.Produto.TipodeProdutoGrid')
export class TipodeProdutoGrid extends EntityGrid<TipodeProdutoRow, any> {
    protected getColumnsKey() { return TipodeProdutoColumns.columnsKey; }
    protected getDialogType() { return TipodeProdutoDialog; }
    protected getRowDefinition() { return TipodeProdutoRow; }
    protected getService() { return TipodeProdutoService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}