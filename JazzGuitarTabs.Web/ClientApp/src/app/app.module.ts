import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { TabComponent } from './tab/tab.component';
import { TabListComponent } from './tab/tab-list/tab-list.component';
import { TabCreateComponent } from './tab/tab-create/tab-create.component';
import { TabService } from './shared/services/tab.service';
import { ArtistService } from './shared/services/artist.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    TabComponent,
    TabListComponent,
    TabCreateComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'tab', component: TabComponent },
      { path: 'tab/list/:artist', component: TabListComponent }
    ])
  ],
  providers: [TabService, ArtistService],
  bootstrap: [AppComponent]
})
export class AppModule { }
