import { ProductoCarrito } from './ProductoCarrito';
export interface Pedido {
    Id? : string,
    Id_Pago : string,
    Correo : string,
    Cliente : string,
    Cedula : string,
    Contacto : string,
    Estado : string,
    Fecha: string,
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