import { RouterModule } from '@angular/router';
import { SaveTheDateComponent } from './save-the-date/save-the-date.component';
import { TheBigDayComponent } from './the-big-day/the-big-day.component';
import { RsvpComponent } from './rsvp/rsvp.component';
import { InfoComponent } from './info/info.component';
import { GiftRegistryComponent } from './gift-registry/gift-registry.component';

const routes = [
  { path: '', redirectTo: 'thebigday', pathMatch: 'full' },
  { path: 'savethedate', component: SaveTheDateComponent, data: { state: 'savethedate' } },
  { path: 'thebigday', component: TheBigDayComponent, data: { state: 'thebigday' } },
  { path: 'rsvp', component: RsvpComponent, data: { state: 'rsvp' } },
  { path: 'info', component: InfoComponent, data: { state: 'info' } },
  { path: 'registry', component: GiftRegistryComponent, data: { state: 'registry' } }
];

export const AppRouting = RouterModule.forRoot(routes, {
  useHash: true
});
