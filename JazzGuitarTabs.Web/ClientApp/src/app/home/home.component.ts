import { Component, OnInit } from '@angular/core';
import { ArtistService } from '../shared/services/artist.service';
import { Artist } from '../shared/models/artist.model';
import { Tab } from '../shared/models/tab.model';
import { TabService } from '../shared/services/tab.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  public artists: Artist[];
  public tabs: Tab[];
  public _artistService: ArtistService;
  public _tabService: TabService;

  constructor(private artistService: ArtistService, private tabService: TabService) {
    this._artistService = artistService;
    this._tabService = tabService;
  }

  ngOnInit() {
    this.getArtistsList();
    this.getTabsListLastTwenty();
  }

  getArtistsList() {
    this._artistService.getArtistsList().subscribe(data => { this.artists = data; })
  }

  getTabsListLastTwenty() {
    this.tabService.getTabsListLastTwenty().subscribe(data => { this.tabs = data; })
  }
}
