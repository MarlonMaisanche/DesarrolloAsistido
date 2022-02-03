import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainComponent } from './pages/main/main.component';
import { LoginComponent } from './pages/login/login.component';
import { RegisterComponent } from './pages/register/register.component';
import { RecoverComponent } from './pages/recover/recover.component';
/**
 * Rutas para el modulo de  login
 */
const routes: Routes = [
  {
    path:'',
    component:MainComponent,
    children: [
      { path: 'login', component: LoginComponent},
      { path: 'registro', component: RegisterComponent},
      { path: 'recuperacion', component: RecoverComponent},
      { path: '**', redirectTo: 'login'},
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AuthRoutingModule { }
