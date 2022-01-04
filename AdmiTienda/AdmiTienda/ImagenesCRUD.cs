using Firebase.Auth;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdmiTienda
{
    public static class ImagenesCRUD
    {
        private static string ApiKey = "AIzaSyBiniRAjfok3yAUBgyoy-ATFolT9sPY-yE";
        private static string Bucket = "apptienda-130f3.appspot.com";
        private static string AuthEmail = "yaciha8976@dukeoo.com";
        private static string AuthPassword = "123456";
        public static string ObtenerNombreImagen(string URL_IMAGEN)
        {
            if(URL_IMAGEN == "Sin imagen")
            {
                return "Sin imagen";
            }
            string URL = "https://firebasestorage.googleapis.com/v0/b/apptienda-130f3.appspot.com/o/productos%2F";
            int indexOfEndPath = URL_IMAGEN.IndexOf("?");
            URL_IMAGEN = URL_IMAGEN.Substring(0, indexOfEndPath);
            string nombreImagen = URL_IMAGEN.Replace(URL, "");
            nombreImagen = nombreImagen.Replace("%20", " ");
            return nombreImagen;
        }
        public static async Task<string> SubirImagen(string ruta)
        {
            if (ruta == null || ruta == "")
            {
                return "Sin imagen";
            }
            else
            {
                try
                {
                    string fecha = DateTime.Now.ToString();
                    fecha = fecha.Replace(':', '0');
                    fecha = fecha.Replace(' ', '1');
                    string nombreImagen = ruta.Substring(ruta.LastIndexOf("\\") + 1);
                    var stream = File.Open(ruta, FileMode.Open);
                    var auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));
                    var a = await auth.SignInWithEmailAndPasswordAsync(AuthEmail, AuthPassword);
                    var cancellation = new CancellationTokenSource();
                    var task = new FirebaseStorage(
                    Bucket,
                    new FirebaseStorageOptions
                    {
                        AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                        ThrowOnCancel = true // when you cancel the upload, exception is thrown. By default no exception is thrown
                    })
                    .Child("productos")
                    .Child(fecha + nombreImagen)
                    .PutAsync(stream, cancellation.Token);
                    return await task;
                }
                catch
                {
                    return "Sin imagen";
                }
                
            }
        }
        public static async Task<string> ActualizarImagen(string URL_IMAGEN, string ruta)
        {
            if (ruta != null || ruta != "")
            {
                if (URL_IMAGEN != "Sin imagen")
                {
                    try
                    {
                        string imagen = ObtenerNombreImagen(URL_IMAGEN);
                        string fecha = DateTime.Now.ToString();
                        fecha = fecha.Replace(':', '0');
                        fecha = fecha.Replace(' ', '1');
                        var stream = File.Open(ruta, FileMode.Open);
                        var auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));
                        var a = await auth.SignInWithEmailAndPasswordAsync(AuthEmail, AuthPassword);
                        var cancellation = new CancellationTokenSource();
                        var task = new FirebaseStorage(
                        Bucket,
                        new FirebaseStorageOptions
                        {
                            AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                            ThrowOnCancel = true // when you cancel the upload, exception is thrown. By default no exception is thrown
                    })
                        .Child("productos")
                        .Child(imagen)
                        .PutAsync(stream, cancellation.Token);
                        return await task;
                    }
                    catch
                    {
                        return "Sin imagen";
                    }
                }
                else
                {
                    return await SubirImagen(ruta);
                }
                
            }

            return "Sin imagen";
        }
        public static async Task EliminarImagenAsync(string URL_IMAGEN)
        {
            if (URL_IMAGEN != "Sin imagen")
            {
                var auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));
                var a = await auth.SignInWithEmailAndPasswordAsync(AuthEmail, AuthPassword);
                var cancellation = new CancellationTokenSource();
                string imagen = ObtenerNombreImagen(URL_IMAGEN);
                var task = new FirebaseStorage(
                Bucket,
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                    ThrowOnCancel = true
                })
                .Child("productos")
                .Child(imagen)
                .DeleteAsync();
            }
           
        }

    }
}
