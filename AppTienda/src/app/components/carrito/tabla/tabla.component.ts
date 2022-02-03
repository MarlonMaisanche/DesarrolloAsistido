import { Component, OnInit } from '@angular/core';
import { Carrito } from 'src/app/models/Carrito';
import { CarroDeComprasService } from '../../../services/carro-de-compras.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-tabla',
  templateUrl: './tabla.component.html',
  styleUrls: ['./tabla.component.css']
})
export class TablaComponent implements OnInit {

  constructor(public carritoService:CarroDeComprasService,
    private toastr:ToastrService) { }

  ngOnInit(): void {
  }
/**
 * Suma todos los items del carrito de compras
 * @param carrito 
 */
  sumar(carrito:Carrito){
    this.carritoService.agregarProducto(carrito)
  }
/**
 * Elimina un item del carrito de compras
 * @param Id 
 */
  eliminarDeCarrito(Id:string){
    this.carritoService.eliminarProducto(Id)
    this.toastr.error('Se eliminó un producto del carrito','Carrito!',{
      timeOut:1500,
      closeButton:true
    })
  }
/**
 * Cambia la cantidad de un item del carrito
 * @param valor cantidad nueva
 * @param id identificador del carrito
 */
  cambioCantidad(valor:number, id:string){
    let existe = this.carritoService.carroCompras.carrito.find(x => x.IdProducto == id)
    let producto = this.carritoService.carroCompras.productosCarrito.find(x => x.IdProducto == id)
    if(existe){
      existe.cantidad = valor
      producto.Cantidad = valor
      producto.Subtotal = producto.Cantidad * producto.Precio
      this.carritoService.guardarCambios()
      this.carritoService.carroCompras.obtenerTotal()
    }
  }

}
