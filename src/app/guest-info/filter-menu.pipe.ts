import { Pipe, PipeTransform } from '@angular/core'
import { MenuOption } from './../../class/menuOption'

@Pipe({
  name: 'filtermenu'
})

export class FilterMenuPipe implements PipeTransform {
  transform(items: MenuOption[], filterText: string): MenuOption[] {
    if (!items) return [];
    if (!filterText) return items;
    return items.filter(item => { return item.caterer.includes(filterText); });
  }
}
