import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { HttpServiceRequestType } from '../models/http-service-request-types.enum';
import { Settings } from './_settings';

@Injectable()
export class BaseService {

    constructor(public settings: Settings, private http: HttpClient) { }


    protected Get(url: string, options?: any, isLoader: boolean = true): Observable<any> {
        
        return this.http.get(url, options)
            .pipe(map((response) => this.HandleResponse(response, HttpServiceRequestType.GET, url)))
    }

    private HandleResponse(response: any, type: HttpServiceRequestType, url: any, body: any = {}): Object {
        console.log(`url:${url}|method:${type}|payload:${body}|response:${response}`);
        return response;
    }

}
