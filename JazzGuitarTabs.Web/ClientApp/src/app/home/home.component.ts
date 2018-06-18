import { Component, OnInit } from '@angular/core';
import { ArtistService } from '../shared/services/artist.service';
import { Artist } from '../shared/models/artist.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  public artists: Artist[];
  public _artistService: ArtistService;

  constructor(private artistService: ArtistService) {
    this._artistService = artistService;
  }

  ngOnInit() {
    this.getArtistsList();
  }

  getArtistsList() {
    this._artistService.getArtistsList().subscribe(data => { this.artists = data; })
  }
}
