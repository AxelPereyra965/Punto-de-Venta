using Dominio;
using Manager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App
{
    public partial class FormBuscar : Form
    {
        private List<Articulo> ListaArticulos;
        private Articulo articuloSeleccionado;
        private FormVenta formVenta;

        public FormBuscar(FormVenta formVenta)
        {
            InitializeComponent();
            this.formVenta = formVenta;
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            ArticuloManager ArtiManager = new ArticuloManager();
            ListaArticulos = ArtiManager.listar();
            DgvArticulos.DataSource = ListaArticulos;
            ocultarColumnas();
        }

        private void ocultarColumnas()
        {
            DgvArticulos.Columns["ImagenUrl"].Visible = false;
            DgvArticulos.Columns["Id"].Visible = false;
            DgvArticulos.Columns["Codigo"].Visible = false;
            DgvArticulos.Columns["Descripcion"].Visible = false;
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = textBoxBuscar.Text;

            if (filtro.Length >= 3) //aca indico que busque a partir de 3 caracteres
            {
                listaFiltrada = ListaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.TipoCategoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.TipoMarca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = ListaArticulos;
            }

            DgvArticulos.DataSource = null;
            DgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvArticulos.CurrentRow != null)
            {
                articuloSeleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            }
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (articuloSeleccionado != null)
            {
                FormEleccionCantidad FrEleccionCantidad = new FormEleccionCantidad(articuloSeleccionado);
                if (FrEleccionCantidad.ShowDialog() == DialogResult.OK)
                {
                    formVenta.AgregarArticuloAlDataGridView(articuloSeleccionado, FrEleccionCantidad.CantidadSeleccionada);
                    this.DialogResult = DialogResult.OK; // Cerrar este formulario
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo.");
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



