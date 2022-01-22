import { ProductoCarrito } from './ProductoCarrito';
export interface Pedido {
    Id_Pago : string,
    Correo : string,
    Cliente : string,
    Cedula : string,
    Contacto : string,
    Estado : string,
    Fecha: Date,
    Envio : Envio,
    Productos : any,
    Total: number
}

interface Envio{
    Metodo : string,
    Provincia : string,
    Canton: string,
    CallePrincipal: string,
    CalleSecundaria: string,
    Piso: string,
    Referencia: string,
    Cedula_Receptor: string
}