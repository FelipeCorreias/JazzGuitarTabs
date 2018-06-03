import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Tab } from '../models/tab.model';

@Injectable()
export class TabService {
  public _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  getTabsListByArtist(artist: string) {
    return this._http.get<Tab[]>('/api/Tab/Artist/' + artist);
  }

  getTabFile(id: number): string {
    return ('/api/Tab/' + id + '/File');
  }

}
