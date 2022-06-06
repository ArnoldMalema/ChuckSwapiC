import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import 'rxjs/add/observable/throw';
import 'rxjs/Rx';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import { HttpServiceRequestType } from '../models/http-service-request-types.enum';
import { Settings } from './_settings';

@Injectable()
export class BaseService {

    constructor(public settings: Settings, private http: HttpClient) { }


    protected Get(url: string, options?: any, isLoader: boolean = true): Observable<any> {
        console.log(`url:${url}|method:GET|payload:${response}`);
        return this.http.get(url, options)
            .pipe(map((response) => this.HandleResponse(response, HttpServiceRequestType.GET, url)))
            .catch(err => this.HandleError(err, isLoader));
    }

    private HandleResponse(response: any, type: HttpServiceRequestType, url: any, body: any = {}): Object {
        console.log(`url:${url}|method:${type}|payload:${body}|response:${response}`);
        return response;
    }

    private HandleError(error: Object | any, isLoader: boolean) {
        console.log(`url:${url}|method:${type}|payload:${body}|response:${response}`);
        return Observable.throw(error.error ? error.error : (error.message || error));
    }

}
