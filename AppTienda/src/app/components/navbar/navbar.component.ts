import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../auth/services/auth.service';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { ToastrService } from 'ngx-toastr';
@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent   {

  usuario$: Observable<any> = this.authService.auth.user

  constructor(public authService: AuthService,
    private router: Router,
    private toastr: ToastrService,
  ) { }

  async cerrarSesion() {
    try {
      await this.authService.logout()
      this.router.navigateByUrl('')
      this.toastr.info('', 'Hasta pronto!', {
        timeOut: 1500,
        closeButton: true
      })

    } catch (error) {
      console.log(error);
    }
  }

}
