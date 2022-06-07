import { Injectable } from '@angular/core';
import { BaseService } from './base.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { SwPeople } from '../models/sw-people.model';
import { Joke } from '../models/cn-joke.model';
import { ResultBase } from '../models/result-base.model';

@Injectable()
export class ChuckSwApiService extends BaseService {

  public GetCategories(): Observable<ResultBase> {
    return this.Get(this.settings.ChuckSwApiService.chuckNorrisAllCategoriesUrl)
      .pipe(map(response => {
        return response;
      }));
  }
  public GetRandomJokeByCategory(category: string): Observable<ResultBase> {
    return this.Get(`${this.settings.ChuckSwApiService.chuckNorrisRandomCategoryUrl}${category}`)
      .pipe(map(response => {
        return response;
      }));
  }
  public GetSwPeople(): Observable<ResultBase> {
    return this.Get(this.settings.ChuckSwApiService.StarWarsUrl)
      .pipe(map(response => {
        return response;
      }));
  }
  public Search(tag: string): Observable<ResultBase> {
    debugger
    return this.Get(`${this.settings.ChuckSwApiService.SearchUrl}${tag}`)
      .pipe(map(response => {
        return response;
      }));
  }
}