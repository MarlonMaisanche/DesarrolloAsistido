import { Component, OnInit } from '@angular/core';
import { ProductoCarrito } from '../../models/ProductoCarrito';
import { ICreateOrderRequest, IPayPalConfig } from 'ngx-paypal';
import { environment } from '../../../environments/environment';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Provincias } from '../../../assets/data';
import { CarroDeComprasService } from '../../services/carro-de-compras.service';
import { Pedido } from '../../models/Pedido';
import { FinalizarCompraService } from '../../services/finalizar-compra.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-finalizar-compra',
  templateUrl: './finalizar-compra.component.html',
  styleUrls: ['./finalizar-compra.component.css']
})

export class FinalizarCompraComponent implements OnInit {

  public payPalConfig?: IPayPalConfig
  infoForm: FormGroup
  envioForm: FormGroup
  provincias: any
  cantones: any
  metodoEnvio: boolean = false
  itemEnvio: any
  total: number
  productos: ProductoCarrito[]
  produto: ProductoCarrito


  constructor(
    public carritoService: CarroDeComprasService,
    private formBuilder: FormBuilder,
    private finalizarCompra: FinalizarCompraService,
    private router: Router,
    private toastr:ToastrService) {
    this.infoForm = this.crearFormularioInfo()
    this.envioForm = this.crearFormularioEnvio()
  }

  ngOnInit(): void {
    this.initConfig()
    if (this.carritoService.existeProductoRapido()) {
      this.produto = this.carritoService.obtenerProductoRapido()
      this.productos = []
      this.productos.push(this.produto)
      this.total = this.produto.Subtotal
    } else {
      this.total = this.carritoService.carroCompras.total
      this.carritoService.obtenerTotal().subscribe(numero => this.total = numero)
      this.productos = this.carritoService.obtenerProductos()
    }
    this.cargarProvincias()
  }

  private initConfig(): void {
    this.payPalConfig = {
      currency: 'USD',
      clientId: environment.clientId,
      createOrderOnClient: (data) => <ICreateOrderRequest>{
        intent: 'CAPTURE',
        purchase_units: [{
          amount: {
            currency_code: 'USD',
            value: Number(this.total.toFixed(2)).toString(),
            breakdown: {
              item_total: {
                currency_code: 'USD',
                value:  Number(this.total.toFixed(2)).toString(),
              }
            }
          },
          items: this.obtenerItems()
        }]
      },
      advanced: {
        commit: 'true'
      },
      style: {
        label: 'paypal',
        layout: 'vertical'
      },
      onApprove: (data, actions) => {

      },
      onClientAuthorization: (data) => {
        let envio: any
        let pedido: Pedido = null
        if (data.status == 'COMPLETED' && data.id) {
          if (this.metodoEnvio) {

            envio = {
              CallePrincipal: this.envioForm.value['callePrincipal'],
              CalleSecundaria: this.envioForm.value['calleSecundaria'],
              Canton: this.envioForm.value['canton'],
              Cedula_Receptor: this.envioForm.value['cedulaRecibe'],
              Metodo: 'A domicilio',
              Piso: this.envioForm.value['piso'],
              Provincia: this.envioForm.value['provincia'],
              Referencia: this.envioForm.value['referencia']
            }

          } else {
            envio = {
              Metodo: 'Retiro en local',
            }
          }

          let fecha = new Date()


          pedido = {
            Cedula: this.infoForm.value['cedula'],
            Cliente: this.infoForm.value['nombre'] + ' ' + this.infoForm.value['apellidos'],
            Contacto: this.infoForm.value['telefono'],
            Correo: this.infoForm.value['correo'],
            Envio: envio,
            Estado: 'Pendiente',
            Fecha: fecha.getFullYear() + '/' + fecha.getMonth() + '/' + fecha.getDay() + ' T ' +
              fecha.getHours() + ':' + fecha.getMinutes() + ':' + fecha.getSeconds(),
            Id_Pago: data.id,
            Productos: this.itemsPedido(),
            Total: this.total

          }
        }

        this.finalizarCompra.crearPedido(pedido).then( data => {
          console.log(data.id);
          this.router.navigateByUrl('tienda/finalizar-compra/orden/'+data.id);
        })
        

      },
      onCancel: (data, actions) => {
        console.log('OnCancel', data, actions);
        

      },
      onError: err => {
        console.log('OnError', err);

      },
      onClick: (data, actions) => {
        if(this.infoForm.invalid){
          this.resetStatus()
        }else{
          if(this.metodoEnvio){
            if(this.envioForm.value['envio'] == 2){
              this.resetStatus()
            }
          }
        }
      }
    };
    
  }

  private resetStatus(): void {
    this.toastr.error('' ,'Verifique los datos!',{
      timeOut:1500,
      closeButton:true
       })
       this.router.navigateByUrl('tienda/finalizar-compra/orden/cancelada')
  }

  itemsPedido(): any {
    const items: any[] = []
    let item = {}
    this.productos.forEach((it: ProductoCarrito) => {
      item = {
        Id: it.IdProducto,
        Nombre: it.Nombre,
        Cantidad: it.Cantidad,
        Precio: it.Precio,
        Subtotal: it.Cantidad * it.Precio
      }
      items.push(item)
    })
    if (this.itemEnvio) {
      items.push(item = {
        Id: 'Envio',
        Nombre: 'Envio',
        Cantidad: 1,
        Precio: 5,
        Subtotal: 5
      })
    }
    return items
  }

  obtenerItems(): any {
    const items: any[] = []
    let item = {}
    this.productos.forEach((it: ProductoCarrito) => {
      item = {
        name: it.Nombre,
        quantity: it.Cantidad.toString(),
        unit_amount: {
          value: it.Precio.toString(),
          currency_code: 'USD'
        }
      }
      items.push(item)
    })
    if (this.itemEnvio) {
      items.push(this.itemEnvio)
    }
    return items
  }

  cargarProvincias() {
    this.provincias = Provincias.Provincias
  }

  cargarCantones(provincia: string) {
    this.cantones = Provincias?.[provincia].sort() || null
  }

  onSelect(provincia: any): void {
    this.cargarCantones(provincia.value)
  }

  envio(event: any) {
    console.log(event.value);
    if (event.value == '1') {
      this.metodoEnvio = false
      if (this.itemEnvio) {
        this.itemEnvio = null
        this.total -= 5
      }
    } else {
      this.metodoEnvio = true;
      if (!this.itemEnvio) {
        this.itemEnvio = {
          name: 'Costo envío',
          quantity: '1',
          unit_amount: {
            value: '5',
            currency_code: 'USD'
          }
        }
        this.total += 5
      }
    }
  }

  crearFormularioInfo() {
    return this.formBuilder.group({
      correo: ['', [Validators.required, Validators.email]],
      nombre: ['', [Validators.required]],
      apellidos: ['', [Validators.required]],
      cedula: ['', [Validators.required, Validators.maxLength(13), Validators.minLength(10)]],
      telefono: ['', [Validators.required, Validators.maxLength(10), Validators.minLength(7)]]
    })
  }

  crearFormularioEnvio() {
    return this.formBuilder.group({
      envio: ['', [Validators.required]],
      provincia: ['', [Validators.required]],
      canton: ['', [Validators.required]],
      callePrincipal: ['', [Validators.required]],
      calleSecundaria: ['', [Validators.required]],
      piso: ['', [Validators.required]],
      referencia: ['', [Validators.required]],
      cedulaRecibe: ['', [Validators.required]]
    })
  }


}





