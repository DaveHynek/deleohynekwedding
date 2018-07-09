import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';

import { Observable } from 'rxjs/Observable';

import { MenuOption } from '../../../class/menuOption';

@Injectable()
export class MenuService {

  constructor(private http: HttpClient) { }

  getMenu(): Observable<HttpResponse<MenuOption[]>> {
    return this.http.get<MenuOption[]>('api/menu', { observe: 'response' });
  }
}
