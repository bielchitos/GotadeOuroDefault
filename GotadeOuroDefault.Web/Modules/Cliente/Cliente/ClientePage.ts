import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ClienteGrid } from './ClienteGrid';

export default function pageInit() {
    initFullHeightGridPage(new ClienteGrid($('#GridDiv')).element);
}