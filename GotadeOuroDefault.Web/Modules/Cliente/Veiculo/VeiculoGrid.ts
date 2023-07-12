import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { VeiculoColumns, VeiculoRow, VeiculoService } from '../../ServerTypes/Cliente';
import { VeiculoDialog } from './VeiculoDialog';

@Decorators.registerClass('GotadeOuroDefault.Cliente.VeiculoGrid')
export class VeiculoGrid extends EntityGrid<VeiculoRow, any> {
    protected getColumnsKey() { return VeiculoColumns.columnsKey; }
    protected getDialogType() { return VeiculoDialog; }
    protected getRowDefinition() { return VeiculoRow; }
    protected getService() { return VeiculoService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}