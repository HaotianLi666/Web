import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { User } from '../models/index';
import { environment as env } from '../../environments/environment';

@Injectable({ 
    providedIn: 'root' 
})
export class UserService {
    constructor(private http: HttpClient) { }

    register(user: User) {
        return this.http.post(`${env.urls['api']}/users/register`, user);
    }
}