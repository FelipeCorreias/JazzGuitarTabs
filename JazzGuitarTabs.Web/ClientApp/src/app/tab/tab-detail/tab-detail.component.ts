import { Component, OnInit } from '@angular/core';
import { Tab } from '../../shared/models/tab.model';
import { TabService } from '../../shared/services/tab.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-tab-detail',
  templateUrl: './tab-detail.component.html',
  styleUrls: ['./tab-detail.component.css']
})
export class TabDetailComponent implements OnInit {

  public tab: Tab;
  public _tabService: TabService;
  public _route: ActivatedRoute;

  constructor(private tabService: TabService, private route: ActivatedRoute) {
    this._tabService = tabService;
    this._route = route;
  }

  ngOnInit() {

    this._route.params.subscribe(params => {
      if (params['id'] != null) {
        this.getTab(params['id']);
      }
    });

  }

  getTab(id: number) {
    return this._tabService.gertTab(id).subscribe(data => { this.tab = data; });
  }

  getTabFile(id: number) {
    return this._tabService.getTabFile(id);
  }

}
