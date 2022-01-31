import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { AngularFireModule } from "@angular/fire/compat";
import { environment } from "../environments/environment";
import { AuthModule } from './auth/auth.module';
import { CarruselComponent } from './components/home/carrusel/carrusel.component';
import { MarketingComponent } from './components/home/marketing/marketing.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { CarroNavbarComponent } from './components/navbar/carro-navbar/carro-navbar.component'
import { CarritoComponent } from './components/carrito/carrito.component';
import { ProductosComponent } from './components/productos/productos.component';
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
import { OrdenComponent } from './components/orden/orden.component';
import { FooterComponent } from './components/footer/footer.component';

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
    OrdenComponent,
    FooterComponent,
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
