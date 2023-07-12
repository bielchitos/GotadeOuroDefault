import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TipodeProdutoGrid } from './TipodeProdutoGrid';

export default function pageInit() {
    initFullHeightGridPage(new TipodeProdutoGrid($('#GridDiv')).element);
}