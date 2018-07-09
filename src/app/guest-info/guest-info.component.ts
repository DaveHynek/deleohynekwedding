import { Component, Input, OnInit } from '@angular/core';

import { Guest } from '../../class/guest';
import { MenuOption } from '../../class/menuOption';
import { GuestResponseInfo } from '../../class/guestResponseInfo';

@Component({
  selector: 'app-guest-info',
  templateUrl: './guest-info.component.html',
  styleUrls: ['./guest-info.component.css']
})
export class GuestInfoComponent implements OnInit {
  @Input() guest: Guest;
  @Input() menu: MenuOption[];
  chopShop: string;

  constructor() {
  }

  ngOnInit() {
    this.chopShop = 'Chop Shop';
    if (!this.guest.responseInfo) this.guest.responseInfo = new GuestResponseInfo();
  }

}
