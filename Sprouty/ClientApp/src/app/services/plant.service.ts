import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable} from 'rxjs';
import { Plant } from '../models/plant';


@Injectable({
  providedIn: 'root'
})
export class PlantService {
  //Add a property for the url hitting
  private apiUrl = 'http://localhost:3000/plants';
  
  //Now we can use Http to #get #post etc
  constructor(private http:HttpClient) { }

  getPlants(): Observable<Plant[]>{
    //Now the Data is getting from http request instead of the file itself
    return this.http.get<Plant[]>(this.apiUrl);
  }

  deletePlant(plant: Plant): Observable<Plant>{
    const url = `${this.apiUrl}/${plant.id}`;
    return this.http.delete<Plant>(url);
  }
}
