import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { MarcaGrid } from './MarcaGrid';

export default function pageInit() {
    initFullHeightGridPage(new MarcaGrid($('#GridDiv')).element);
}