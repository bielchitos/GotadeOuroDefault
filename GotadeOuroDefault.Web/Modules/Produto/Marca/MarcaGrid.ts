import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { MarcaColumns, MarcaRow, MarcaService } from '../../ServerTypes/Produto';
import { MarcaDialog } from './MarcaDialog';

@Decorators.registerClass('GotadeOuroDefault.Produto.MarcaGrid')
export class MarcaGrid extends EntityGrid<MarcaRow, any> {
    protected getColumnsKey() { return MarcaColumns.columnsKey; }
    protected getDialogType() { return MarcaDialog; }
    protected getRowDefinition() { return MarcaRow; }
    protected getService() { return MarcaService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}