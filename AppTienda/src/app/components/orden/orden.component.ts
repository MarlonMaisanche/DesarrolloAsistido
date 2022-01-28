import { Component, OnInit } from '@angular/core';
import { FinalizarCompraService } from '../../services/finalizar-compra.service';
import { ActivatedRoute } from '@angular/router';
import { Pedido } from '../../models/Pedido';

@Component({
  selector: 'app-orden',
  templateUrl: './orden.component.html',
  styleUrls: ['./orden.component.css']
})
export class OrdenComponent implements OnInit {
  
  informacion:string = "Orden no establecida!" 
  descripcion:string = 'Ocurrió un inconvenieten al tratar de establecer la orden de compra, este problema puede deberse a que no se '+
  'encontró el identificador de la compra o puede deberse a que el pago no se realizó correctamente (insuficientes fondos, error en los '+
  'datos de la tarjeta, formularios de identificación o envío incompletos,etc.). Por favor intentelo más tarde.'
  pedido:Pedido
  loading:boolean = true

  constructor(private finalizarCompraService:FinalizarCompraService,
    private aRoute:ActivatedRoute) { }

  ngOnInit(): void {
    let id =  this.aRoute.snapshot.paramMap.get('id');
    if(id){
      this.finalizarCompraService.getPedido(id).subscribe(data =>{

        if(data.data() == undefined){
          this.loading = false
        }else{
          this.pedido = data.data() as Pedido
          this.pedido.Id = data.id
          this.loading = false
          if(this.pedido){
            this.informacion = 'Orden establecida exitosamente!'
            this.descripcion = 'La orden de compra se estableció de manera exitosa, recibirá un correo electrónico a la dirección '+ this.pedido.Correo + ' tan pronto cuando su pedido sea recibio y aceptado por la tienda. Gracias por su compra!'
          }
          console.log(this.pedido);
        }

        
      })
    }

  }

}
