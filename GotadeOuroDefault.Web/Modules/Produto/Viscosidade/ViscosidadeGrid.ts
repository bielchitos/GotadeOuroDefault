import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ViscosidadeColumns, ViscosidadeRow, ViscosidadeService } from '../../ServerTypes/Produto';
import { ViscosidadeDialog } from './ViscosidadeDialog';

@Decorators.registerClass('GotadeOuroDefault.Produto.ViscosidadeGrid')
export class ViscosidadeGrid extends EntityGrid<ViscosidadeRow, any> {
    protected getColumnsKey() { return ViscosidadeColumns.columnsKey; }
    protected getDialogType() { return ViscosidadeDialog; }
    protected getRowDefinition() { return ViscosidadeRow; }
    protected getService() { return ViscosidadeService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}