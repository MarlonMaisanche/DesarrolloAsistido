import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CarroDeComprasService } from '../../../services/carro-de-compras.service';

@Component({
  selector: 'app-carro-navbar',
  templateUrl: './carro-navbar.component.html',
  styleUrls: ['./carro-navbar.component.css']
})
export class CarroNavbarComponent implements OnInit {

  constructor(public carritoService:CarroDeComprasService,
    private router:Router) { }

  ngOnInit(): void {
  }

  compra(){
    this.carritoService.finalizarCompra()
    this.router.navigateByUrl('tienda/finalizar-compra');
  }

}
