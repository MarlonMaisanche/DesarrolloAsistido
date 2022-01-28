import { Injectable } from '@angular/core';
import { AngularFirestore, DocumentSnapshot } from '@angular/fire/compat/firestore';
import { Pedido } from '../models/Pedido';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FinalizarCompraService {

  constructor( private firestore: AngularFirestore ) { }


  crearPedido(pedido:Pedido ) {
    return this.firestore.collection('Pedidos').add(pedido)
  }

  getPedido(id:string){
    return this.firestore.collection('Pedidos').doc(id).get()
  }


}
