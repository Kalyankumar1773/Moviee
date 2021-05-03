import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { ReviewpageComponent } from './reviewpage/reviewpage.component';
import { SignInComponent } from './sign-in/sign-in.component';

const routes: Routes = [
  {path:'',redirectTo:'login',pathMatch:'full'},
  {path:'home/:uname',component:HomeComponent},
  {path:'login',component:LoginComponent},
  {path:'singin',component:SignInComponent},
  {path:'about',component:AboutComponent},
  {path:'Review',component:ReviewpageComponent},
  {path:'***',component:NotFoundComponent},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
