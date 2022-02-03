import { AngularFirestore } from "@angular/fire/compat/firestore";
import { Subject } from "rxjs";
import { EncriptarDesService } from "../services/encriptar-des.service";
import { Carrito } from "./Carrito";
import Producto from "./Producto";
import { ProductoCarrito } from "./ProductoCarrito";


export class CarroCompras {
    carrito: Carrito[]
    productosCarrito: ProductoCarrito[]
    productoRapido: ProductoCarrito
    total$ = new Subject<number>()
    total: number
/**
 * 
 * @param cryptService servicio de encriptación
 * @param firestore 
 */
    constructor(
        private cryptService: EncriptarDesService,
        private firestore: AngularFirestore
    ) {
        this.productosCarrito = []
        this.obtenerCarrito()
    }
/**
 * Agrega un item al carrito
 * @param carrito 
 */
    agregarACarrito(carrito: Carrito) {

        if(!this.carrito){
            this.carrito = []
        }
        let existe = this.carrito.find(x => x.IdProducto == carrito.IdProducto) 
        
        if (!existe) {
            this.carrito.push(carrito)
            this.firestore.doc('Productos/' + carrito.IdProducto).get().subscribe(data => {
                let producto: Producto = data.data() as Producto;
                let precio: number, subtotal: number;
                let imagen: string;
                precio = producto.Oferta ? producto.Precio_Oferta : producto.Precio
                if (producto.Imagen != 'Sin imagen') {
                    imagen = producto.Imagen
                } else if (producto.Imagen == 'Sin imagen' && producto.Imagen2 != 'Sin imagen') {
                    imagen = producto.Imagen2
                } else {
                    imagen = producto.Imagen3
                }
                subtotal = carrito.cantidad * precio
                this.productosCarrito.push({
                    IdProducto: carrito.IdProducto,
                    Cantidad: carrito.cantidad,
                    Imagen: imagen,
                    Precio: precio,
                    Nombre: producto.Nombre,
                    Subtotal: subtotal,
                    Categoria: producto.Categoria
                })
                this.obtenerTotal()

            })
        } else {
            let prod = this.carrito.find(x => x.IdProducto == carrito.IdProducto)
            prod.cantidad =
                prod.cantidad + carrito.cantidad
            let prod2 = this.productosCarrito.find(x => x.IdProducto == carrito.IdProducto)
            prod2.Cantidad = prod2.Cantidad + carrito.cantidad
            prod2.Subtotal = prod2.Cantidad * prod2.Precio
        }
        let valor = this.cryptService.Encrypt(JSON.stringify(this.carrito))
        localStorage.setItem('k@3!t0', valor);
        this.obtenerTotal()
    }
/**
 * Realiza un acompra rapida
 * @param producto 
 */
    establecerProductoRapido(producto: ProductoCarrito) {
        if (producto) {
            this.productoRapido = producto
        } else {
            this.productoRapido = null
        }
    }
/**
 * Comprueba tipo de compra se realizara
 * @returns 
 */
    existeProductoRapido(): boolean {
        return this.productoRapido ? true : false;
    }
/**
 * Obtiene el total de la orden de compra
 */
    obtenerTotal() {
        let total = 0
        this.productosCarrito.forEach(element => {
            total += element.Subtotal
        })
        this.total$.next(total)
        this.total = total
    }
/**
 * Obtiene los datos del carrito
 */
    obtenerCarrito() {
        if (localStorage.getItem('k@3!t0')) {
            try {
                let valor: string = localStorage.getItem('k@3!t0')
                let carrito = this.cryptService.Decrypt(valor);
                this.carrito = JSON.parse(carrito)

                this.carrito.forEach(async element => {
                    await this.firestore.doc('Productos/' + element.IdProducto).get().subscribe(data => {
                        let producto: Producto = data.data() as Producto;
                        if (producto.Estado) {
                            let precio: number, subtotal: number;
                            let imagen: string;
                            precio = producto.Oferta ? producto.Precio_Oferta : producto.Precio
                            if (producto.Imagen != 'Sin imagen') {
                                imagen = producto.Imagen
                            } else if (producto.Imagen == 'Sin imagen' && producto.Imagen2 != 'Sin imagen') {
                                imagen = producto.Imagen2
                            } else {
                                imagen = producto.Imagen3
                            }
                            subtotal = element.cantidad * precio
                            this.productosCarrito.push({
                                IdProducto: element.IdProducto,
                                Cantidad: element.cantidad,
                                Imagen: imagen,
                                Precio: precio,
                                Nombre: producto.Nombre,
                                Subtotal: subtotal,
                                Categoria: producto.Categoria
                            })
                            this.obtenerTotal()
                        } else {
                            this.carrito.slice(this.carrito.findIndex(x => x.IdProducto == element.IdProducto))
                            let valor = this.cryptService.Encrypt(JSON.stringify(this.carrito))
                            localStorage.setItem('k@3!t0', valor);
                        }
                    })
                })

            } catch (error) {
                localStorage.clear();
                this.carrito = []
                this.total$.next(0)
            }
        }else{
            let valor = this.cryptService.Encrypt(JSON.stringify(this.carrito))
            localStorage.setItem('k@3!t0', valor);
        }
    }
/**
 * Elimina un item del producto
 * @param Id Identificardor del producto
 */
    eliminarProducto(Id: string) {
        let indiceCarrito: number = this.carrito.findIndex(x => x.IdProducto == Id)
        let indiceProductos: number = this.productosCarrito.findIndex(x => x.IdProducto == Id)
        this.carrito.splice(indiceCarrito, 1)
        this.productosCarrito.splice(indiceProductos, 1)
        let valor = this.cryptService.Encrypt(JSON.stringify(this.carrito))
        localStorage.setItem('k@3!t0', valor);
        this.obtenerTotal()
    }
/**
 * Guarda los items del carrito 
 */
    guardarCambios() {
        let valor = this.cryptService.Encrypt(JSON.stringify(this.carrito))
        localStorage.setItem('k@3!t0', valor);
    }
}

