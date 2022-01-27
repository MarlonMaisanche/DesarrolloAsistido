import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import firebase from 'node_modules/firebase/compat/app';
import { Observable, Subject, BehaviorSubject } from 'rxjs';
import { Router } from '@angular/router';
import { first } from 'rxjs/operators';
import { ToastrService } from 'ngx-toastr';

// import { Provider, SocialLoginService } from 'ng8-social-login';
// import { FacebookService, InitParams } from 'ngx-facebook';


@Injectable({
  providedIn: 'root'
})
export class AuthService {


  public userData$: Observable<firebase.User>

  constructor(public auth:AngularFireAuth,
     private toastr:ToastrService,
     ) {
       this.userData$ = auth.authState
      
      // this.user = this.auth.authState
      // this.user.subscribe((user) => {
      //   console.log(user);
      //   if (user) {
      //     this.isLoggedIn.next(true);
      //   } else {
      //     this.isLoggedIn.next(false);
      //   }
      // });

  }


  // estaLogeado() {
  //   if (this.userDetails == null) {
  //     return false;
  //   } else {
  //     return true;
  //   }
  // }


  validarToken(){
    let token = localStorage.getItem('token')||null
    if(token){
       return true 
    }
      return false
  }

  async crearUsuario(correo:string,password:string){
    try{
      const result = await   this.auth.createUserWithEmailAndPassword(correo,password)
      return result
    }catch(error){
      this.toastr.error(error,'Ha ocurrido un problema!',{
        timeOut:1500,
        closeButton:true
         })
    }
    return null
  }

  async loginCorreo(correo:string,password:string) { 
    try {
      const result = await this.auth.signInWithEmailAndPassword(correo, password)
      return result
    } catch (error) {
      this.toastr.error(error,'Ha ocurrido un problema!',{
        timeOut:1500,
        closeButton:true
         })
    }
    return null
  }

  async loginGoogle(){
    try {
      const usuario = this.auth.signInWithPopup(new firebase.auth.GoogleAuthProvider())
      return usuario
    } catch (error) {
      this.toastr.error(error,'Ha ocurrido un problema!',{
        timeOut:1500,
        closeButton:true
         })
    }
    return null
  }

  async logout(){
    try {
      
      await this.auth.signOut()
    } catch (error) {
      console.log(error);
    }
    localStorage.removeItem('token')
  }

  obtenerUsuarioActual(){
    return this.auth.authState.pipe(first()).toPromise()
  }

  async loginFacebook() {
    return this.auth.signInWithPopup(new firebase.auth.FacebookAuthProvider())
  }

  async recuperarCuenta(correo:string){
    return this.auth.sendPasswordResetEmail(correo)
  }
  
  

}
