import { Injectable } from '@angular/core';

@Injectable()
export class Settings {
    public chuckSwApiUrl: string;

    public get ChuckSwApiService(){
        
        return {chuckNorrisRandomCategoryUrl : `${this.chuckSwApiUrl}/api/v1/category/?category=`,
        chuckNorrisAllCategoriesUrl : `${this.chuckSwApiUrl}/api/v1/categories/`,
        StarWarsUrl : `${this.chuckSwApiUrl}/api/v1/people`,
        SearchUrl : `${this.chuckSwApiUrl}/api/v1/search/?tag=`}

    }
}