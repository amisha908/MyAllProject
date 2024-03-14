import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  private emailValue!: string ;
  private userIdValue!:string;

  setEmailValue(email: string) {
    this.emailValue = email;
  }

  getEmailValue() {
    return this.emailValue;
  }
  setUserIDvalue(userId: string){
    this.userIdValue=userId;
  }
  getUserIDvalue(){
    return this.userIdValue;
  }
}
