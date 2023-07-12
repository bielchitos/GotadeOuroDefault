import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { AgendamentoGrid } from './AgendamentoGrid';

export default function pageInit() {
    initFullHeightGridPage(new AgendamentoGrid($('#GridDiv')).element);
}