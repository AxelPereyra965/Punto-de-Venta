using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class FormPrincipal : Form
    {
        private FormInventario frInventario;
        private FormVenta frVentas;
        public FormPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;
            frInventario = new FormInventario { MdiParent = this };
            frVentas = new FormVenta { MdiParent = this };

            // Suscribir al evento Load de los formularios hijos para maximizarlos cuando se carguen
            frInventario.Load += FrHijo_Load;
            frVentas.Load += FrHijo_Load;
        }

        private void FrHijo_Load(object sender, EventArgs e)
        {
            Form childForm = sender as Form;
            if (childForm != null)
            {
                childForm.WindowState = FormWindowState.Maximized;
            }
        }



        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            frInventario.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frVentas.Visible)
            {
                frVentas.Hide(); // Ocultar el formulario de ventas si está visible
            }
            if (!frInventario.Visible)
            {
                frInventario.Show(); // Mostrar el formulario de inventario si no está visible
            }
            frInventario.WindowState = FormWindowState.Maximized; // Asegurar que esté maximizado
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frInventario.Visible)
            {
                frInventario.Hide(); // Ocultar el formulario de inventario si está visible
            }
            if (!frVentas.Visible)
            {
                frVentas.Show(); // Mostrar el formulario de ventas si no está visible
            }
            frVentas.WindowState = FormWindowState.Maximized; // Asegurar que esté maximizado
        }
    }
}