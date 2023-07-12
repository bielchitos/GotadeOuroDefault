import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { FuncionarioColumns, FuncionarioRow, FuncionarioService } from '../../ServerTypes/Funcionario';
import { FuncionarioDialog } from './FuncionarioDialog';

@Decorators.registerClass('GotadeOuroDefault.Funcionario.FuncionarioGrid')
export class FuncionarioGrid extends EntityGrid<FuncionarioRow, any> {
    protected getColumnsKey() { return FuncionarioColumns.columnsKey; }
    protected getDialogType() { return FuncionarioDialog; }
    protected getRowDefinition() { return FuncionarioRow; }
    protected getService() { return FuncionarioService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}