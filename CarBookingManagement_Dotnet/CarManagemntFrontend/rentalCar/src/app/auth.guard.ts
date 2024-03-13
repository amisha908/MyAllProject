import { CanActivateFn } from '@angular/router';

export const authGuard: CanActivateFn = (route, state) => {

  
  const isAdminAuthenticated = localStorage.getItem('admin');

  if (isAdminAuthenticated) {
    return true; 
  } else {
    console.log('Unauthorized access to admin-auth route');
    return false;
  }
};
