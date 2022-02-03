import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { AuthService } from '../auth/services/auth.service';

@Injectable({
  providedIn: 'root'
})
export class LoginGuard implements CanActivate {

  constructor(private authService: AuthService,
    private router: Router) {
      
  }
/**
 * Impide que se abra la pestaña de Login cuando el usuario ya iniceio sesion
 * @param route 
 * @param state 
 * @returns 
 */
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot) {

      return this.authService.userData$.pipe(
        map(user=>{
          if(user){
            this.router.navigateByUrl('')
            return false
          }
          return true
        })
      )
  }
  
}
