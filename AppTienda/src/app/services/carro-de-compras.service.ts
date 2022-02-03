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
/**
 * Obtien los productos que contiene el carrito de compras
 * @returns lista de productos 
 */
  obtenerProductos(){
    return this.carroCompras.productosCarrito
  }
/**
 * Gaurda los cambios del carrito de compras
 */
  guardarCambios(){
    this.carroCompras.guardarCambios()
  }
/**
 * Obtine el producto de la compra rapida
 * @returns producto 
 */
  obtenerProductoRapido(){
    return this.carroCompras.productoRapido
  }
/**
 * Comprueba la existencia de un producto rapido
 * @returns valor boleano
 */
  existeProductoRapido():boolean{
    return  this.carroCompras.existeProductoRapido()
  }
/**
 * Finaliza el proceso de compra
 * @param producto 
 */
  finalizarCompra( producto?: ProductoCarrito){
    this.carroCompras.establecerProductoRapido( producto )
  }
/**
 * Obtine el total del carrito de compras
 * @returns total del carrito de compras
 */
  obtenerTotal(): Observable<number>{
    return this.carroCompras.total$.asObservable()
  }
/**
 * Agrega un producto al carrito de compras
 * @param producto 
 */
  agregarProducto(producto: Carrito){
    this.carroCompras.agregarACarrito(producto)
  }
/**
 * Elimina un producto del carrito de compras
 * @param id Identificador del producto
 */
  eliminarProducto( id: string ){
    this.carroCompras.eliminarProducto(id)
  }
 
}
