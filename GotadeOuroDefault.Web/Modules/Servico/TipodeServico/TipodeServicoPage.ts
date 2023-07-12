import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TipodeServicoGrid } from './TipodeServicoGrid';

export default function pageInit() {
    initFullHeightGridPage(new TipodeServicoGrid($('#GridDiv')).element);
}