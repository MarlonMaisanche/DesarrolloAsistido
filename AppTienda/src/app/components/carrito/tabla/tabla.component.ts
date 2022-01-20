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

  sumar(carrito:Carrito){
    this.carritoService.agregarProducto(carrito)
  }

  eliminarDeCarrito(Id:string){
    this.carritoService.eliminarProducto(Id)
    this.toastr.error('Se eliminó un producto del carrito','Carrito!',{
      timeOut:1500,
      closeButton:true
    })
  }

  cambioCantidad(valor:number, id:string){
    console.log(valor,id);
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
