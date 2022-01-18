import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { CarritoComponent } from './components/carrito/carrito.component';
import { ProductosComponent } from './components/productos/productos.component';
import { FinalizarCompraComponent } from './components/finalizar-compra/finalizar-compra.component';
import { DetalleProductoComponent } from './components/detalle-producto/detalle-producto.component';

const routes: Routes = [
  {path: '' , component: HomeComponent},
  {path: 'auth' , loadChildren: () => import('./auth/auth.module').then( m => m.AuthModule) },
  // {path: 'pedidos' , loadChildren: () => import('./protected/protected.module').then( m => m.ProtectedModule) },
  {path: 'carrito' , component:CarritoComponent  },
  {path: 'tienda/producto/:id' , component:DetalleProductoComponent },
  {path: 'tienda', component: ProductosComponent},
  {path: 'tienda/finalizar-compra', component: FinalizarCompraComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
