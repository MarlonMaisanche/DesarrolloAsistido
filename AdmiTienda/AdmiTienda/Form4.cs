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
    public partial class MENUFORM : Form
    {
        PEDIDOFORM formPedido;
        PRODUCTOFORM formProducto;
        public LOGIN formLogin;
        public MENUFORM()
        {
            InitializeComponent();
            int i_PresentHeight = Screen.PrimaryScreen.Bounds.Height;
            int i_PresentWidth = Screen.PrimaryScreen.Bounds.Width;
            var alto = this.panelContenido.Bounds.Height;
            var ancho = this.panelContenido.Bounds.Width;

            formPedido = new PEDIDOFORM();
            formPedido.SetBounds(0, 0, ancho, alto);
            formProducto = new PRODUCTOFORM();
            formProducto.SetBounds(0, 0, ancho, alto);
            panelContenido.BackColor = Color.FromArgb(49,66,82);
            this.WindowState = FormWindowState.Maximized;

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormulario(1);
        }

        void abrirFormulario(int opcion)
        {
            if (this.panelContenido.Controls.Count > 0)
            {
                this.panelContenido.Controls.RemoveAt(0);
            }
            if (opcion == 1)
            {
                this.formProducto.TopLevel = false;
                this.panelContenido.Controls.Add(this.formProducto);
                this.panelContenido.Tag = this.formProducto;
                this.formProducto.Show();
            }
            else
            {
                this.formPedido.TopLevel = false;
                this.panelContenido.Controls.Add(this.formPedido);
                this.panelContenido.Tag = this.formPedido;
                this.formPedido.Show();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormulario(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formLogin.Show();
        }

        private void MENUFORM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que dese salir?", "Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                this.Close();
                Application.Exit();
            } 
        }
    }
}
