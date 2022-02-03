using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmiTienda
{
    [FirestoreData]
    public class Usuario
    {
        [FirestoreProperty]
        public string Id { get; set; }

        [FirestoreProperty]
        public string Nombre { get; set; }

        [FirestoreProperty]
        public string Correo { get; set; }

        [FirestoreProperty]
        public string User { get; set; }

        [FirestoreProperty]
        public string Clave { get; set; }

    }
}
