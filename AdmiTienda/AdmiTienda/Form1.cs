using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Storage;
using Google.Cloud.Firestore;
using System.Drawing;
using Firebase.Auth;
using System.Threading;

namespace AdmiTienda
{
    public partial class PRODUCTOFORM : Form
    {
        FirestoreDb db;
        Producto PRODUCTO;

        public PRODUCTOFORM()
        {
            InitializeComponent();
            BloquearCampos();
            this.ruta1 = "";
            this.ruta2 = "";
            this.ruta3 = "";
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboCategoria.Items.Insert(0, "--Seleccione una opción--");
            this.comboCategoria.SelectedIndex = 0;
            string path = AppDomain.CurrentDomain.BaseDirectory + @"apptienda.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("apptienda-130f3");
            PRODUCTO = new Producto();
            ObtenerProductos();
            
        }

        async Task AgregarProductoAsync()
        {
            CollectionReference coleccion = db.Collection("Productos");
            string ruta1 = ruta1 = await SubirImagenAsync(this.ruta1);
            string ruta2 = ruta2 = await SubirImagenAsync(this.ruta2);
            string ruta3 = ruta3 = await SubirImagenAsync(this.ruta3);
            double precioOferta = 0;
            if (rbtOferta.Checked)
            {
                precioOferta = Convert.ToDouble(txtPrecio.Text) - (Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtPrecioOferta.Text) / 100);
            }
            bool estado = false;
            if (rbtActivo.Checked)
            {
                estado = true;
            }
            bool oferta = false;
            if (rbtOferta.Checked)
            {
                oferta = true;
            }
            Dictionary<string, object> datos = new Dictionary<string, object>() {
                { "Categoria", comboCategoria.SelectedItem },
                { "Descripcion", txtDescripcion.Text },
                { "Imagen" , ruta1 },
                { "Imagen2" , ruta2},
                { "Imagen3" , ruta3 },
                { "Nombre" , txtNombre.Text },
                { "Precio" , Convert.ToDouble(txtPrecio.Text) },
                { "Precio_Oferta" , precioOferta },
                { "Estado", estado },
                { "Oferta", oferta }
            };
            DocumentReference doc = await coleccion.AddAsync(datos);
            DocumentSnapshot snap = await doc.GetSnapshotAsync();
            if (snap.Exists)
            {
                Producto producto = snap.ConvertTo<Producto>();
                this.PRODUCTO = producto;
                this.PRODUCTO.Id = snap.Id;
                if (this.PRODUCTO.Id.Length > 0)
                {
                    MessageBox.Show("Se ha añadido un nuevo producto en la tienda de manera exitosa", "Registro añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LimpiarCampos();
            ObtenerProductos();
            BloquearCampos();
        }

        async Task ActualizarProductoAsync(string id)
        {
            string ruta1;
            string ruta2;
            string ruta3;
            if (this.ruta1 != "")
            {
                ruta1 = await ActualizarImagenesAsync(this.PRODUCTO.Imagen, this.ruta1);
            }
            else
            {
                ruta1 = PRODUCTO.Imagen;
            }
            if (this.ruta2 != "")
            {
                ruta2 = await ActualizarImagenesAsync(this.PRODUCTO.Imagen2, this.ruta2);
            }
            else
            {
                ruta2 = PRODUCTO.Imagen2;
            }
            if (this.ruta3 != "")
            {
                ruta3 = await ActualizarImagenesAsync(this.PRODUCTO.Imagen3, this.ruta3);
            }
            else
            {
                ruta3 = PRODUCTO.Imagen3;
            }

            double precioOferta = 0;
            if (rbtOferta.Checked)
            {
                precioOferta = Convert.ToDouble(txtPrecio.Text) - (Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtPrecioOferta.Text) / 100);
            }
            bool estado = false;
            if (rbtActivo.Checked)
            {
                estado = true;
            }
            bool oferta = false;
            if (rbtOferta.Checked)
            {
                oferta = true;
            }
            Dictionary<string, object> datos = new Dictionary<string, object>() {
                { "Categoria", comboCategoria.SelectedItem },
                { "Descripcion", txtDescripcion.Text },
                { "Imagen" ,  ruta1 },
                { "Imagen2" , ruta2},
                { "Imagen3" , ruta3 },
                { "Nombre" , txtNombre.Text },
                { "Precio" , Convert.ToDouble(txtPrecio.Text) },
                { "Precio_Oferta" , precioOferta },
                { "Estado", estado },
                { "Oferta", oferta }
            };

            DocumentReference doc = db.Collection("Productos").Document(id);
            DocumentSnapshot snap = await doc.GetSnapshotAsync();
            if (snap.Exists)
            {
                WriteResult result = await doc.SetAsync(datos);
                MessageBox.Show("Se ha actualizado un producto en la tienda de manera exitosa", "Registro Actualizado",  MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            LimpiarCampos();
            ObtenerProductos();
            BloquearCampos();
        }

        async Task EliminarProductoAsync(string id)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar este item del registro?\n Luego de aceptar la eliminación del registro, el registro se eliminará definitivamente",
              "Canfirmación de eliminación de registro",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                _ = EliminarImagenesAsync(PRODUCTO.Imagen);
                _ = EliminarImagenesAsync(PRODUCTO.Imagen2);
                _ = EliminarImagenesAsync(PRODUCTO.Imagen3);
            }

            DocumentReference doc = db.Collection("Productos").Document(id);
            DocumentSnapshot snap = await doc.GetSnapshotAsync();
            if (snap.Exists)
            {
                WriteResult result = await doc.DeleteAsync();
                MessageBox.Show("Se ha borrado un producto de la tienda de manera exitosa", "Registro Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LimpiarCampos();
            ObtenerProductos();
            BloquearCampos();
        }

        async void ObtenerProducto(DataGridViewCellMouseEventArgs e)
        {
            string id = listaProductos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            if(id != this.PRODUCTO.Id)
            {

            DocumentReference prod = db.Collection("Productos").Document(id);
            DocumentSnapshot snap = await prod.GetSnapshotAsync();
            if (snap.Exists)
            {
                Producto producto = snap.ConvertTo<Producto>();

                this.PRODUCTO = producto;
                this.PRODUCTO.Id = id;
                this.txtNombre.Text = producto.Nombre;
                this.rbtActivo.Checked = producto.Estado ? true : false;
                this.rbtInactivo.Checked = producto.Estado ? false : true;
                this.rbtOferta.Checked = producto.Oferta ? true : false;
                this.rbtnNoOferta.Checked = producto.Oferta ? false : true;
                this.txtDescripcion.Text = producto.Descripcion;
                this.comboCategoria.SelectedItem = producto.Categoria;
                this.txtImg.Text = PRODUCTO.Imagen;
                this.txtImg2.Text = PRODUCTO.Imagen2;
                this.txtImg3.Text = PRODUCTO.Imagen3;

                if (producto.Oferta)
                {
                    this.txtPrecioOferta.Enabled = true;
                    this.txtPrecio.Text = producto.Precio.ToString();
                    double porcentaje = (producto.Precio - producto.Precio_Oferta) * 100 / producto.Precio;
                    this.txtPrecioOferta.Text = decimal.Round(Convert.ToDecimal( porcentaje),2).ToString();
                }
                else
                {
                    this.txtPrecio.Text = producto.Precio.ToString();
                    this.txtPrecioOferta.Enabled = false;
                    this.txtPrecioOferta.Text = String.Empty;

                }
               }
            }

        }

        List<Producto> productosFiltrados = new List<Producto>();

        void FiltrarPorCategoria(string query)
        {
            this.productosFiltrados = this.productos.Where(x => x.Categoria == query).ToList();
            this.listaProductos.DataSource = this.productosFiltrados;
        }

        void FiltrarPorID(string query)
        {
            List<Producto> filtro = new List<Producto>();
            foreach (Producto producto in this.productos)
            {
                if (producto.Id.ToLower().Contains(query.ToLower()))
                {
                    filtro.Add(producto);
                }
            }
            this.productosFiltrados = filtro;
            this.listaProductos.DataSource = this.productosFiltrados;
        }

        void FiltrarPorNombre(string query)
        {
            List<Producto> filtro = new List<Producto>();
            foreach (Producto producto in this.productos)
            {
                if (producto.Nombre.ToLower().Contains(query.ToLower()))
                {
                    filtro.Add(producto);
                }
            }
            this.productosFiltrados = filtro;
            this.listaProductos.DataSource = this.productosFiltrados;
        }

        void FiltrarPorEstado(bool valor)
        {
            this.productosFiltrados = this.productos.Where(x => x.Estado == valor).ToList();
            this.listaProductos.DataSource = this.productosFiltrados;
        }

        void FiltrarPorOferta(bool valor)
        {
            this.productosFiltrados = this.productos.Where(x => x.Oferta == valor).ToList();
            this.listaProductos.DataSource = this.productosFiltrados;
        }


        List<Producto> productos = new List<Producto>();
        async void ObtenerProductos()
        {
            List<Producto> productosLista = new List<Producto>();
            
            Query productos = db.Collection("Productos");
            QuerySnapshot snap = await productos.GetSnapshotAsync();
            foreach (DocumentSnapshot doc in snap.Documents)
            {
                Producto producto = doc.ConvertTo<Producto>();
                producto.Id = doc.Id;
                if (doc.Exists)
                {
                    productosLista.Add(producto);
                }
            }
            listaProductos.DataSource = productosLista;
            this.productos = productosLista;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElegirImagen(1);
        }

        string ruta1;
    
        string ruta2;
       
        string ruta3;
     

        private void ElegirImagen(int imagen)
        {
            OpenFileDialog imagenproducto = new OpenFileDialog();
            imagenproducto.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            DialogResult res = imagenproducto.ShowDialog();
            string ruta = imagenproducto.FileName;
            if(imagen == 1)
            {
                ruta1 = ruta;
                this.txtImg.Text = ruta;
            }else if(imagen == 2)
            {
                ruta2 = ruta;
                this.txtImg2.Text = ruta;
            }
            else
            {
                ruta3 = ruta;
                this.txtImg3.Text = ruta;
            }
        }

        private void button2_ClickAsync(object sender, EventArgs e)
        {
            if (ValidarDatosCompletos())
            {
                if (this.PRODUCTO.Id == "" || this.PRODUCTO.Id == null)
                {
                    _ = AgregarProductoAsync();

                }
                else
                {
                    _ = ActualizarProductoAsync(this.PRODUCTO.Id);
                }
            }
        }

        async Task SubirImagenesAsync()
        {
            await SubirImagenAsync(this.ruta1);
            await SubirImagenAsync(this.ruta2);
            await SubirImagenAsync(this.ruta3);
        }

        async Task ActualizarImagenesAsync()
        {
            await ActualizarImagenesAsync( this.PRODUCTO.Imagen, this.ruta1);
            await ActualizarImagenesAsync( this.PRODUCTO.Imagen2, this.ruta2);
            await ActualizarImagenesAsync( this.PRODUCTO.Imagen3, this.ruta3);
        }

        private async Task<string> SubirImagenAsync(string ruta)
        {
            return await ImagenesCRUD.SubirImagen(ruta); 
        }

        private async Task<string> ActualizarImagenesAsync(string anterior, string ruta)
        {
            return await ImagenesCRUD.ActualizarImagen(anterior, ruta);
        }

        private async Task EliminarImagenesAsync(string url)
        {
            await ImagenesCRUD.EliminarImagenAsync(url);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void EliminarImagenes()
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ElegirImagen(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ElegirImagen(3);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ObtenerProductos();
            txtBusqueda.Visible = false;
            comboBuscarCategoria.Visible = false;
            groupBusqueda.Visible = false;
        }

        private void listaProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DesbloquearCampos();
                btnCancelar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = true;
                ObtenerProducto(e);
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
                throw;
            }
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtOferta_CheckedChanged(object sender, EventArgs e)
        {
            txtPrecioOferta.Enabled = true;
            txtPrecio.Enabled = true;
        }

        private void rbtnNoOferta_CheckedChanged(object sender, EventArgs e)
        {
            txtPrecioOferta.Enabled = false;
            txtPrecio.Enabled = true;
        }

        private void BloquearCampos()
        {
            btnNuevo.Enabled = true;
            txtNombre.Enabled = false;
            rbtActivo.Enabled = false;
            rbtInactivo.Enabled = false;
            rbtnNoOferta.Enabled = false;
            rbtOferta.Enabled = false;
            txtDescripcion.Enabled = false;
            comboCategoria.Enabled = false;
            txtImg.Enabled = false;
            txtImg2.Enabled = false;
            txtImg3.Enabled = false;
            btnImagen1.Enabled = false;
            btnImagen2.Enabled = false;
            btnImagen3.Enabled = false;
            txtPrecio.Enabled = false;
            txtPrecioOferta.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void DesbloquearCampos()
        {
            btnNuevo.Enabled = false;
            txtNombre.Enabled = true;
            rbtActivo.Enabled = true;
            rbtInactivo.Enabled = true;
            rbtnNoOferta.Enabled = true;
            rbtOferta.Enabled = true;
            txtDescripcion.Enabled = true;
            comboCategoria.Enabled = true;
            txtImg.Enabled = true;
            txtImg2.Enabled = true;
            txtImg3.Enabled = true;
            btnImagen1.Enabled = true;
            btnImagen2.Enabled = true;
            btnImagen3.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        public void LimpiarCampos()
        {
            this.ruta1 = String.Empty;
            this.ruta2 = String.Empty;
            this.ruta3 = String.Empty;
            txtNombre.Text = String.Empty;
            rbtActivo.Checked = false;
            rbtInactivo.Checked = false;
            rbtnNoOferta.Checked = false;
            rbtOferta.Checked = false;
            txtDescripcion.Text = String.Empty;
            comboCategoria.SelectedIndex = 0;
            txtImg.Text = String.Empty;
            txtImg2.Text = String.Empty;
            txtImg3.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            txtPrecioOferta.Text = String.Empty;
            this.PRODUCTO = new Producto();
        }

        public bool ValidarDatosCompletos()
        {
            

            if (txtNombre.Text == String.Empty ||
                (!rbtActivo.Checked && !rbtInactivo.Checked ) ||
                (!rbtOferta.Checked && !rbtnNoOferta.Checked) ||
                comboCategoria.SelectedIndex == 0 ||
                txtDescripcion.Text == String.Empty 
                )
            {
                MessageBox.Show("Por favor llene todos los campos requeridos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if (rbtOferta.Checked)
                {
                    if (txtPrecio.Text == String.Empty || txtPrecioOferta.Text == String.Empty)
                    {
                        MessageBox.Show("Introduzca los valores de precio del producto!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else
                {
                    if (txtPrecio.Text == String.Empty)
                    {
                        MessageBox.Show("Introduzca el valor de precio del producto!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }

                if ((txtImg.Text == String.Empty && txtImg2.Text == String.Empty && txtImg3.Text == String.Empty) ||
                (txtImg.Text == "Sin imagen" && txtImg2.Text == "Sin imagen" && txtImg3.Text == "Sin imagen"))
                {
                    MessageBox.Show("Sleccione al menos una imagen para el producto!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DesbloquearCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.PRODUCTO = new Producto();
            this.ruta1 = String.Empty;
            this.ruta2 = String.Empty;
            this.ruta3 = String.Empty;
            LimpiarCampos();
            BloquearCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _ = EliminarProductoAsync(PRODUCTO.Id);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBusqueda.SelectedIndex == 0 || comboBusqueda.SelectedIndex == 2)
            {
                txtBusqueda.Visible = true;
                groupBusqueda.Visible = false;
                comboBuscarCategoria.Visible = false;
            }
            else if (comboBusqueda.SelectedIndex == 1)
            {
                txtBusqueda.Visible = false;
                groupBusqueda.Visible = false;
                comboBuscarCategoria.Visible = true;
            }else if (comboBusqueda.SelectedIndex == 3 || comboBusqueda.SelectedIndex == 4)
            {
                txtBusqueda.Visible = false;
                comboBuscarCategoria.Visible = false;
                groupBusqueda.Visible = true;

                if(comboBusqueda.SelectedIndex == 3)
                {
                    groupBusqueda.Text = "ESTADO DEL PRODUCTO";
                    rbtTrue.Text = "ACTIVO";
                    rbtFalse.Text = "INACTIVO";
                }
                else
                {
                    groupBusqueda.Text = "OFERTA DEL PRODUCTO";
                    rbtTrue.Text = "SI";
                    rbtFalse.Text = "NO";
                }
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBusqueda.SelectedIndex == 0 )
            {
                if (txtBusqueda.Text == "")
                {
                    this.listaProductos.DataSource = this.productos;
                }
                else
                {
                    FiltrarPorID(txtBusqueda.Text);
                }
            }else
            {
                if (txtBusqueda.Text == "")
                {
                    this.listaProductos.DataSource = this.productos;
                }
                else
                {
                    FiltrarPorNombre(txtBusqueda.Text);
                }

            }
        }

        private void rbtTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBusqueda.SelectedIndex == 3)
            {
                FiltrarPorEstado(true);
            }
            else
            {
                FiltrarPorOferta(true);
            }
        }

        private void rbtFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBusqueda.SelectedIndex == 3)
            {
                FiltrarPorEstado(false);
            }
            else
            {
                FiltrarPorOferta(false);
            }
        }

        private void comboBuscarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPorCategoria(comboBuscarCategoria.SelectedItem.ToString());
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioOferta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
