import { Component, Inject } from '@angular/core';
import { LoginRequest } from '../models/login-request.model';
import { AuthService } from '../services/auth.service';
import { CookieService } from 'ngx-cookie-service';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  model: LoginRequest;

  constructor(private authService: AuthService,
    @Inject('cookieService') private cookieService: any,
    private router: Router){
    this.model = {
      email:  '',
      password: ''
    };
  }

  onFormSubmit(): void {
    console.log(this.model);;
    this.authService.login(this.model)
    .subscribe({
      next: (response) => {
        // console.log(response);
        //Set Auth Cookie
        this.cookieService.set('Authorization', `Bearer ${response.token}`,
        undefined,'/',undefined,true,'Strict');

        //Set the user
        this.authService.setUser({
          email: response.email,
          roles: response.roles,
          name: response.name,
          tokensAvailable: response.tokensAvailable
        });

        //Redirect Back to Home Page
        Swal.fire('Login successful');
        this.router.navigateByUrl('/');
      },
      error: (error) => {
        //console.log("error:",error.error.errors[""][0]);
        Swal.fire(error.error.errors[""][0]);
      }
    });
  }

}
