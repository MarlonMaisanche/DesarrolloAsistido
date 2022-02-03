import { Injectable } from '@angular/core';
import { AngularFirestore } from '@angular/fire/compat/firestore';

@Injectable({
  providedIn: 'root'
})
export class ProductosService {

  constructor( private firestore: AngularFirestore) { 
    
  }
/**
 * Obtine la lista de productos
 * @returns lista de productos
 */
  getProductos(){
    return this.firestore.collection('Productos', ref => ref.where('Estado', '==', true)).snapshotChanges()
  }
/**
 * Obtine la lista de productos
 * @returns lista de productos
 */
  getAll(){
    return this.firestore.collection('Productos', ref => ref.where('Estado', '==', true)).snapshotChanges()
  }
  /**
   * Obtiene un producto por su valor de Id
   * @param id 
   * @returns un producto
   */
  getProducto(id:string){
    return this.firestore.collection('Productos').doc(id).get()
  }

}
