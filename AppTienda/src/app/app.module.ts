import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
// import firebase from 'node_modules/firebase/compat';
import { AngularFireModule } from "@angular/fire/compat";
import { environment } from "../environments/environment";
import { AuthModule } from './auth/auth.module';
import { CarruselComponent } from './components/home/carrusel/carrusel.component';
import { MarketingComponent } from './components/home/marketing/marketing.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { CarroNavbarComponent } from './components/navbar/carro-navbar/carro-navbar.component'
// import { ToastrModule, ToastrService } from 'ngx-toastr';
import { CarritoComponent } from './components/carrito/carrito.component';
import { ProductosComponent } from './components/productos/productos.component';
// import { NgxPaginationModule } from 'ngx-pagination'; 
import { NgxPaginationModule } from 'ngx-pagination';
import { AngularFirestoreModule } from '@angular/fire/compat/firestore';
import { AngularFireDatabaseModule } from '@angular/fire/compat/database';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TablaComponent } from './components/carrito/tabla/tabla.component';
import { FinalizarCompraComponent } from './components/finalizar-compra/finalizar-compra.component';
import { DetalleProductoComponent } from './components/detalle-producto/detalle-producto.component';
import { NgxPayPalModule } from 'ngx-paypal';
import { NgxSpinnerModule } from 'ngx-spinner';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CarruselComponent,
    MarketingComponent,
    NavbarComponent,
    CarroNavbarComponent,
    CarritoComponent,
    ProductosComponent,
    TablaComponent,
    FinalizarCompraComponent,
    DetalleProductoComponent,
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AngularFireModule.initializeApp(environment.firebaseConfig),
    AuthModule,
    ReactiveFormsModule,
    FormsModule,
    AngularFirestoreModule,
    AngularFireDatabaseModule,
    NgxPaginationModule, 
    NgxPayPalModule,
    NgxSpinnerModule,
    ToastrModule.forRoot(),
    BrowserAnimationsModule,
  ],
  providers: [
  ],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }
