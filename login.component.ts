import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginserviceService } from 'src/loginservice.service';
export class user{
  UserId:number;
  username:string;
  password:string;
}

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
  UserLoginData:user =new user();
  userarray:user[]=[];
  uname:string;
  constructor(private route:Router,private loginservice:LoginserviceService,private http:HttpClient ) {
    this.loginservice.Getuserdata().subscribe((data1:any)=>{
     this.userarray=data1;
      console.log(this.userarray);
    });
    
   }
  onSubmit(data:any){   
let result = this.userarray.filter(x=>x.username == data.username && x.password == data.password)
this.uname=this.UserLoginData.username;
if(result.length >0) {
this.route.navigate(['home',this.uname]);
}
else
{
  alert("Please Enter Valid Username& password"); 
  this.UserLoginData.username="";
  this.UserLoginData.password="";
}

  }
  Register(){
    this.route.navigate(['/singin']);
  }
  ngOnInit(): void {
  }

}
