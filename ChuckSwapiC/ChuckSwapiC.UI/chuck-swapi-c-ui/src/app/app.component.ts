import { Component } from '@angular/core';
import { ChuckSwApiService } from './services/chuck-sw-api.service';
import { SwPeople } from './models/sw-people.model';
import { Joke } from './models/cn-joke.model';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})

export class AppComponent {
  title = 'chuck-swapi-c-ui';
  public categories: string[] = [];
  public selectedCategory: string = "";
  public starWarsPeople: SwPeople[] = [];
  public searchResult: string[] = [];
  public randomJoke: Joke | undefined;
  public showCategoryList: boolean = false;
  public currentSearch: string = "";
  constructor(public chuckSwApiService: ChuckSwApiService){}

  CnQuery(){
    this.chuckSwApiService.GetCategories().subscribe(returnedCategories => {
      this.categories = returnedCategories.Payload;
      this.showCategoryList = true;
    },() => {
    })
  }
  GetRandomJoke(category: string){
    this.chuckSwApiService.GetRandomJokeByCategory(category).subscribe(joke => {
      this.randomJoke = joke.Payload[0];
    })
  }

  SwQuery(){
    this.chuckSwApiService.GetSwPeople().subscribe(people => {
      debugger
      this.starWarsPeople = people.Payload;
    })
  }

  Search(){
    this.chuckSwApiService.Search((<HTMLInputElement>document.getElementById("currentSearch")).value).subscribe(result => {
       result.Payload.forEach(element => {
         debugger
         if (element?.Name != undefined)
          {
            element.Payload.forEach((sw: { Name: string; }) => {
              this.searchResult.push(`Name: ${sw.Name}. Source: Star wars`);
              
            });
          }
         else
         this.searchResult.push(`Joke: ${element.Value}. Source: Chuck Norris`);
       });
    })
  }
}
