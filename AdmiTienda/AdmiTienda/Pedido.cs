using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmiTienda
{
    class Pedido
    {
        public string Id { get; set; }

        public string Cedula { get; set; }

        public string Cliente { get; set; }

        public string Contacto { get; set; }

        public string Correo { get; set; }

        public string Estado { get; set; }

        public DateTime Fecha { get; set; }

        public string Id_Pago { get; set; }

        public double Total { get; set; }

        public List<Productos> Productos { get; set; }

        public Envio Envio { get; set; }
    }


    class PedidoList
    {
        public string Id { get; set; }

        public string Cedula { get; set; }

        public string Cliente { get; set; }

        public string Contacto { get; set; }

        public string Correo { get; set; }

        public string Estado { get; set; }

        public DateTime Fecha { get; set; }

        public string Id_Pago { get; set; }

        public double Total { get; set; }

        public string Metodo_Envio{ get; set; }
        
    }


    class Productos
    {
        [FirestoreProperty]
        public string Id { get; set; }

        [FirestoreProperty]
        public int Cantidad { get; set; }

        [FirestoreProperty]
        public string Nombre { get; set; }

        [FirestoreProperty]
        public double Precio { get; set; }

        [FirestoreProperty]
        public double Subtotal { get; set; }

    }

    class Envio
    {
        [FirestoreProperty]
        public string CallePrincipal { get; set; }

        [FirestoreProperty]
        public string CalleSecundaria { get; set; }

        [FirestoreProperty]
        public string Canton { get; set; }

        [FirestoreProperty]
        public string Cedula_Receptor { get; set; }

        [FirestoreProperty]
        public string Metodo { get; set; }

        [FirestoreProperty]
        public string Piso { get; set; }

        [FirestoreProperty]
        public string Provincia { get; set; }

        [FirestoreProperty]
        public string Referencia { get; set; }

    }
}
