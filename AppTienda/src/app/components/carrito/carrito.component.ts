import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CarroDeComprasService } from '../../services/carro-de-compras.service';

@Component({
  selector: 'app-carrito',
  templateUrl: './carrito.component.html',
  styleUrls: ['./carrito.component.css']
})
export class CarritoComponent implements OnInit {

  constructor(
    private router:Router,
    public carritoService:CarroDeComprasService) { }

  ngOnInit(): void {
  }

  volverATienda(){
    this.router.navigateByUrl('/tienda');
  }

  comprar(){
    this.carritoService.finalizarCompra()
    this.router.navigateByUrl('/tienda/finalizar-compra')
  }
}
