import { Component, OnInit } from '@angular/core';
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

  constructor(private auth:AuthService,
    private fb:FormBuilder,
    private router:Router,
    private toastr:ToastrService) { }

  authForm:FormGroup = this.fb.group({
    correo: ['',[Validators.required, Validators.email]],
    password:['',[Validators.required,Validators.minLength(6)]],
    password2:['',[Validators.required,Validators.minLength(6)]],
  })

  async registrarUsuario(){
    try {
      if(this.authForm.value['password'] == this.authForm.value['password2']){
        const usuario = await this.auth.crearUsuario(this.authForm.value['correo'],
        this.authForm.value['password'])
        if(usuario){
          let valor = usuario.user.multiFactor['user']['accessToken'];
          localStorage.setItem('token',valor)
          this.router.navigateByUrl('')
          this.toastr.success(usuario.user.multiFactor['user']['displayName'] ,'Bien venido!',{
            timeOut:1500,
            closeButton:true
             })
        }
      }
    } catch (error) {
      this.authForm.reset()
      this.toastr.error('No se pudo registrar' ,'Ha ocurrido un problema!',{
        timeOut:1500,
        closeButton:true
         })
    }
    
  }

  async registrarGoogle(){
    try {
      this.auth.loginGoogle().then(data =>{
        const usuario = data.user.multiFactor['user']
        if(usuario){
          let valor = usuario.user.multiFactor['user']['accessToken'];
          localStorage.setItem('token',valor)
          this.router.navigateByUrl('')
          this.toastr.success(usuario.user.multiFactor['user']['displayName'] ,'Bien venido!',{
            timeOut:1500,
            closeButton:true
             })
        }
      })
      
    } catch (error) {
      console.log(error);
      this.toastr.error('No se pudo registrar' ,'Ha ocurrido un problema!',{
        timeOut:1500,
        closeButton:true
         })
    }
  }

  async loginFacebook(){
    try {
      this.auth.loginFacebook().then(data =>{
        const usuario = data.user.multiFactor['user']
        if(usuario){
          let valor = data.user.multiFactor['user']['accessToken'];
          localStorage.setItem('token',valor)
          this.toastr.success(data.user.multiFactor['user']['displayName'],'Bien venido!',{
          timeOut:1500,
          closeButton:true
           })
           this.router.navigateByUrl('')
        }
       })
    } catch (error) {
      this.toastr.error('No se pudo iniciar sesión' ,'Ha ocurrido un problema!',{
        timeOut:1500,
        closeButton:true
         })
    }
  }

}
