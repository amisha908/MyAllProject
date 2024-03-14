import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { AuthService } from 'src/app/services/authentication.service';
import { Authentication } from 'src/app/Models/Users.model';
import { Router } from '@angular/router';
import { SharedService } from 'src/app/services/shared.service';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  loginForm: FormGroup;
  CheckLoginRequest : Authentication = {
    email: '',
    password: '',
    
  };

  constructor(
    private formBuilder: FormBuilder,
    private snackBar: MatSnackBar,
    private check: AuthService,
    private sharedService: SharedService,
    private router: Router
  ) {
    this.loginForm = this.formBuilder.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', Validators.required],
      registrationType: [false]
    });
  }

  login() {
    if (this.loginForm.invalid) {
      this.openSnackBar('Please fill in all the required fields.', 'Error');
      return;
    }

  
    
    this.CheckLoginRequest.email = this.loginForm.value.email;
    const emailtoshare =this.loginForm.value.email
    this.CheckLoginRequest.password=this.loginForm.value.password;
   
    this.check.login(this.CheckLoginRequest).subscribe(

      (response: { registrationType: string }) => {
        const registrationType = response.registrationType;
        console.log(response);
  
        if (registrationType === 'normal')  {
          this.router.navigate(['/User-view']);
          this.sharedService.setEmailValue(emailtoshare);
        } else {
          this.router.navigate(['/Admin-view']);
        }
  
        this.openSnackBar('Login successful.', 'Success');
      }
    );
  }

  openSnackBar(message: string, action: string) {
    this.snackBar.open(message, action, {
      duration: 2000 // Adjust the duration as per your preference
    });
  }
}
