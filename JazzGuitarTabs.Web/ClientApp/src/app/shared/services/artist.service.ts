import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Artist } from '../models/artist.model';

@Injectable()
export class ArtistService {
  public _http: HttpClient;

  constructor(http: HttpClient) {
    this._http = http;
  }

  getArtistsList() {
    return this._http.get<Artist[]>('/api/Artist/');
  }

}
