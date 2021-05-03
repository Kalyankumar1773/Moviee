import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SignInService } from 'src/sign-in.service';
//import { FormBuilder, FormGroup, Validators } from '@angular/forms';
export class Userdata{
  UserName:string;
  Password:string;
  ConfirmPassword:string;
  Email:string;
}
@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {
 // loginform: FormGroup;
  //  submitted = false;
UserData:Userdata[]=[];
data1:Userdata=new Userdata();
  constructor(private http:HttpClient,private signinservice:SignInService,private route:Router,) {
   }
 onSubmit(data:any){
  if(this.data1.Password=this.data1.ConfirmPassword && this.data1.UserName && this.data1.Password && this.data1.ConfirmPassword && this.data1.Email){
    this.data1=data;
    this.signinservice.PostUserData(this.data1).subscribe();
    alert("Rigister SuccessFully");
    this.route.navigate(['login']);
  }else{
    alert("Please Enter Details");
  }
  
   console.log(this.data1);
   

   
 }
  ngOnInit(): void {
    // this.loginform = this.formBuilder.group({
    //   UserName: ['', Validators.required],
    //   Email: ['', [Validators.required, Validators.email]],
    //   Password: ['', [Validators.required, Validators.minLength(6)]],
    //   ConfirmPassword: ['', Validators.required]
    //   }, {
    //   validator: MustMatch('Password', 'ConfirmPassword')
    //    });
    //        function MustMatch(arg0: string, arg1: string): any {
    //        throw new Error('Function not implemented.');
    //        }
   }
}
