import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AgendamentoColumns, AgendamentoRow, AgendamentoService } from '../../ServerTypes/Agendamento';
import { AgendamentoDialog } from './AgendamentoDialog';

@Decorators.registerClass('GotadeOuroDefault.Agendamento.AgendamentoGrid')
export class AgendamentoGrid extends EntityGrid<AgendamentoRow, any> {
    protected getColumnsKey() { return AgendamentoColumns.columnsKey; }
    protected getDialogType() { return AgendamentoDialog; }
    protected getRowDefinition() { return AgendamentoRow; }
    protected getService() { return AgendamentoService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}