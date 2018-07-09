import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';

import { InvitationService } from '../services/invitation/invitation.service';
import { MenuService } from '../services/menu/menu.service';
import { Invitation } from '../../class/invitation';
import { MenuOption } from '../../class/menuOption';

@Component({
  selector: 'app-rsvp',
  templateUrl: './rsvp.component.html',
  styleUrls: ['./rsvp.component.css']
})
export class RsvpComponent implements OnInit {
  inviteCode: string;
  showError: boolean;
  rsvpComplete: boolean;
  rsvpAccepted: boolean;
  invite: Invitation;
  menu: Array<MenuOption>;

  constructor(
    private invitationSvc: InvitationService, private menuService: MenuService) { }

  ngOnInit() {
  }
  
  getInvitation() {
    this.menuService.getMenu().subscribe(resp => {
      this.menu = resp.body;
    });
    this.invitationSvc.getInvite(this.inviteCode).subscribe(resp => {
      this.showError = !resp.body;

      if (!resp.body) return;
      
      this.invite = resp.body;
    });
  }

  saveInvitation() {
    var errorMsg;

    if (this.invite.attending) {
      this.invite.guests.forEach(function (guest) {
        if (!errorMsg && (!guest.firstName || guest.firstName.length === 0 ||
          !guest.lastName || guest.lastName.length === 0)) {
          errorMsg = "Please provide your first and last name so we know who will be coming!";
        }
        //if (!errorMsg && (!guest.email || guest.email.length === 0)) {
        //  errorMsg = "Please provide your email so we can get in touch with you if necessary!";
        //}
        if (!errorMsg && (guest.responseInfo.attending == null)) {
          errorMsg = "Please let us know if you are attending!";
        }
        if (!errorMsg && (!guest.responseInfo.oakmontBBQSelection || !guest.responseInfo.chopShopSelection)) {
          errorMsg = "Please let us know what food options sound best.  This is not an order or commitment.";
        }
      });

      if (errorMsg) {
        alert(errorMsg);
        return;
      }
    }

    this.invitationSvc.saveInvite(this.invite).subscribe(resp => {
      this.invite = null;
      this.rsvpComplete = this.rsvpAccepted = true;
    }, error => {
      this.invite = null;
      this.rsvpComplete = true;
      this.rsvpAccepted = false;
    });
  }
}
