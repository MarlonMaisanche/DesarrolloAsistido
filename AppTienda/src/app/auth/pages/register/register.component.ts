import { Component} from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {

  constructor(
    private auth:AuthService,
    private fb:FormBuilder,
    private router:Router,
    private toastr:ToastrService
    ) { }

  authForm:FormGroup = this.fb.group({
    correo: ['',[Validators.required, Validators.email]],
    password:['',[Validators.required,Validators.minLength(6)]],
    password2:['',[Validators.required,Validators.minLength(6)]],
  })
/**
 * Funcion para registrar un usuario con correo y contraseña 
 */
  async registrarUsuario(){
    try {
      if(this.authForm.value['password'] == this.authForm.value['password2']){
        const usuario = await this.auth.crearUsuario(this.authForm.value['correo'],
        this.authForm.value['password'])
        if(usuario){

          this.router.navigateByUrl('')
          this.toastr.success(usuario.user.multiFactor['user']['displayName'] ,'Bienvenido!',{
            timeOut:1500,
            closeButton:true
             })
        }
      }
    } catch{
      this.authForm.reset()
      this.toastr.error('No se pudo registrar' ,'Ha ocurrido un problema!',{
        timeOut:1500,
        closeButton:true
         })
    }
    
  }
/**
 * Funcion para registrar un usuario utilizando el api de google
 */
  async registrarGoogle(){
    try {
      this.auth.loginGoogle().then(data =>{
        const usuario = data.user.multiFactor['user']
        if(usuario){
          this.router.navigateByUrl('')
          this.toastr.success(usuario.user.multiFactor['user']['displayName'] ,'Bienvenido!',{
            timeOut:1500,
            closeButton:true
             })
        }
      })
    } catch  {
      this.toastr.error('No se pudo registrar' ,'Ha ocurrido un problema!',{
        timeOut:1500,
        closeButton:true
         })
    }
  }
  /**
 * Funcion para registrar un usuario utilizando el api de facebook
 */
  async loginFacebook(){
    try {
      this.auth.loginFacebook().then(data =>{
        const usuario = data.user.multiFactor['user']
        if(usuario){
          
          this.toastr.success(data.user.multiFactor['user']['displayName'],'Bienvenido!',{
          timeOut:1500,
          closeButton:true
           })
           this.router.navigateByUrl('')
        }
       })
    } catch (error){
      this.toastr.error('No se pudo iniciar sesión' ,'Ha ocurrido un problema!',{
        timeOut:1500,
        closeButton:true
         })
        console.error(error);
        
         
    }
  }
}
