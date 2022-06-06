import { Injectable } from '@angular/core';
import { BaseService } from './base.service';
import { Observable } from 'rxjs';
import { SwPeople } from '../models/sw-people.model';

@Injectable()
export class ChuckSwApiService extends BaseService {

  public GetCategories(): Observable<List<string>> {
    return this.Get(this.settings.ChuckSwApiService.chuckNorrisAllCategoriesUrl)
      .map(response => {
        return response;
      });
  }
  public GetRandomJokeByCategory(category: string): Observable<Joke[]> {
    return this.Get(`${this.settings.ChuckSwApiService.chuckNorrisRandomCategoryUrl}${category}`)
      .map(response => {
        return response.Payload;
      });
  }
  public GetSwPeople(): Observable<SwPeople[]> {
    return this.Get(this.settings.ChuckSwApiService.StarWarsUrl)
      .map(response => {
        return response;
      });
  }
  public Search(tag: string): Observable<[]> {
    return this.Get(`${this.settings.ChuckSwApiService.SearchUrl}${tag}`)
      .map(response => {
        return response;
      });
  }
}