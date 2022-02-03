import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CarroDeComprasService } from '../../../services/carro-de-compras.service';

@Component({
  selector: 'app-carro-navbar',
  templateUrl: './carro-navbar.component.html',
  styleUrls: ['./carro-navbar.component.css']
})
export class CarroNavbarComponent implements OnInit {
/**
 * Constructor del componente Carro Navbar
 * @param carritoService 
 * @param router 
 */
  constructor(public carritoService:CarroDeComprasService,
    private router:Router) { }

  ngOnInit(): void {
  }
/**
 * redirecciona a la pantalla de pago
 */
  compra(){
    this.carritoService.finalizarCompra()
    this.router.navigateByUrl('tienda/finalizar-compra');
  }

}
