import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TipodeServicoColumns, TipodeServicoRow, TipodeServicoService } from '../../ServerTypes/Servico';
import { TipodeServicoDialog } from './TipodeServicoDialog';

@Decorators.registerClass('GotadeOuroDefault.Servico.TipodeServicoGrid')
export class TipodeServicoGrid extends EntityGrid<TipodeServicoRow, any> {
    protected getColumnsKey() { return TipodeServicoColumns.columnsKey; }
    protected getDialogType() { return TipodeServicoDialog; }
    protected getRowDefinition() { return TipodeServicoRow; }
    protected getService() { return TipodeServicoService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}