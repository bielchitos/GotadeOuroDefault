import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ClienteColumns, ClienteRow, ClienteService } from '../../ServerTypes/Cliente';
import { ClienteDialog } from './ClienteDialog';

@Decorators.registerClass('GotadeOuroDefault.Cliente.ClienteGrid')
export class ClienteGrid extends EntityGrid<ClienteRow, any> {
    protected getColumnsKey() { return ClienteColumns.columnsKey; }
    protected getDialogType() { return ClienteDialog; }
    protected getRowDefinition() { return ClienteRow; }
    protected getService() { return ClienteService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}