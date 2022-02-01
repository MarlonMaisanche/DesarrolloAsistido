using Firebase.Auth;
using Firebase.Storage;
using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmiTienda
{
    public partial class PEDIDOFORM : Form
    {
        FirestoreDb db;
        List<Pedido> pedidos;
        List<PedidoList> pedidosList;
        Pedido PEDIDO = new Pedido();

        public PEDIDOFORM()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"apptienda.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("apptienda-130f3");
            LimpiarCampos();
            ObtenerPedidos();
        }


        async void ObtenerPedidos()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"apptienda.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            FirestoreDb db;
            db = FirestoreDb.Create("apptienda-130f3");

            Query pedidos = db.Collection("Pedidos");
            QuerySnapshot snap = await pedidos.GetSnapshotAsync();
            this.pedidos = new List<Pedido>();
            this.pedidosList = new List<PedidoList>();
            foreach (DocumentSnapshot documentSnapshot in snap.Documents)
            {
                Console.WriteLine("Document data for {0} document:", documentSnapshot.Id);
                Dictionary<string, object> pedido = documentSnapshot.ToDictionary();
                Pedido pedidoItem = new Pedido();
                PedidoList pedidoList= new PedidoList();
                pedidoItem.Id = documentSnapshot.Id;
                pedidoList.Id = pedidoItem.Id;
                pedidoItem.Cedula = pedido["Cedula"].ToString();
                pedidoList.Cedula = pedido["Cedula"].ToString();
                pedidoItem.Cliente = pedido["Cliente"].ToString();
                pedidoList.Cliente = pedido["Cliente"].ToString();
                pedidoItem.Contacto = pedido["Contacto"].ToString();
                pedidoList.Contacto = pedido["Contacto"].ToString();
                pedidoItem.Correo = pedido["Correo"].ToString();
                pedidoList.Correo = pedido["Correo"].ToString();
                Console.WriteLine(pedido["Envio"].GetType());
                Dictionary<string, object> envio = new Dictionary<string, object>();
                envio = (Dictionary<string, object>)pedido["Envio"];
                pedidoItem.Envio = new Envio();
                pedidoItem.Envio.Metodo = envio["Metodo"].ToString();
                pedidoList.Metodo_Envio = envio["Metodo"].ToString();

                if(pedidoItem.Envio.Metodo == "A domicilio")
                {
                    pedidoItem.Envio.CallePrincipal = envio["CallePrincipal"].ToString();
                    pedidoItem.Envio.CalleSecundaria = envio["CalleSecundaria"].ToString();
                    pedidoItem.Envio.Canton = envio["Canton"].ToString();
                    pedidoItem.Envio.Cedula_Receptor = envio["Cedula_Receptor"].ToString();
                    pedidoItem.Envio.Piso = envio["Piso"].ToString();
                    pedidoItem.Envio.Provincia = envio["Provincia"].ToString();
                    pedidoItem.Envio.Referencia= envio["Referencia"].ToString();
                }

                pedidoItem.Estado = pedido["Estado"].ToString();
                pedidoList.Estado = pedido["Estado"].ToString();
                string formatString = "yyyyMMddHHmmss";


                DateTime fecha = DateTime.ParseExact(pedido["Fecha"].ToString(), formatString, null);
                pedidoItem.Fecha = fecha;
                pedidoList.Fecha = fecha;
                pedidoItem.Id_Pago = pedido["Id_Pago"].ToString();
                pedidoList.Id_Pago = pedido["Id_Pago"].ToString();
                pedidoItem.Productos = new List<Productos>();
                List<object> lista = (List<object>)pedido["Productos"];
                foreach (Dictionary<string,object> producto in lista)
                {
                    Productos pp = new Productos();
                    Console.WriteLine(producto["Cantidad"].GetType());
                    pp.Cantidad =Convert.ToInt32( producto["Cantidad"]);
                    pp.Id = producto["Id"].ToString();
                    pp.Nombre = producto["Nombre"].ToString();
                    pp.Precio = Convert.ToDouble( producto["Precio"]);
                    pp.Subtotal = Convert.ToDouble(producto["Subtotal"]);
                    pedidoItem.Productos.Add(pp);
                }
                pedidoItem.Total = Convert.ToDouble(pedido["Total"]);
                pedidoList.Total = Convert.ToDouble(pedido["Total"]);
                this.pedidos.Add(pedidoItem);
                this.pedidosList.Add(pedidoList);
            }
            listaPedidos.DataSource = this.pedidosList;
            listaFiltrada = this.pedidosList;
        }
        
        private void FiltrarPorFecha(int opcion)
        {
            try
            {
                DateTime fecha = DateTime.Today;
                switch (opcion)
                {
                    case 1:
                        this.listaPedidos.DataSource = pedidosList.Where(x => x.Fecha.Day == DateTime.Today.Day
                        && x.Fecha.Month == DateTime.Today.Month
                        && x.Fecha.Year == DateTime.Today.Year).ToList();
                        break;
                    case 2:
                        fecha = DateTime.Today.AddDays(-7);
                        this.listaPedidos.DataSource = pedidosList.Where(x => x.Fecha > fecha).ToList();
                        break;
                    case 3:
                        fecha = DateTime.Today.AddDays(-30);
                        this.listaPedidos.DataSource = pedidosList.Where(x => x.Fecha > fecha).ToList();
                        break;
                    case 4:
                        fecha = DateTime.Today.AddDays(-90);
                        this.listaPedidos.DataSource = pedidosList.Where(x => x.Fecha > fecha).ToList();
                        break;
                    case 5:
                        fecha = DateTime.Today.AddDays(-180);
                        this.listaPedidos.DataSource = pedidosList.Where(x => x.Fecha > fecha).ToList();
                        break;
                    case 6:
                        fecha = DateTime.Today.AddDays(-365);
                        this.listaPedidos.DataSource = pedidosList.Where(x => x.Fecha > fecha).ToList();
                        break;
                }
            }
            catch
            {
            }
        }

        private void FiltrarConFecha(int opcion)
        {
            DateTime fecha = DateTime.Today;
            switch (opcion)
            {
                case 1:
                    this.listaPedidos.DataSource = listaFiltrada.Where(x => x.Fecha.Day == DateTime.Today.Day
                    && x.Fecha.Month == DateTime.Today.Month
                    && x.Fecha.Year == DateTime.Today.Year).ToList();
                    break;
                case 2:
                    fecha = DateTime.Today.AddDays(-7);
                    this.listaPedidos.DataSource = listaFiltrada.Where(x => x.Fecha > fecha).ToList();

                    break;
                case 3:
                    fecha = DateTime.Today.AddDays(-30);
                    this.listaPedidos.DataSource = listaFiltrada.Where(x => x.Fecha > fecha).ToList();
                    break;
                case 4:
                    fecha = DateTime.Today.AddDays(-90);
                    this.listaPedidos.DataSource = listaFiltrada.Where(x => x.Fecha > fecha).ToList();
                    break;
                case 5:
                    fecha = DateTime.Today.AddDays(-180);
                    this.listaPedidos.DataSource = listaFiltrada.Where(x => x.Fecha > fecha).ToList();
                    break;
                case 6:
                    fecha = DateTime.Today.AddDays(-365);
                    this.listaPedidos.DataSource = listaFiltrada.Where(x => x.Fecha > fecha).ToList();
                    break;
            }
        }

        private void comboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBusqueda.SelectedIndex == 0 || comboBusqueda.SelectedIndex == 1 || 
                comboBusqueda.SelectedIndex == 2)
            {
                txtBusqueda.Visible = true;
                txtBusqueda.Text = String.Empty;
                groupBusquedaEstado.Visible = false;
                comboBuscarFecha.Visible = false;
                comboBuscarEstado.Visible = false;
                if (comboBusqueda.SelectedIndex == 2)
                {
                    comboBuscarConFecha.Visible = true;
                    lblTemporalidad.Visible = true;
                }
                else
                {
                    comboBuscarConFecha.Visible = false;
                    lblTemporalidad.Visible = false;
                }
            }
            else if (comboBusqueda.SelectedIndex == 3 )
            {
                lblTemporalidad.Visible = true;
                txtBusqueda.Visible = false;
                comboBuscarFecha.Visible = false;
                groupBusquedaEstado.Visible = true;
                comboBuscarEstado.Visible = false;
                comboBuscarConFecha.Visible = true;
                groupBusquedaEstado.Text = "MÉTODO ENVÍO";
                rbtTrue.Text = "RETIRO LOCAL";
                rbtFalse.Text = "A DOMICILIO";
            }
            else if (comboBusqueda.SelectedIndex == 4 || comboBusqueda.SelectedIndex == 5)
            {
                txtBusqueda.Visible = false;
                groupBusquedaEstado.Visible = false;

                if(comboBusqueda.SelectedIndex == 5)
                {
                    comboBuscarEstado.Visible = false;
                    comboBuscarFecha.Visible = true;
                    comboBuscarConFecha.Visible = false;
                    lblTemporalidad.Visible = false;
                }
                else
                {
                    lblTemporalidad.Visible = true;
                    comboBuscarEstado.Visible = true;
                    comboBuscarFecha.Visible = false;
                    comboBuscarConFecha.Visible = true;
                }
            }
        }

        private void comboBuscarEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPorEstado();
            FiltrarConFecha(comboBuscarConFecha.SelectedIndex + 1);
        }

        private void comboBuscarFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPorFecha(comboBuscarFecha.SelectedIndex + 1);
        }

        List<PedidoList> listaFiltrada = new List<PedidoList>();

        void FiltrarPorMetodoEnvio(string valor)
        {
            listaPedidos.DataSource = this.pedidosList.Where(x => x.Metodo_Envio == valor).ToList();
            listaFiltrada = this.pedidosList.Where(x => x.Metodo_Envio == valor).ToList();
        }

        void FiltrarPorEstado()
        {
            string estado = comboBuscarEstado.SelectedItem.ToString();
            switch (estado)
            {
                case "PENDIENTE":
                    estado = "Pendiente";
                    break;
                case "ACEPTADO":
                    estado = "Aceptado";
                    break;
                case "CANCELADO":
                    estado = "Cancelado";
                    break;
                case "ENTREGADO":
                    estado = "Entregado";
                    break;
            }
            listaPedidos.DataSource = this.pedidosList.Where(x => x.Estado == estado).ToList();
            listaFiltrada = this.pedidosList.Where(x => x.Estado == estado).ToList();
        }

        void FiltrarPorTexto(int opcion)
        {
            switch (opcion)
            {
                case 1:

                    listaPedidos.DataSource = this.pedidosList.Where(x => x.Id.ToLower().Contains(txtBusqueda.Text.ToLower())).ToList();
                    break;
                case 2:
                    listaPedidos.DataSource = this.pedidosList.Where(x => x.Id_Pago.ToLower().Contains(txtBusqueda.Text.ToLower())).ToList();

                    break;
                case 3:
                    listaPedidos.DataSource = this.pedidosList.Where(x => x.Cedula.ToLower().Contains(txtBusqueda.Text.ToLower())).ToList();
                    break;
            }
            listaFiltrada = (List<PedidoList>)listaPedidos.DataSource;
        }

        private void rbtTrue_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarPorMetodoEnvio("Retiro en local");
            FiltrarConFecha(comboBuscarConFecha.SelectedIndex + 1);
        }

        private void rbtFalse_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarPorMetodoEnvio("A domicilio");
            FiltrarConFecha(comboBuscarConFecha.SelectedIndex + 1);
        }

        private void comboBuscarConFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarConFecha(comboBuscarConFecha.SelectedIndex+1);
        }

        private void listaPedidos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string id = listaPedidos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                this.PEDIDO = pedidos.Where(x => x.Id == id).FirstOrDefault();
                txtCedula.Text = this.PEDIDO.Cedula;
                txtCliente.Text = this.PEDIDO.Cliente;
                txtIdPedido.Text = this.PEDIDO.Id;
                txtFecha.Text = this.PEDIDO.Fecha.ToString();
                txtCorreo.Text = this.PEDIDO.Correo;
                txtMetodo.Text = this.PEDIDO.Envio.Metodo;
                txtPago.Text = this.PEDIDO.Id_Pago;
                txtTotal.Text = this.PEDIDO.Total.ToString() + " $";
                txtContacto.Text = this.PEDIDO.Contacto;
                txtEstado.Text = this.PEDIDO.Estado;
                detalleProductos.DataSource = this.PEDIDO.Productos;

                if (this.PEDIDO.Envio.Metodo == "A domicilio")
                {
                    txtDirEnvio.Text = "Provincia: " + this.PEDIDO.Envio.Provincia + " Cantón: " +
                        this.PEDIDO.Envio.Canton + "\n" + "Dirección: " +
                        this.PEDIDO.Envio.CallePrincipal + " y " +
                        this.PEDIDO.Envio.CalleSecundaria + " | \n" + "Referencia: " +
                        this.PEDIDO.Envio.Referencia + " | " + this.PEDIDO.Envio.Piso;
                    txtReceptor.Text = this.PEDIDO.Envio.Cedula_Receptor;
                }
                else
                {
                    txtDirEnvio.Text = "Dirección no establecida - la entrega es en el local";
                    txtReceptor.Text = this.PEDIDO.Cedula;
                }

                if (this.PEDIDO.Estado == "Pendiente")
                {
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEntregar.Enabled = false;
                }else if (this.PEDIDO.Estado == "Aceptado")
                {
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnEntregar.Enabled = true;
                }else if (this.PEDIDO.Estado == "Entregado" || this.PEDIDO.Estado == "Cancelado")
                {
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEntregar.Enabled = false;
                }

            }
            catch
            {

            }
        }

        void LimpiarCampos()
        {
            txtCedula.Text = String.Empty;
            txtCliente.Text = String.Empty;
            txtContacto.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            txtDirEnvio.Text = String.Empty;
            txtFecha.Text = String.Empty;
            txtIdPedido.Text = String.Empty;
            txtMetodo.Text = String.Empty;
            txtPago.Text = String.Empty;
            txtTotal.Text = String.Empty;
            txtEstado.Text = String.Empty;
            txtReceptor.Text = String.Empty;
            detalleProductos.DataSource = null;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEntregar.Enabled = false;
        }

        async Task EditarPedidoAsync(string estado)
        {
            DateTime fecha = this.PEDIDO.Fecha;
            int anio = fecha.Year;
            int mes = fecha.Month;
            int dia = fecha.Day;
            int hora = fecha.Hour;
            int min = fecha.Minute;
            int seg = fecha.Second;
            string mesString = "0";
            string diaString = "0";
            string horaString = "0";
            string minString = "0";
            string segString = "0";

            mesString = mes < 10 ? mesString + mes.ToString() : mes.ToString();
            diaString = dia < 10 ? diaString + dia.ToString() : dia.ToString();
            horaString = hora < 10 ? horaString + hora.ToString() : hora.ToString();
            minString = min < 10 ?  minString + min.ToString() : min.ToString();
            segString = min < 10 ? segString + seg.ToString() : seg.ToString();
            


            string fech = anio.ToString() + mesString + diaString + horaString + minString + segString;
            Console.WriteLine(fecha);
            Dictionary<string, object> docData = new Dictionary<string, object>
            {
                { "Cedula", this.PEDIDO.Cedula },
                { "Cliente", this.PEDIDO.Cliente },
                { "Contacto", this.PEDIDO.Contacto },
                { "Correo", this.PEDIDO.Correo },
                { "Estado", estado },
                { "Fecha", fech },
                { "Id_Pago", this.PEDIDO.Id_Pago },
                { "Total", this.PEDIDO.Total },
            };

            ArrayList productos = new ArrayList();
            foreach (Productos producto in this.PEDIDO.Productos)
            {
                Dictionary<string, object> productoDic = new Dictionary<string, object>();
                productoDic.Add("Cantidad", producto.Cantidad);
                productoDic.Add("Id", producto.Id);
                productoDic.Add("Nombre", producto.Nombre);
                productoDic.Add("Precio", producto.Precio);
                productoDic.Add("Subtotal", producto.Precio);
                productos.Add(productoDic);
            }
                docData.Add("Productos", productos);
                Dictionary<string, object> envio = new Dictionary<string, object>();

            if (this.PEDIDO.Envio.Metodo == "A domicilio")
            {
                envio.Add("CallePrincipal", this.PEDIDO.Envio.CallePrincipal);
                envio.Add("CalleSecundaria", this.PEDIDO.Envio.CalleSecundaria);
                envio.Add("Canton", this.PEDIDO.Envio.Canton);
                envio.Add("Cedula_Receptor", this.PEDIDO.Envio.Cedula_Receptor);
                envio.Add("Metodo", this.PEDIDO.Envio.Metodo);
                envio.Add("Piso", this.PEDIDO.Envio.Piso);
                envio.Add("Provincia", this.PEDIDO.Envio.Provincia);
                envio.Add("Referencia", this.PEDIDO.Envio.Referencia);
            }
            else
            {
                envio.Add("Metodo", this.PEDIDO.Envio.Metodo);
            }

            docData.Add("Envio", envio);

            DocumentReference docRef = db.Collection("Pedidos").Document(this.PEDIDO.Id);
            DocumentSnapshot snap = await docRef.GetSnapshotAsync();
            if (snap.Exists)
            {
                WriteResult result = await docRef.SetAsync(docData);
                MessageBox.Show("Se ha actualizado un producto en la tienda de manera exitosa", "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Utilidad.EnviarEmail(this.PEDIDO.Correo, "Pedido "+ estado , DeterminarMensaje(estado));
            }

            ObtenerPedidos();
            LimpiarCampos();
        }


        string DeterminarMensaje(string estado)
        {
            string mensaje = "<h1>Hola! "+ this.PEDIDO.Cliente + ", te comunicamos que nuestra tienda...</h1>";
            string entrega = "";
            string productos = "";
            

            if (estado == "Aceptado")
            {
                foreach (Productos pedido in this.PEDIDO.Productos)
                {
                    productos = "<p>Sus productos son:</p> <ul>";
                    productos = productos + "<li>" + pedido.Nombre + " x " +
                        pedido.Cantidad + " x " + pedido.Precio + " | " + pedido.Subtotal
                        + "$" + "</li>";
                }
                productos = productos + "</ul> <br> <p>Total: " + this.PEDIDO.Total + " $ </p>";

                if (this.PEDIDO.Envio.Metodo == "A domicilio")
                {
                    entrega = "<p>Fecha máxima de entrega: " + this.PEDIDO.Fecha.AddDays(5) + " ( 5 días hábiles )</p>" +
                        "<p>Método de envío: " + this.PEDIDO.Envio.Metodo + "</p>" +
                        "<p>Dirección de entrega: " + this.PEDIDO.Envio.Provincia + " - " +
                        this.PEDIDO.Envio.Canton + " | " + this.PEDIDO.Envio.CallePrincipal + ", " +
                        this.PEDIDO.Envio.CalleSecundaria + "| Piso: " + this.PEDIDO.Envio.Piso +
                        " | Referencia: " + this.PEDIDO.Envio.Referencia + "</p>" +
                        "<p>Se entregará unicamente al portador de la cédula o RUC N°: " +
                        this.PEDIDO.Envio.Cedula_Receptor + "</p>" +
                        "<p>Nos comunicaremos al número " + this.PEDIDO.Contacto + " el día de la entrega</p>"+
                        "<p>Gracias por su compra!</p>";
                }
                else
                {
                    entrega = "<p>La fecha de entrega se relizará el día que se quede deacuerdo con el cliente ( en días hábiles )</p>" +
                        "<p>Horario de atención del local: 09:00 AM - 06:00 PM</p>" +
                        "<p>Dirección del local: Tungurahua - Ambato, Dirección del local 12345</p>" +
                         "<p>Se entregará unicamente al portador de la cédula o RUC N°: " +
                        this.PEDIDO.Cedula + "</p>" +
                        "<p>Nos comunicaremos al número " + this.PEDIDO.Contacto + " para acordar el día de la entrega</p>" +
                        "<p>Gracias por su compra!</p>";
                }

                mensaje = mensaje  + "<h2>Ha recibido tu pedido</h2>"+
                    "<small>Si desea cancelar(anular) el pedido responder este email y lo contactaremos para verificar la anulación</small>";
            }
            else if(estado == "Cancelado")
            {
                mensaje = mensaje + "<h2>Ha cancelado/rechazado tu pedido</h2><br>"+
                    "<p>Se realizará la devolución del dinero del pedido en un máximo de 24 horas</p>";
            }
            else
            {
                mensaje = mensaje + "<h2>Ha entregado tu pedido</h2><br>" +
                    "<p>Se realizó la entrega de los productos del pedido exitosamente</p>"+
                    "<p>Gracias por su compra!</p>";
            }
            mensaje = mensaje + productos + entrega;
            return mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea aceptar este pedido?\n Verifique antes que los productos se encuentren disponibles en la cantidad especificada",
                 "Canfirmación de actualización de estado del pedido" ,
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ = EditarPedidoAsync("Aceptado");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ObtenerPedidos();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea rechazar este pedido?\n Luego de rechazar el pedido, el pedido se cancelará y ya no podrá aceptarlo nuevamente",
                 "Canfirmación de actualización de estado del pedido",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
            _ = EditarPedidoAsync("Cancelado");
            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea marcar el pedido como entregado?\n Verifique que se ha entregado el pedido al respectivo cliente",
                 "Canfirmación de actualización de estado del pedido",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
            _ = EditarPedidoAsync("Entregado");
            }
        }

        private void detalleProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarPorTexto(comboBusqueda.SelectedIndex + 1);
        }

        private void btnPedidosHoy_Click(object sender, EventArgs e)
        {
            FiltrarPorFecha(1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
