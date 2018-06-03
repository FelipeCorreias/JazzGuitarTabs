import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { TabService } from '../../shared/services/tab.service';
import { Tab } from '../../shared/models/tab.model';

@Component({
  selector: 'app-tab-list',
  templateUrl: './tab-list.component.html',
  styleUrls: ['./tab-list.component.css']
})
export class TabListComponent implements OnInit {
  public tabs: Tab[];
  public _tabService: TabService;
  public _route: ActivatedRoute;

  constructor(private tabService: TabService, private route: ActivatedRoute) {
    this._tabService = tabService;
    this._route = route;
  }

  ngOnInit() {
    this._route.params.subscribe(params => {
      this.tabs = null;
      if (params['artist'] != null) {
        this.getTabsByArtist(params['artist'])
      } else {
        //this.getTabs();
      }
    });
  }

  getTabsByArtist(artist: string) {
    this._tabService.getTabsListByArtist(artist).subscribe(data => { this.tabs = data; })
      , err => {
        console.log(err);
      };
  }

  getTabFile(id: number) {
    return this._tabService.getTabFile(id);
  }

}
