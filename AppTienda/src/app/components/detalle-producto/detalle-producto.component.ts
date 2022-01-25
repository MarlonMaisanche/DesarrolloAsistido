import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import Producto from '../../models/Producto';
import { ProductosService } from '../../services/productos.service';
import { Carrito } from '../../models/Carrito';
import { ProductoCarrito } from '../../models/ProductoCarrito';
import { CarroDeComprasService } from '../../services/carro-de-compras.service';

@Component({
  selector: 'app-detalle-producto',
  templateUrl: './detalle-producto.component.html',
  styleUrls: ['./detalle-producto.component.css']
})
export class DetalleProductoComponent implements OnInit {


  producto: Producto
  cantidad: number = 1
  imagenes:string[] = [];

  constructor(private productosService:ProductosService,
    private ruta: ActivatedRoute,
    private router:Router,
    private carritoService : CarroDeComprasService) { }

  ngOnInit(): void {
    this.obtenerProducto(this.ruta.snapshot.params.id)
  }

  obtenerProducto(Id:string){
    if(Id != null){
      this.productosService.getProducto(Id).subscribe(data =>{
        this.producto = data.data() as Producto
        this.producto.Id = data.id
        console.log(this.producto);
        if (this.producto.Imagen != 'Sin imagen'){
          this.imagenes.push(this.producto.Imagen)
        }
        if (this.producto.Imagen2 != 'Sin imagen'){
          this.imagenes.push(this.producto.Imagen2)
        }
        if (this.producto.Imagen3 != 'Sin imagen'){
          this.imagenes.push(this.producto.Imagen3)
        }
        console.log(this.imagenes[0]);
      })

    }
  }

  agregarACarrito(Id:string){
    let carrito:Carrito = {
      IdProducto : Id,
      cantidad: this.cantidad,
    
    }
    console.log(carrito.cantidad);
    this.carritoService.agregarProducto(carrito);
    this.router.navigateByUrl('/carrito')
    console.log(this.cantidad);
  }

  compraRapida(producto:Producto){
    let precio = producto.Oferta ? producto.Precio_Oferta : producto.Precio
    let productoRapido:ProductoCarrito = {
      Cantidad: this.cantidad,
      Categoria: producto.Categoria,
      IdProducto: producto.Id,
      Nombre: producto.Nombre,
      Imagen: "",
      Precio: precio,
      Subtotal: precio * this.cantidad
    }
    this.carritoService.finalizarCompra(productoRapido)
    this.router.navigateByUrl('tienda/finalizar-compra');
  }

}
