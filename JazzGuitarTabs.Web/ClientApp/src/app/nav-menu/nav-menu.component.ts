import { Component, OnInit } from '@angular/core';
import { ArtistService } from '../shared/services/artist.service';
import { Artist } from '../shared/models/artist.model';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  isExpanded = false;
  public artists: Artist[];
  public _artistService: ArtistService;

  constructor(private artistService: ArtistService) {
    this._artistService = artistService;
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  ngOnInit() {
   this.getArtistsList();
  }

  getArtistsList() {
    this._artistService.getArtistsList().subscribe(data => { this.artists = data; })
  }
}
