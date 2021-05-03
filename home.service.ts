import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
export class Movies{
  MovieName:string;
  MovieId:number;
}
@Injectable({
  providedIn: 'root'
})
export class HomeService {
Moviesdata:Movies=new Movies();
  constructor(private http:HttpClient) { }

  GetMovieData():Observable<any>{
    return   this.http.get("https://localhost:44338/api/Movies");

}
}
