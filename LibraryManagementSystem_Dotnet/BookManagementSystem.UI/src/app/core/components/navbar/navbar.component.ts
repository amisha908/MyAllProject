import { NotExpr } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/features/auth/models/user.model';
import { AuthService } from 'src/app/features/auth/services/auth.service';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  user?: User;

  constructor(private authService: AuthService,
    private router: Router){

  }
  @NgModule({
    imports: [
      // Other imports
      RouterModule.forRoot([]), // Make sure to configure your routes inside the forRoot method
      RouterModule,
      CommonModule,
      
    ]})
  ngOnInit(): void {
    this.authService.user()
    .subscribe({
      next: (response) =>{
        // console.log(response);
        this.user = response;  
      }
    });

    this.user = this.authService.getUser();
  }

  onLogout(): void {
    this.authService.logout();
    this.router.navigateByUrl('/');
  }

}
