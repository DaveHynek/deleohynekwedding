import { NgModule } from '@angular/core';
import { AppRouting } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';

import { SaveTheDateComponent } from './save-the-date/save-the-date.component';
import { RsvpComponent } from './rsvp/rsvp.component';
import { InfoComponent } from './info/info.component';

import { InvitationService } from './services/invitation/invitation.service';
import { MenuService } from './services/menu/menu.service';
import { GuestInfoComponent } from './guest-info/guest-info.component';

import { FilterMenuPipe } from './guest-info/filter-menu.pipe';
import { TheBigDayComponent } from './the-big-day/the-big-day.component';
import { GiftRegistryComponent } from './gift-registry/gift-registry.component';

@NgModule({
  declarations: [
    AppComponent,
    SaveTheDateComponent,
    RsvpComponent,
    InfoComponent,
    GuestInfoComponent,
    FilterMenuPipe,
    TheBigDayComponent,
    GiftRegistryComponent
  ],
  imports: [
    AppRouting,
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [InvitationService, MenuService],
  bootstrap: [AppComponent]
})
export class AppModule { }
