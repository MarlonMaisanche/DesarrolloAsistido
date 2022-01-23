export interface ProductoCarrito {
    IdProducto: string,
    Nombre: string,
    Cantidad: number,
    Precio: number,
    Imagen?: string,
    Subtotal: number;
    Categoria?: string
}

