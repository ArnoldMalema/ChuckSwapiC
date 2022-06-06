import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ChuckNorrisQueryComponent } from './chuck-norris-query/chuck-norris-query.component';
import { StarWarsQueryComponent } from './star-wars-query/star-wars-query.component';
import { SearchQueryComponent } from './search-query/search-query.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';
import {MatTabsModule} from '@angular/material/tabs';
import { RouterModule } from '@angular/router';
@NgModule({
  declarations: [
    AppComponent,
    ChuckNorrisQueryComponent,
    StarWarsQueryComponent,
    SearchQueryComponent
  ],
  imports: [
    MatSliderModule,
    MatTabsModule,
    BrowserModule,
    RouterModule.forRoot([
      {path: 'chuck-norris-query', component: ChuckNorrisQueryComponent},
      {path: 'star-wars-query', component: StarWarsQueryComponent},
      {path: 'search-query', component: SearchQueryComponent},
    ]),
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
