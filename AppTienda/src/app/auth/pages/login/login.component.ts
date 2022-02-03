import { Component, Injectable } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../../services/auth.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
})

@Injectable({ providedIn : 'root'})
export class LoginComponent {

  constructor(private fb: FormBuilder,
    private auth: AuthService,
    private router: Router,
    private toastr: ToastrService,
    ) {
    
  }
  
  authForm: FormGroup = this.fb.group({
    correo: [localStorage.getItem('email') || '', [Validators.required, Validators.email]],
    password: ['', [Validators.required, Validators.minLength(6)]],
    recuerdame: [false],
  })

/**
 * Funcion para iniciar sesion con correo y contraseña  
 */
  async login() {
    try {
      if (this.authForm.value['recuerdame']) {
        localStorage.setItem('email', this.authForm.value['correo'])
      } else {
        localStorage.removeItem('email')
      }
      
     const usuario = await this.auth.loginCorreo(this.authForm.value['correo'],this.authForm.value['password'])
      if (usuario){
        this.router.navigateByUrl('');
        this.toastr.success(usuario.user.multiFactor['user']['displayName'] ,'Bien venido!',{
          timeOut:1500,
          closeButton:true
           })
      }
    } catch (error) {
      this.toastr.error('No se pudo iniciar sesión','Ha acorrito un problema!',{
        timeOut:1500,
        closeButton:true
         })
    }
  }
/**
 * Funcion para iniciar sesion con google 
 */
  async loginGoogle() {
    try {
      await this.auth.loginGoogle().then(data =>{
        this.router.navigateByUrl('')
        this.toastr.success(data.user.multiFactor['user']['displayName'],'Bien venido!',{
        timeOut:1500,
        closeButton:true
         })
      })
    } catch (error) {
      this.toastr.error('No se pudo iniciar sesión' ,'Ha ocurrido un problema!',{
        timeOut:1500,
        closeButton:true
         })
    }
  }
/**
 * Funcion para iniciar sesion con facebook 
 */
  async loginFacebook(){
    try {
      this.auth.loginFacebook().then(data =>{
        this.router.navigateByUrl('')
        this.toastr.success(data.user.multiFactor['user']['displayName'],'Bien venido!',{
        timeOut:1500,
        closeButton:true
         })
       })
    } catch (error) {
      this.toastr.error('No se pudo iniciar sesión' ,'Ha ocurrido un problema!',{
        timeOut:1500,
        closeButton:true
         })
    }
  }
}
