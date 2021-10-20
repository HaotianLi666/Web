import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment as env } from './../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class RepositoryService {
  private address: string = env.urls['api'];

  constructor(private http: HttpClient) { }

  public get(route: string) {
    return this.http.get(this.createCompleteRoute(route, this.address));
  }

  public post(route: string, body) {
    return this.http.post(this.createCompleteRoute(route, this.address), body, this.generateHeaders());
  }

  public put(route: string, body) {
    return this.http.put(this.createCompleteRoute(route, this.address), body, this.generateHeaders());
  }

  public delete(route: string) {
    return this.http.delete(this.createCompleteRoute(route, this.address));
  }
  
  public createCompleteRoute(route: string, address: string) {
    return `${address}/${route}`;
  }

  private generateHeaders() {
    return {
      headers: new HttpHeaders({ 'ContentType': 'application/json' })
    }
  }
}
