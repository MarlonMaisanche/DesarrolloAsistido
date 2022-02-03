import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { AuthService } from '../auth/services/auth.service';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
/**
 * Constructor de la clase Auto guardado
 * @param authService 
 * @param router 
 */
  constructor(private authService: AuthService,
    private router: Router) {
      
  }
/**
 * Comprueba que exita la información de la sesion actual
 * @param route 
 * @param state 
 * @returns valor boleano
 */
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot) {

      return this.authService.userData$.pipe(
        map(user=>{
          if(!user){
            this.router.navigateByUrl('auth/login')
            return false
          }
          return true
        })
      )
  }

}
