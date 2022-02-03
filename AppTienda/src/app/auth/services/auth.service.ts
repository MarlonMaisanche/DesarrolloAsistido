import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import firebase from 'node_modules/firebase/compat/app';
import { Observable } from 'rxjs';
import { first } from 'rxjs/operators';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class AuthService {


  public userData$: Observable<firebase.User>

  constructor(public auth:AngularFireAuth,
     private toastr:ToastrService,
     ) {
       this.userData$ = auth.authState
  }
/**
 * Funcion para crear un usuario con correo y contraseña
 * @param correo correo del usuario 
 * @param password contraseña de usuario 
 * @returns retorna un usuario 
 */
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
/**
 * Funcion para iniciar sesion un usuario con correo y contraseña
 * @param correo correo del usuario 
 * @param password contraseña de usuario 
 * @returns retorna un usuario 
 */
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
/**
 * Funcion para iniciar sesion con los ervicios de  google
 * @returns retorna un usuario 
 */
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
/**
 * Funcion para cerrar sesión
 */
  async logout(){
      await this.auth.signOut()
  }
/**
 * Funcion para obtener al usuario actual de la sesion
 * @returns retorna un usuario 
 */
  obtenerUsuarioActual(){
    return this.auth.authState.pipe(first()).toPromise()
  }
/**
 * Funcion para iniciar sesion con los servicios de facebook
 * @returns retorna un usuario 
 */
  async loginFacebook() {
    return this.auth.signInWithPopup(new firebase.auth.FacebookAuthProvider())
  }
/**
 * Funcion para recuprar cuenta de usuario
 * @returns retorna un usuario 
 */
  async recuperarCuenta(correo:string){
    return this.auth.sendPasswordResetEmail(correo)
  }
  
}
