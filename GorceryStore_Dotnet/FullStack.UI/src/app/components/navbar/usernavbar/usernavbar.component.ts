import { Component } from '@angular/core';

import { SharedService } from 'src/app/services/shared.service';
import { UserServiceService } from 'src/app/services/user-service.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-usernavbar',
  templateUrl: './usernavbar.component.html',
  styleUrls: ['./usernavbar.component.css']
})
export class UsernavbarComponent {
  
  email!: string;
  name: any;
  userId: any;
  
  constructor(private SharedService :SharedService,
    private userService: UserServiceService,
    private router:Router){

  }
  
  logout()
  {
    localStorage.removeItem('token');
    sessionStorage.clear();
    window.history.pushState({}, '', '/');
    // Navigate to the login page
    this.router.navigateByUrl('/');
    
  }

  ngOnInit() {
    this.email = this.SharedService.getEmailValue();
    console.log(this.email)
    this.getUserDetails(this.email);
    
  }
  
  
  getUserDetails(email: string): void {
    this.userService.getUserByEmail(this.email).subscribe(
      (response) => {
        // Handle the response here
        const name = response.username;
      const userId = response.userId;
      this.SharedService.setUserIDvalue(userId);
    
        
      this.name=name;
      this.userId=userId;
      },
      (error) => {
        // Handle the error here
        console.error(error);
      }
    );
  }
  
}

