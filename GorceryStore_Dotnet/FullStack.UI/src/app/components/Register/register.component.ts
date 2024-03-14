import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Users } from 'src/app/Models/Users.model';
import { RegisterserviceService } from 'src/app/services/registerservice.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  registrationForm: FormGroup;
  addUserRequest: Users = {
    email: '',
    name: '',
    password: '',
    confirmPassword: '',
    registrationType: 'normal'
  };

  constructor(
    private formBuilder: FormBuilder,
    private snackBar: MatSnackBar,
    private registerService: RegisterserviceService
  ) {
    this.registrationForm = this.formBuilder.group({
      email: ['', [Validators.required, Validators.email]],
      name: ['', Validators.required],
      password: ['', Validators.required],
      confirmPassword: ['', Validators.required]
    });
  }

  registerUser() {
    if (this.registrationForm.invalid) {
      this.openSnackBar('Please fill in all the required fields.', 'Error');
      return;
    }
  
    if (this.registrationForm.value.password !== this.registrationForm.value.confirmPassword) {
      this.openSnackBar('Password and Confirm Password do not match.', 'Error');
      return;
    }
  
    const email = this.registrationForm.value.email;
  
    // Call the checkEmailExists() method to check if the email exists
    this.registerService.checkEmailExists(email).subscribe(
      (response) => {
        console.log(response);
        if (response==true) {
          this.openSnackBar('Email address already exists.', 'Error');
        } else {
          // Proceed with registration if email does not exist
          this.addUserRequest.email = email;
          this.addUserRequest.name = this.registrationForm.value.name;
          this.addUserRequest.password = this.registrationForm.value.password;
  
          this.registerService.addUser(this.addUserRequest).subscribe(
            (response) => {
              // Registration successful
              this.openSnackBar('Registration successful!', 'Success');
              this.registrationForm.reset();
            },
            (error) => {
              // Handle error response
              this.openSnackBar('Registration failed. Please try again.', 'Error');
            }
          );
        }
      },
      (error) => {
        // Handle error response from checkEmailExists()
        console.log(error);
        this.openSnackBar('Error checking email existence. Please try again.', 'Error');
      }
    );
  }

  openSnackBar(message: string, action: string) {
    this.snackBar.open(message, action, {
      duration: 2000 // Adjust the duration as per your preference
    });
  }
}
