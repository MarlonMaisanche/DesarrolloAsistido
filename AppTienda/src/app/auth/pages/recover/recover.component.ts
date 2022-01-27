import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../../services/auth.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-recover',
  templateUrl: './recover.component.html',
  styleUrls: ['./recover.component.css']
})
export class RecoverComponent implements OnInit {

  constructor(private fb: FormBuilder,
    private auth: AuthService,
    private toastr:ToastrService) { }

  ngOnInit(): void {
  }

  authForm: FormGroup = this.fb.group({
    correo: [localStorage.getItem('email') || '', [Validators.required, Validators.email]],
  })

  recuperar(){
    this.auth.recuperarCuenta(this.authForm.value['correo'])
    this.toastr.success('','Correo enviado!',{
      timeOut:1500,
      closeButton:true
       })
  }

}
