import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserReviewServiceService } from '../user-review-service.service';
export class UserReviews{
  MovieName:string;
  MovieReview:string;
  MovieRating:string;
  Username:string;
}
@Component({
  selector: 'app-reviewpage',
  templateUrl: './reviewpage.component.html',
  styleUrls: ['./reviewpage.component.css']
})
export class ReviewpageComponent implements OnInit {
UserReview:UserReviews=new UserReviews();
UserReviewArray:UserReviews[]=[];
  constructor(private http:HttpClient,private ReviewService:UserReviewServiceService,private route:Router) { }
onSubmit(data:any){
  if(this.UserReview.MovieName && this.UserReview.MovieRating && this.UserReview.MovieReview&&this.UserReview.Username){
  this.UserReview=data;
  this.ReviewService.PostUserReview(data).subscribe()
console.log(this.UserReview);
alert("Thank You Your Feedback");
this.route.navigate(['login']);
  }
}
  ngOnInit(): void {
  }

}
