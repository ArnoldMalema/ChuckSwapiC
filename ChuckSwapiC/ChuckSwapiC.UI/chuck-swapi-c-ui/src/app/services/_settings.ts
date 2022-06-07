import { Injectable } from '@angular/core';

@Injectable()
export class Settings {
    public chuckSwApiUrl: string = "https://localhost:44347";

    public get ChuckSwApiService(){
        
        return {chuckNorrisRandomCategoryUrl : `${this.chuckSwApiUrl}/api/v1/jokes/category/?category=`,
        chuckNorrisAllCategoriesUrl : `${this.chuckSwApiUrl}/api/v1/jokes/categories/`,
        StarWarsUrl : `${this.chuckSwApiUrl}/api/v1/people`,
        SearchUrl : `${this.chuckSwApiUrl}/api/v1/search/?tag=`}

    }
}