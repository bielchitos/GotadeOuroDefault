import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ServicoColumns, ServicoRow, ServicoService } from '../../ServerTypes/Servico';
import { ServicoDialog } from './ServicoDialog';

@Decorators.registerClass('GotadeOuroDefault.Servico.ServicoGrid')
export class ServicoGrid extends EntityGrid<ServicoRow, any> {
    protected getColumnsKey() { return ServicoColumns.columnsKey; }
    protected getDialogType() { return ServicoDialog; }
    protected getRowDefinition() { return ServicoRow; }
    protected getService() { return ServicoService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}