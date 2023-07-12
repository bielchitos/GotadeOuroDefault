import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ProdutoGrid } from './ProdutoGrid';

export default function pageInit() {
    initFullHeightGridPage(new ProdutoGrid($('#GridDiv')).element);
}