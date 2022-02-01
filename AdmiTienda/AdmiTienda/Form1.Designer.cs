
namespace AdmiTienda
{
    partial class PRODUCTOFORM
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
            this.components = new System.ComponentModel.Container();
            this.btnImagen1 = new System.Windows.Forms.Button();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtImg3 = new System.Windows.Forms.TextBox();
            this.btnImagen3 = new System.Windows.Forms.Button();
            this.txtImg2 = new System.Windows.Forms.TextBox();
            this.btnImagen2 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnNoOferta = new System.Windows.Forms.RadioButton();
            this.rbtOferta = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioOferta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listaProductos = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.comboBusqueda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBuscarCategoria = new System.Windows.Forms.ComboBox();
            this.groupBusqueda = new System.Windows.Forms.GroupBox();
            this.rbtFalse = new System.Windows.Forms.RadioButton();
            this.rbtTrue = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImagen1
            // 
            this.btnImagen1.Location = new System.Drawing.Point(286, 46);
            this.btnImagen1.Name = "btnImagen1";
            this.btnImagen1.Size = new System.Drawing.Size(75, 23);
            this.btnImagen1.TabIndex = 0;
            this.btnImagen1.Text = "Seleccionar";
            this.btnImagen1.UseVisualStyleBackColor = true;
            this.btnImagen1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(22, 48);
            this.txtImg.Name = "txtImg";
            this.txtImg.ReadOnly = true;
            this.txtImg.Size = new System.Drawing.Size(258, 20);
            this.txtImg.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(257, 619);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 43);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button2_ClickAsync);
            // 
            // txtImg3
            // 
            this.txtImg3.Location = new System.Drawing.Point(22, 108);
            this.txtImg3.Name = "txtImg3";
            this.txtImg3.ReadOnly = true;
            this.txtImg3.Size = new System.Drawing.Size(258, 20);
            this.txtImg3.TabIndex = 5;
            // 
            // btnImagen3
            // 
            this.btnImagen3.Location = new System.Drawing.Point(286, 106);
            this.btnImagen3.Name = "btnImagen3";
            this.btnImagen3.Size = new System.Drawing.Size(75, 23);
            this.btnImagen3.TabIndex = 2;
            this.btnImagen3.Text = "Seleccionar";
            this.btnImagen3.UseVisualStyleBackColor = true;
            this.btnImagen3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtImg2
            // 
            this.txtImg2.Location = new System.Drawing.Point(22, 77);
            this.txtImg2.Name = "txtImg2";
            this.txtImg2.ReadOnly = true;
            this.txtImg2.Size = new System.Drawing.Size(258, 20);
            this.txtImg2.TabIndex = 7;
            // 
            // btnImagen2
            // 
            this.btnImagen2.Location = new System.Drawing.Point(286, 75);
            this.btnImagen2.Name = "btnImagen2";
            this.btnImagen2.Size = new System.Drawing.Size(75, 23);
            this.btnImagen2.TabIndex = 1;
            this.btnImagen2.Text = "Seleccionar";
            this.btnImagen2.UseVisualStyleBackColor = true;
            this.btnImagen2.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(12, 289);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(366, 159);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "NOMBRE DEL PRODUCTO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNoOferta);
            this.groupBox1.Controls.Add(this.rbtOferta);
            this.groupBox1.Location = new System.Drawing.Point(282, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 82);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EN OFERTA:";
            // 
            // rbtnNoOferta
            // 
            this.rbtnNoOferta.AutoSize = true;
            this.rbtnNoOferta.Location = new System.Drawing.Point(21, 50);
            this.rbtnNoOferta.Name = "rbtnNoOferta";
            this.rbtnNoOferta.Size = new System.Drawing.Size(41, 17);
            this.rbtnNoOferta.TabIndex = 1;
            this.rbtnNoOferta.TabStop = true;
            this.rbtnNoOferta.Text = "NO";
            this.rbtnNoOferta.UseVisualStyleBackColor = true;
            this.rbtnNoOferta.CheckedChanged += new System.EventHandler(this.rbtnNoOferta_CheckedChanged);
            // 
            // rbtOferta
            // 
            this.rbtOferta.AutoSize = true;
            this.rbtOferta.Location = new System.Drawing.Point(21, 23);
            this.rbtOferta.Name = "rbtOferta";
            this.rbtOferta.Size = new System.Drawing.Size(35, 17);
            this.rbtOferta.TabIndex = 0;
            this.rbtOferta.TabStop = true;
            this.rbtOferta.Text = "SI";
            this.rbtOferta.UseVisualStyleBackColor = true;
            this.rbtOferta.CheckedChanged += new System.EventHandler(this.rbtOferta_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rbtInactivo);
            this.groupBox2.Controls.Add(this.rbtActivo);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(11, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 82);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ESTADO DEL PRODUCTO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "El producto se publica en la tienda al activarlo";
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(155, 50);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(75, 17);
            this.rbtInactivo.TabIndex = 1;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "INACTIVO";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Location = new System.Drawing.Point(79, 50);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(64, 17);
            this.rbtActivo.TabIndex = 0;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "ACTIVO";
            this.rbtActivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "PRECIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = " % DESCUENTO:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPrecioOferta
            // 
            this.txtPrecioOferta.Location = new System.Drawing.Point(271, 234);
            this.txtPrecioOferta.Name = "txtPrecioOferta";
            this.txtPrecioOferta.Size = new System.Drawing.Size(101, 20);
            this.txtPrecioOferta.TabIndex = 5;
            this.txtPrecioOferta.TextChanged += new System.EventHandler(this.txtPrecioOferta_TextChanged);
            this.txtPrecioOferta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioOferta_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "DESCRIPCIÓN DEL PRODUCTO:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(59, 234);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(101, 20);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtImg);
            this.groupBox3.Controls.Add(this.btnImagen1);
            this.groupBox3.Controls.Add(this.btnImagen3);
            this.groupBox3.Controls.Add(this.txtImg3);
            this.groupBox3.Controls.Add(this.btnImagen2);
            this.groupBox3.Controls.Add(this.txtImg2);
            this.groupBox3.Location = new System.Drawing.Point(11, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 143);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IMAGENES DEL PRODUCTO:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seleccione al menos una imagen para el producto:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(133, 619);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 43);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(10, 619);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 43);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Items.AddRange(new object[] {
            "TELEVISORES",
            "ACCESORIOS DE TV Y VIDEO",
            "PARLANTES Y AUDIO",
            "COMPUTADORAS Y LAPTOPS",
            "IMPRESORAS",
            "WEBCAMS",
            "PENDRIVES",
            "SOFTWARE",
            "JUEGOS",
            "CONTROLES",
            "CONSOLAS",
            "CELULARES",
            "SMARTWATCHES Y ACCESORIOS",
            "REPUESTOS"});
            this.comboCategoria.Location = new System.Drawing.Point(90, 116);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(282, 21);
            this.comboCategoria.TabIndex = 3;
            this.comboCategoria.SelectedIndexChanged += new System.EventHandler(this.comboCategoria_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "CATEGORIA:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // listaProductos
            // 
            this.listaProductos.AllowUserToOrderColumns = true;
            this.listaProductos.AllowUserToResizeColumns = false;
            this.listaProductos.AllowUserToResizeRows = false;
            this.listaProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaProductos.Location = new System.Drawing.Point(6, 19);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.ReadOnly = true;
            this.listaProductos.Size = new System.Drawing.Size(666, 565);
            this.listaProductos.TabIndex = 25;
            this.listaProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listaProductos_CellMouseClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(223, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(248, 43);
            this.button7.TabIndex = 1;
            this.button7.Text = "MOSTRAR TODOS LOS PRODUCTOS";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(11, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(206, 43);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "REGISTRAR NUEVO PRODUCTO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listaProductos);
            this.groupBox4.Location = new System.Drawing.Point(384, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(679, 590);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PRODUCTOS DE LA TIENDA";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(784, 28);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(248, 20);
            this.txtBusqueda.TabIndex = 11;
            this.txtBusqueda.Visible = false;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // comboBusqueda
            // 
            this.comboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBusqueda.FormattingEnabled = true;
            this.comboBusqueda.Items.AddRange(new object[] {
            "POR ID",
            "POR CATEGORÍA",
            "POR NOMBRE ",
            "POR ESTADO",
            "POR OFERTA"});
            this.comboBusqueda.Location = new System.Drawing.Point(646, 24);
            this.comboBusqueda.Name = "comboBusqueda";
            this.comboBusqueda.Size = new System.Drawing.Size(122, 21);
            this.comboBusqueda.TabIndex = 10;
            this.comboBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "BUSCAR PRODUCTO";
            // 
            // comboBuscarCategoria
            // 
            this.comboBuscarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuscarCategoria.FormattingEnabled = true;
            this.comboBuscarCategoria.Items.AddRange(new object[] {
            "TELEVISORES",
            "ACCESORIOS DE TV Y VIDEO",
            "PARLANTES Y AUDIO",
            "COMPUTADORAS Y LAPTOPS",
            "IMPRESORAS",
            "WEBCAMS",
            "PENDRIVES",
            "SOFTWARE",
            "JUEGOS",
            "CONTROLES",
            "CONSOLAS",
            "CELULARES",
            "SMARTWATCHES Y ACCESORIOS",
            "REPUESTOS"});
            this.comboBuscarCategoria.Location = new System.Drawing.Point(784, 27);
            this.comboBuscarCategoria.Name = "comboBuscarCategoria";
            this.comboBuscarCategoria.Size = new System.Drawing.Size(185, 21);
            this.comboBuscarCategoria.TabIndex = 33;
            this.comboBuscarCategoria.Visible = false;
            this.comboBuscarCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBuscarCategoria_SelectedIndexChanged);
            // 
            // groupBusqueda
            // 
            this.groupBusqueda.Controls.Add(this.rbtFalse);
            this.groupBusqueda.Controls.Add(this.rbtTrue);
            this.groupBusqueda.Location = new System.Drawing.Point(784, 12);
            this.groupBusqueda.Name = "groupBusqueda";
            this.groupBusqueda.Size = new System.Drawing.Size(226, 49);
            this.groupBusqueda.TabIndex = 15;
            this.groupBusqueda.TabStop = false;
            this.groupBusqueda.Text = "Valor:";
            this.groupBusqueda.Visible = false;
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
            this.rbtTrue.Location = new System.Drawing.Point(65, 21);
            this.rbtTrue.Name = "rbtTrue";
            this.rbtTrue.Size = new System.Drawing.Size(64, 17);
            this.rbtTrue.TabIndex = 0;
            this.rbtTrue.TabStop = true;
            this.rbtTrue.Text = "ACTIVO";
            this.rbtTrue.UseVisualStyleBackColor = true;
            this.rbtTrue.CheckedChanged += new System.EventHandler(this.rbtTrue_CheckedChanged);
            // 
            // PRODUCTOFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1068, 676);
            this.Controls.Add(this.groupBusqueda);
            this.Controls.Add(this.comboBuscarCategoria);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioOferta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PRODUCTOFORM";
            this.Text = "PRODUCTOS DE LA TIENDA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBusqueda.ResumeLayout(false);
            this.groupBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImagen1;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtImg3;
        private System.Windows.Forms.Button btnImagen3;
        private System.Windows.Forms.TextBox txtImg2;
        private System.Windows.Forms.Button btnImagen2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNoOferta;
        private System.Windows.Forms.RadioButton rbtOferta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioOferta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView listaProductos;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox comboBusqueda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBuscarCategoria;
        private System.Windows.Forms.GroupBox groupBusqueda;
        private System.Windows.Forms.RadioButton rbtFalse;
        private System.Windows.Forms.RadioButton rbtTrue;
    }
}

