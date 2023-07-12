import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ViscosidadeGrid } from './ViscosidadeGrid';

export default function pageInit() {
    initFullHeightGridPage(new ViscosidadeGrid($('#GridDiv')).element);
}