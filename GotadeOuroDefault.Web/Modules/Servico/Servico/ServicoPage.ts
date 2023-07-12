import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ServicoGrid } from './ServicoGrid';

export default function pageInit() {
    initFullHeightGridPage(new ServicoGrid($('#GridDiv')).element);
}