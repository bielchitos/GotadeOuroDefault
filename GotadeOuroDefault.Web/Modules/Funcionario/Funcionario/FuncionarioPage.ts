import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { FuncionarioGrid } from './FuncionarioGrid';

export default function pageInit() {
    initFullHeightGridPage(new FuncionarioGrid($('#GridDiv')).element);
}