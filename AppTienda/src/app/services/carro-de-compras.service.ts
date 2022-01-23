import { Injectable } from '@angular/core';
import { AngularFirestore } from '@angular/fire/compat/firestore';
import { EncriptarDesService } from './encriptar-des.service';
import { Carrito } from '../models/Carrito';
import { ProductoCarrito } from '../models/ProductoCarrito';
import { CarroCompras } from '../models/CarroCompras';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CarroDeComprasService {

  constructor(
    private cryptService: EncriptarDesService,
    private firestore: AngularFirestore
  ) { 
     this.carroCompras = new CarroCompras(this.cryptService, this.firestore); 
  }

  carroCompras:CarroCompras 

  obtenerProductos(){
    return this.carroCompras.productosCarrito
  }

  guardarCambios(){
    this.carroCompras.guardarCambios()
  }

  obtenerProductoRapido(){
    return this.carroCompras.productoRapido
  }

  existeProductoRapido():boolean{
    return  this.carroCompras.existeProductoRapido()
  }

  finalizarCompra( producto?: ProductoCarrito){
    this.carroCompras.establecerProductoRapido( producto )
  }

  obtenerTotal(): Observable<number>{
    return this.carroCompras.total$.asObservable()
  }

  agregarProducto(producto: Carrito){
    this.carroCompras.agregarACarrito(producto)
  }

  eliminarProducto( id: string ){
    this.carroCompras.eliminarProducto(id)
  }
 
}
