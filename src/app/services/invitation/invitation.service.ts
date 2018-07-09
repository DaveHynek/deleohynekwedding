import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';

import { Observable } from 'rxjs/Observable';

import { Invitation } from '../../../class/invitation';

@Injectable()
export class InvitationService {

  constructor(private http: HttpClient) { }

  getInvite(inviteCode: string): Observable<HttpResponse<Invitation>> {
    return this.http.get<Invitation>('api/invitation', { headers: new HttpHeaders({ 'Authorization': inviteCode }), observe: 'response' });
  }

  saveInvite(invitation: Invitation): Observable<HttpResponse<object>> {
    return this.http.put('api/invitation', invitation, { headers: new HttpHeaders({ 'Authorization': invitation.rsvpCode }), observe: 'response' });
  }
}
