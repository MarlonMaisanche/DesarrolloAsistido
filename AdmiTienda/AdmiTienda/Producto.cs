using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmiTienda
{
    [FirestoreData]
    public class Producto
    {
        [FirestoreProperty]
        public string Id { get; set; }

        [FirestoreProperty]
        public string Nombre { get; set; }

        [FirestoreProperty]
        public string Descripcion { get; set; }

        [FirestoreProperty]
        public double Precio { get; set; }

        [FirestoreProperty]
        public double Precio_Oferta { get; set; }

        [FirestoreProperty]
        public bool Oferta { get; set; }

        [FirestoreProperty]
        public bool Estado { get; set; }

        [FirestoreProperty]
        public string Imagen { get; set; }

        [FirestoreProperty]
        public string Imagen2 { get; set; }

        [FirestoreProperty]
        public string Imagen3 { get; set; }

        [FirestoreProperty]
        public string Categoria { get; set; }


    }

}
