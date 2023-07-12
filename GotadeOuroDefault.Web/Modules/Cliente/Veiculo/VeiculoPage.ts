import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { VeiculoGrid } from './VeiculoGrid';

export default function pageInit() {
    initFullHeightGridPage(new VeiculoGrid($('#GridDiv')).element);
}