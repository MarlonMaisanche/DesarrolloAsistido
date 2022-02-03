import { Injectable } from '@angular/core';
import { AngularFirestore } from '@angular/fire/compat/firestore';
import { Pedido } from '../models/Pedido';

@Injectable({
  providedIn: 'root'
})
export class FinalizarCompraService {

  constructor( private firestore: AngularFirestore ) { }

/**
 * Crea un pedido
 * @param pedido 
 * @returns retorna un pedido
 */
  crearPedido(pedido:Pedido ) {
    return this.firestore.collection('Pedidos').add(pedido)
  }
/**
 * Obtiene el pedido utilizando el id del pedido
 * @param id Identificar del pedido
 * @returns 
 */
  getPedido(id:string){
    return this.firestore.collection('Pedidos').doc(id).get()
  }


}
