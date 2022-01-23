
namespace AdmiTienda
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBusqueda = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listaPedidos = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMetodo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDirEnvio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.Label();
            this.detalleProductos = new System.Windows.Forms.DataGridView();
            this.txtFecha = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.comboBuscarFecha = new System.Windows.Forms.ComboBox();
            this.comboBuscarEstado = new System.Windows.Forms.ComboBox();
            this.groupBusquedaEstado = new System.Windows.Forms.GroupBox();
            this.rbtFalse = new System.Windows.Forms.RadioButton();
            this.rbtTrue = new System.Windows.Forms.RadioButton();
            this.comboBuscarConFecha = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtReceptor = new System.Windows.Forms.Label();
            this.lblTemporalidad = new System.Windows.Forms.Label();
            this.btnPedidosHoy = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleProductos)).BeginInit();
            this.groupBusquedaEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(18, 11);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(181, 43);
            this.button7.TabIndex = 27;
            this.button7.Text = "TODOS LOS PEDIDOS / REFRESCAR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "BUSCAR PEDIDO";
            // 
            // comboBusqueda
            // 
            this.comboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusqueda.FormattingEnabled = true;
            this.comboBusqueda.Items.AddRange(new object[] {
            "POR ID",
            "POR ID PAGO",
            "POR CEDULA CLIENTE",
            "POR MÉTODO ENVÍO",
            "POR ESTADO",
            "POR FECHA"});
            this.comboBusqueda.Location = new System.Drawing.Point(413, 23);
            this.comboBusqueda.Name = "comboBusqueda";
            this.comboBusqueda.Size = new System.Drawing.Size(134, 21);
            this.comboBusqueda.TabIndex = 36;
            this.comboBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBusqueda_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listaPedidos);
            this.groupBox4.Location = new System.Drawing.Point(12, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(856, 525);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PEDIDOS DE LA TIENDA";
            // 
            // listaPedidos
            // 
            this.listaPedidos.AllowUserToOrderColumns = true;
            this.listaPedidos.AllowUserToResizeColumns = false;
            this.listaPedidos.AllowUserToResizeRows = false;
            this.listaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPedidos.Location = new System.Drawing.Point(6, 19);
            this.listaPedidos.Name = "listaPedidos";
            this.listaPedidos.ReadOnly = true;
            this.listaPedidos.Size = new System.Drawing.Size(844, 500);
            this.listaPedidos.TabIndex = 25;
            this.listaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaPedidos_CellContentClick);
            this.listaPedidos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listaPedidos_CellMouseClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(283, 490);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(127, 43);
            this.btnAceptar.TabIndex = 40;
            this.btnAceptar.Text = "ACEPTAR PEDIDO";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(17, 490);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 43);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "RECHAZAR / CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEntregar
            // 
            this.btnEntregar.Enabled = false;
            this.btnEntregar.Location = new System.Drawing.Point(150, 490);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(127, 43);
            this.btnEntregar.TabIndex = 42;
            this.btnEntregar.Text = "MARCAR COMO ENTREGADO";
            this.btnEntregar.UseVisualStyleBackColor = true;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMetodo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIdPedido);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtPago);
            this.groupBox1.Controls.Add(this.detalleProductos);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtContacto);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbCliente);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.btnEntregar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Location = new System.Drawing.Point(874, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 599);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALLE DEL PEDIDO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(24, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "CLIENTE:";
            // 
            // txtMetodo
            // 
            this.txtMetodo.AutoSize = true;
            this.txtMetodo.Location = new System.Drawing.Point(343, 33);
            this.txtMetodo.Name = "txtMetodo";
            this.txtMetodo.Size = new System.Drawing.Size(90, 13);
            this.txtMetodo.TabIndex = 56;
            this.txtMetodo.Text = "METODO ENVÍO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReceptor);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDirEnvio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(6, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 90);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "DIR ENVÍO:";
            // 
            // txtDirEnvio
            // 
            this.txtDirEnvio.AutoSize = true;
            this.txtDirEnvio.Location = new System.Drawing.Point(8, 38);
            this.txtDirEnvio.Name = "txtDirEnvio";
            this.txtDirEnvio.Size = new System.Drawing.Size(62, 13);
            this.txtDirEnvio.TabIndex = 59;
            this.txtDirEnvio.Text = "DIR ENVÍO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(24, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "ID CLIENTE:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(242, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "METODO ENVÍO:";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.AutoSize = true;
            this.txtIdPedido.Location = new System.Drawing.Point(81, 19);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(59, 13);
            this.txtIdPedido.TabIndex = 62;
            this.txtIdPedido.Text = "IDPEDIDO";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(342, 205);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(42, 13);
            this.txtTotal.TabIndex = 61;
            this.txtTotal.Text = "TOTAL";
            // 
            // txtPago
            // 
            this.txtPago.AutoSize = true;
            this.txtPago.Location = new System.Drawing.Point(85, 184);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(51, 13);
            this.txtPago.TabIndex = 60;
            this.txtPago.Text = "ID PAGO";
            // 
            // detalleProductos
            // 
            this.detalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleProductos.Location = new System.Drawing.Point(6, 226);
            this.detalleProductos.Name = "detalleProductos";
            this.detalleProductos.ReadOnly = true;
            this.detalleProductos.Size = new System.Drawing.Size(424, 241);
            this.detalleProductos.TabIndex = 57;
            this.detalleProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detalleProductos_CellContentClick);
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Location = new System.Drawing.Point(294, 48);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(42, 13);
            this.txtFecha.TabIndex = 55;
            this.txtFecha.Text = "FECHA";
            // 
            // txtContacto
            // 
            this.txtContacto.AutoSize = true;
            this.txtContacto.Location = new System.Drawing.Point(319, 18);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(66, 13);
            this.txtContacto.TabIndex = 54;
            this.txtContacto.Text = "CONTACTO";
            // 
            // txtCedula
            // 
            this.txtCedula.AutoSize = true;
            this.txtCedula.Location = new System.Drawing.Point(102, 35);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(17, 13);
            this.txtCedula.TabIndex = 53;
            this.txtCedula.Text = "CI";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Location = new System.Drawing.Point(87, 65);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(53, 13);
            this.txtCorreo.TabIndex = 52;
            this.txtCorreo.Text = "CORREO";
            // 
            // txtCliente
            // 
            this.txtCliente.AutoSize = true;
            this.txtCliente.Location = new System.Drawing.Point(86, 51);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(52, 13);
            this.txtCliente.TabIndex = 51;
            this.txtCliente.Text = "CLIENTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(285, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "TOTAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(24, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "ID PAGO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(242, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "FECHA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "PEDIDO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "CORREO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(242, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "CONTACTO:";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(24, 35);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(63, 13);
            this.lbCliente.TabIndex = 43;
            this.lbCliente.Text = "CLIENTE:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(560, 23);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(248, 20);
            this.txtBusqueda.TabIndex = 35;
            this.txtBusqueda.Visible = false;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // comboBuscarFecha
            // 
            this.comboBuscarFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscarFecha.FormattingEnabled = true;
            this.comboBuscarFecha.Items.AddRange(new object[] {
            "HOY",
            "ULTIMA SEMANA",
            "ULTIMO MES",
            "ULTIMOS TRES MESES",
            "ULTIMOS SEIS MESES ",
            "ULTIMO AÑO"});
            this.comboBuscarFecha.Location = new System.Drawing.Point(560, 23);
            this.comboBuscarFecha.Name = "comboBuscarFecha";
            this.comboBuscarFecha.Size = new System.Drawing.Size(185, 21);
            this.comboBuscarFecha.TabIndex = 38;
            this.comboBuscarFecha.Visible = false;
            this.comboBuscarFecha.SelectedIndexChanged += new System.EventHandler(this.comboBuscarFecha_SelectedIndexChanged);
            // 
            // comboBuscarEstado
            // 
            this.comboBuscarEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscarEstado.FormattingEnabled = true;
            this.comboBuscarEstado.Items.AddRange(new object[] {
            "PENDIENTE",
            "ACEPTADO",
            "CANCELADO",
            "ENTREGADO"});
            this.comboBuscarEstado.Location = new System.Drawing.Point(560, 23);
            this.comboBuscarEstado.Name = "comboBuscarEstado";
            this.comboBuscarEstado.Size = new System.Drawing.Size(185, 21);
            this.comboBuscarEstado.TabIndex = 44;
            this.comboBuscarEstado.Visible = false;
            this.comboBuscarEstado.SelectedIndexChanged += new System.EventHandler(this.comboBuscarEstado_SelectedIndexChanged);
            // 
            // groupBusquedaEstado
            // 
            this.groupBusquedaEstado.Controls.Add(this.rbtFalse);
            this.groupBusquedaEstado.Controls.Add(this.rbtTrue);
            this.groupBusquedaEstado.Location = new System.Drawing.Point(560, 9);
            this.groupBusquedaEstado.Name = "groupBusquedaEstado";
            this.groupBusquedaEstado.Size = new System.Drawing.Size(226, 49);
            this.groupBusquedaEstado.TabIndex = 45;
            this.groupBusquedaEstado.TabStop = false;
            this.groupBusquedaEstado.Text = "Valor:";
            this.groupBusquedaEstado.Visible = false;
            // 
            // rbtFalse
            // 
            this.rbtFalse.AutoSize = true;
            this.rbtFalse.Location = new System.Drawing.Point(135, 21);
            this.rbtFalse.Name = "rbtFalse";
            this.rbtFalse.Size = new System.Drawing.Size(75, 17);
            this.rbtFalse.TabIndex = 1;
            this.rbtFalse.TabStop = true;
            this.rbtFalse.Text = "INACTIVO";
            this.rbtFalse.UseVisualStyleBackColor = true;
            this.rbtFalse.CheckedChanged += new System.EventHandler(this.rbtFalse_CheckedChanged);
            // 
            // rbtTrue
            // 
            this.rbtTrue.AutoSize = true;
            this.rbtTrue.Location = new System.Drawing.Point(24, 21);
            this.rbtTrue.Name = "rbtTrue";
            this.rbtTrue.Size = new System.Drawing.Size(64, 17);
            this.rbtTrue.TabIndex = 0;
            this.rbtTrue.TabStop = true;
            this.rbtTrue.Text = "ACTIVO";
            this.rbtTrue.UseVisualStyleBackColor = true;
            this.rbtTrue.CheckedChanged += new System.EventHandler(this.rbtTrue_CheckedChanged);
            // 
            // comboBuscarConFecha
            // 
            this.comboBuscarConFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscarConFecha.FormattingEnabled = true;
            this.comboBuscarConFecha.Items.AddRange(new object[] {
            "HOY",
            "ULTIMA SEMANA",
            "ULTIMO MES",
            "ULTIMOS TRES MESES",
            "ULTIMOS SEIS MESES ",
            "ULTIMO AÑO"});
            this.comboBuscarConFecha.Location = new System.Drawing.Point(635, 60);
            this.comboBuscarConFecha.Name = "comboBuscarConFecha";
            this.comboBuscarConFecha.Size = new System.Drawing.Size(185, 21);
            this.comboBuscarConFecha.TabIndex = 46;
            this.comboBuscarConFecha.Visible = false;
            this.comboBuscarConFecha.SelectedIndexChanged += new System.EventHandler(this.comboBuscarConFecha_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(9, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "PRODUCTOS PEDIDOS:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(215, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 67;
            this.label13.Text = "RECEPTOR:";
            // 
            // txtReceptor
            // 
            this.txtReceptor.AutoSize = true;
            this.txtReceptor.Location = new System.Drawing.Point(292, 16);
            this.txtReceptor.Name = "txtReceptor";
            this.txtReceptor.Size = new System.Drawing.Size(66, 13);
            this.txtReceptor.TabIndex = 67;
            this.txtReceptor.Text = "RECEPTOR";
            // 
            // lblTemporalidad
            // 
            this.lblTemporalidad.AutoSize = true;
            this.lblTemporalidad.Location = new System.Drawing.Point(534, 63);
            this.lblTemporalidad.Name = "lblTemporalidad";
            this.lblTemporalidad.Size = new System.Drawing.Size(95, 13);
            this.lblTemporalidad.TabIndex = 47;
            this.lblTemporalidad.Text = "TEMPORALIDAD:";
            this.lblTemporalidad.Visible = false;
            // 
            // btnPedidosHoy
            // 
            this.btnPedidosHoy.Location = new System.Drawing.Point(205, 12);
            this.btnPedidosHoy.Name = "btnPedidosHoy";
            this.btnPedidosHoy.Size = new System.Drawing.Size(103, 43);
            this.btnPedidosHoy.TabIndex = 48;
            this.btnPedidosHoy.Text = "PEDIDOS DEL DIA";
            this.btnPedidosHoy.UseVisualStyleBackColor = true;
            this.btnPedidosHoy.Click += new System.EventHandler(this.btnPedidosHoy_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 623);
            this.Controls.Add(this.btnPedidosHoy);
            this.Controls.Add(this.lblTemporalidad);
            this.Controls.Add(this.comboBuscarConFecha);
            this.Controls.Add(this.groupBusquedaEstado);
            this.Controls.Add(this.comboBuscarEstado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.comboBuscarFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.button7);
            this.Name = "Form2";
            this.Text = "PEDIDOS";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleProductos)).EndInit();
            this.groupBusquedaEstado.ResumeLayout(false);
            this.groupBusquedaEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBusqueda;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView listaPedidos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label txtCedula;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label txtPago;
        private System.Windows.Forms.Label txtDirEnvio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView detalleProductos;
        private System.Windows.Forms.Label txtMetodo;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Label txtContacto;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox comboBuscarFecha;
        private System.Windows.Forms.ComboBox comboBuscarEstado;
        private System.Windows.Forms.GroupBox groupBusquedaEstado;
        private System.Windows.Forms.RadioButton rbtFalse;
        private System.Windows.Forms.RadioButton rbtTrue;
        private System.Windows.Forms.Label txtIdPedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBuscarConFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtReceptor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTemporalidad;
        private System.Windows.Forms.Button btnPedidosHoy;
    }
}