using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmiTienda
{
    public partial class LOGIN : Form
    {
        MENUFORM menu = new MENUFORM();
        Usuario user;
        public LOGIN()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUser.Text;
            string clave = textBoxPass.Text;
            bool inicio = await IniciarSesion(usuario, clave);
            if (inicio)
            {
                textBoxPass.Text = String.Empty;
                textBoxUser.Text = String.Empty;
                this.menu.formLogin = this;
                this.menu.Show();
                this.Hide();
                MessageBox.Show(this.user.Nombre , "Bien venido!");
            }
            else
            {
                Console.WriteLine("Credenciales incorrectas");
                MessageBox.Show("No se encontro el usuario!", "Las credenciales no son correctas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        async Task<bool> IniciarSesion(string usuario, string clave){
            string path = AppDomain.CurrentDomain.BaseDirectory + @"apptienda.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db = FirestoreDb.Create("apptienda-130f3");
            CollectionReference usuarios = db.Collection("Administradores");
            Query query = usuarios.WhereEqualTo("User", usuario).WhereEqualTo("Clave",clave);
            QuerySnapshot snap = await query.GetSnapshotAsync();

            foreach (DocumentSnapshot doc in snap)
            {
                if (doc.Exists)
                {
                    this.user = doc.ConvertTo<Usuario>();
                    return true;
                }

            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Está seguro que desea salir de la aplicación?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Application.Exit(); 
            }
        }
    }
}
