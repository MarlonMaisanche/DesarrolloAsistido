import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { CarritoComponent } from './components/carrito/carrito.component';
import { ProductosComponent } from './components/productos/productos.component';
import { FinalizarCompraComponent } from './components/finalizar-compra/finalizar-compra.component';
import { DetalleProductoComponent } from './components/detalle-producto/detalle-producto.component';
import { OrdenComponent } from './components/orden/orden.component';
import { AuthGuard } from './guards/auth.guard';
import { LoginGuard } from './guards/login.guard';

const routes: Routes = [
  {path: '' , component: HomeComponent},
  {path: 'auth' , loadChildren: () => import('./auth/auth.module').then( m => m.AuthModule) , canActivate: [LoginGuard]},
  {path: 'login' , loadChildren: () => import('./auth/auth.module').then( m => m.AuthModule) , canActivate: [LoginGuard]},
  {path: 'registro' , loadChildren: () => import('./auth/auth.module').then( m => m.AuthModule) , canActivate: [LoginGuard]},
  {path: 'recuperacion' , loadChildren: () => import('./auth/auth.module').then( m => m.AuthModule) , canActivate: [LoginGuard]},
  {path: 'carrito' , component:CarritoComponent  },
  {path: 'tienda/producto/:id' , component:DetalleProductoComponent },
  {path: 'tienda', component: ProductosComponent},
  {path: 'tienda/finalizar-compra', component: FinalizarCompraComponent, canActivate: [AuthGuard]},
  {path: 'tienda/finalizar-compra/orden/:id', component: OrdenComponent, canActivate: [AuthGuard] },
  {path: '**' , redirectTo: ''}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
