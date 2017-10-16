import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class HttpService {
    constructor(private http: Http) { }

    getUsers(skip: number, take: number) {
        return this.http.get("api/Data/UsersRange/" + skip + '/' + take);
    }
}