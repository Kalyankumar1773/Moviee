import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
export class UserReviews1{
  MovieName:string;
  MovieReview:string;
  MovieRating:string;
  Username:string;
}
@Injectable({
  providedIn: 'root'
})
export class UserReviewServiceService {
  UserReview1s:UserReviews1=new UserReviews1();
  UserReviewArray1s:UserReviews1[]=[];
  constructor(private http:HttpClient) { }
  PostUserReview(userReviews:UserReviews1):Observable<any>{
    var UserReviews=this.http.post("https://localhost:44338/api/UserReview",userReviews);
    return UserReviews;
 
   }
}
