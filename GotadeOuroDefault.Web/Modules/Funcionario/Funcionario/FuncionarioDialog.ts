import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { FuncionarioForm, FuncionarioRow, FuncionarioService } from '../../ServerTypes/Funcionario';

@Decorators.registerClass('GotadeOuroDefault.Funcionario.FuncionarioDialog')
export class FuncionarioDialog extends EntityDialog<FuncionarioRow, any> {
    protected getFormKey() { return FuncionarioForm.formKey; }
    protected getRowDefinition() { return FuncionarioRow; }
    protected getService() { return FuncionarioService.baseUrl; }

    protected form = new FuncionarioForm(this.idPrefix);
}