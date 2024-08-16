using System;
using System.Windows.Forms;
using Dominio;

namespace App
{
    public partial class FormEleccionCantidad : Form
    {
        public Articulo ArticuloSeleccionado { get; private set; }
        public int CantidadSeleccionada { get; private set; }

        public FormEleccionCantidad(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            ArticuloSeleccionado = articuloSeleccionado;

            // Asignar los valores del artículo seleccionado a los controles
            labelNombreArticulo.Text = articuloSeleccionado.Nombre;
            textBoxStock.Text = articuloSeleccionado.stock.ToString();
            textBoxStock.Enabled = false; // Hacer que el TextBox esté deshabilitado

            // Inicializar la etiqueta de error
            labelError.Visible = false; // Suponiendo que `labelError` es la etiqueta para mostrar el error
            labelError.ForeColor = System.Drawing.Color.Red; // Configurar el color del texto a rojo
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            // Validar que se ha introducido una cantidad válida
            if (int.TryParse(textBoxCantidad.Text, out int cantidad) && cantidad > 0)
            {
                if (cantidad <= ArticuloSeleccionado.stock)
                {
                    CantidadSeleccionada = cantidad;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Mostrar mensaje de error si la cantidad es mayor al stock
                    labelError.Text = "* Stock insuficiente";
                    labelError.Visible = true;
                }
            }
            else
            {
                // Mostrar mensaje de error si la cantidad no es válida
                MessageBox.Show("Por favor, introduzca una cantidad válida.");
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




