import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HomeService } from '../home.service';
export class Movies{
  MovieName:string;
  MovieId:number;
}
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent implements OnInit {
  rec:string='';
Moviedetailsdata:Movies=new Movies();
moviesarray:Movies[]=[];
  constructor(private http:HttpClient,private homeservices:HomeService,private router:Router,private rout:ActivatedRoute) { 
  }

  ngOnInit(): void {
    this.homeservices.GetMovieData().subscribe((data:any)=>{
      this.moviesarray=data;
      console.log(this.moviesarray);
    });
    this.rec=this.rout.snapshot.params['uname'];
  }

}
