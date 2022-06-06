import { Component } from '@angular/core';
import {MatTabsModule} from '@angular/material/tabs';
import { ChuckSwApiService } from './services/chuck-sw-api.service';
import { SwPeople } from './models/sw-people.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'chuck-swapi-c-ui';
  public categories: string[] = [];
  public selectedCategory: string = "";
  public starWarsPeople: SwPeople[] = [];
  public searchResult: any[] = [];

  constructor(public chuckSwApiService: ChuckSwApiService){}

  CnQuery(){
    this.chuckSwApiService.GetCategories().subscribe((returnedCategories: any[]) => {
      this.categories = returnedCategories;
    },() => {
    })
  }

  SwQuery(){
    
  }

  Search(){
    
  }
}
