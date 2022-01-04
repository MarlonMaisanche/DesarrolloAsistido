using Firebase.Auth;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmiTienda
{
    public partial class Form2 : Form
    {

        private static string ApiKey = "AIzaSyBiniRAjfok3yAUBgyoy-ATFolT9sPY-yE";
        private static string Bucket = "apptienda-130f3.appspot.com";
        private static string AuthEmail = "yaciha8976@dukeoo.com";
        private static string AuthPassword = "123456";
        public Form2()
        {
            InitializeComponent();
        }

        string URL;
        void seleccionaImagen()
        {
            OpenFileDialog imagenproducto = new OpenFileDialog();
            imagenproducto.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            DialogResult res = imagenproducto.ShowDialog();
            string ruta = imagenproducto.FileName;
            this.URL = ruta;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        void obtenerfecha()
        {
            DateTime fecha = DateTime.Now;
            string fecha1 = fecha.ToString();
            fecha1 = fecha1.Replace(':', '0');
            fecha1 = fecha1.Replace(' ', '1');
            Console.WriteLine(fecha1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //obtenerfecha();
            //eliminarImagenAsync();
            string imagenAActualizar = "https://firebasestorage.googleapis.com/v0/b/apptienda-130f3.appspot.com/o/productos%2Fgold%202.png?alt=media&token=4844132e-8087-4c3f-9e8f-a6d6c8ed3acf";
            ActualizarImagenAsync(imagenAActualizar);
        }

        async Task ActualizarImagenAsync(string url)
        {
            string mensaje = await ImagenesCRUD.ActualizarImagen(url, this.URL);
            Console.WriteLine(mensaje);
        }


        async Task eliminarImagenAsync()
        {
            var auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));
            var a = await auth.SignInWithEmailAndPasswordAsync(AuthEmail, AuthPassword);
            var cancellation = new CancellationTokenSource();
            string urlImagen = "https://firebasestorage.googleapis.com/v0/b/apptienda-130f3.appspot.com/o/productos%2Fdescarga%20(4).png?alt=media&token=18fad092-ba95-45ed-a641-a579af66ac79";
            string url= "https://firebasestorage.googleapis.com/v0/b/apptienda-130f3.appspot.com/o/productos%2F";
            int indexOfEndPath = urlImagen.IndexOf("?");
            urlImagen = urlImagen.Substring(0, indexOfEndPath);
            string nombreImagen = urlImagen.Replace(url,"");
            nombreImagen = nombreImagen.Replace("%20"," ");
            //Console.WriteLine(nombreImagen);
            //Console.WriteLine(indexOfEndPath);
            Console.WriteLine(nombreImagen);

            var task = new FirebaseStorage(
           Bucket,
           new FirebaseStorageOptions
           {
               AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
               ThrowOnCancel = true
           })
           .Child("productos")
           .Child(nombreImagen)
           .DeleteAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seleccionaImagen();
        }
    }
}
