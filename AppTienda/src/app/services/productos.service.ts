import { Injectable } from '@angular/core';
import { AngularFirestore } from '@angular/fire/compat/firestore';

@Injectable({
  providedIn: 'root'
})
export class ProductosService {

  constructor( private firestore: AngularFirestore) { 
    
  }

  getProductos(){
    return this.firestore.collection('Productos', ref => ref.where('Estado', '==', true)).snapshotChanges()
  }

  getAll(){
    return this.firestore.collection('Productos', ref => ref.where('Estado', '==', true)).snapshotChanges()
  }
  
  getProducto(id:string){
    return this.firestore.collection('Productos').doc(id).get()
  }

}
