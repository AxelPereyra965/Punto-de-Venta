using Dominio;
using Manager;
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
    public partial class FormInventario : Form
    {
        private List<Articulo> ListaArticulos;

        public FormInventario()
        {
            InitializeComponent();
            this.Activated += new EventHandler(FormInventario_Activated);
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            // Cargar los datos
            Cargar();
            ComboBoxCampo.Items.Add("precio");
            ComboBoxCampo.Items.Add("nombre");
            ComboBoxCampo.Items.Add("categoría");
        }

        private void FormInventario_Activated(object sender, EventArgs e)
        {
            // Recargar los datos cuando el formulario se activa
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

        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void CargarImagen(string img)
        {
            try
            {
                if (!string.IsNullOrEmpty(img))
                {
                    pictureBoxArticulos.Load(img);
                }
                else
                {
                    pictureBoxArticulos.Load("https://mexicana.cultura.gob.mx/work/models/repositorio/img/empty.jpg");
                }
            }
            catch (Exception ex)
            {
                pictureBoxArticulos.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarModificar alta = new FormAgregarModificar();
            alta.ShowDialog(); // Traigo el otro formulario de agregar al hacer clic 
            Cargar();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;

            // Uso la sobrecarga del constructor del formulario
            FormAgregarModificar _FRModificar = new FormAgregarModificar(seleccionado);
            _FRModificar.ShowDialog();
            Cargar();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            ArticuloManager ArtiManager = new ArticuloManager();
            Articulo ArtiSeleccionado = new Articulo();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    ArtiSeleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
                    ArtiManager.eliminarLogico(ArtiSeleccionado.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TextBoxFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = TextBoxFiltroRapido.Text;

            if (filtro.Length >= 3) // Indico que busque a partir de 3 caracteres
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

        private void ComboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = ComboBoxCampo.SelectedItem.ToString(); // Capturo la selección
            if (opcion == "precio")
            {
                ComboBoxCriterio.Items.Clear();
                ComboBoxCriterio.Items.Add("Mayor a");
                ComboBoxCriterio.Items.Add("Menor a");
                ComboBoxCriterio.Items.Add("Igual a");
            }
            else
            {
                ComboBoxCriterio.Items.Clear();
                ComboBoxCriterio.Items.Add("Comienza con");
                ComboBoxCriterio.Items.Add("Termina con");
                ComboBoxCriterio.Items.Add("Contiene");
            }
        }

        private bool validarFiltro()
        {
            if (ComboBoxCampo.SelectedIndex < 0) // Pregunto si campo no tiene nada seleccionado
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (ComboBoxCriterio.SelectedIndex < 0) // Pregunto si criterio no tiene nada seleccionado
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (ComboBoxCampo.SelectedItem.ToString() == "precio") // Pregunto si campo es precio
            {
                if (string.IsNullOrEmpty(textBoxFiltroAvanzado.Text)) // Si el filtro está vacío o null
                {
                    MessageBox.Show("Debes cargar el filtro...");
                    return true;
                }
                if (!(soloNumeros(textBoxFiltroAvanzado.Text))) // Por qué está en opción numérico
                {
                    MessageBox.Show("Solo números para filtrar por un campo numérico...");
                    return true;
                }
            }
            if (ComboBoxCampo.SelectedItem.ToString() == "nombre" || ComboBoxCampo.SelectedItem.ToString() == "categoría")
            {
                if (string.IsNullOrEmpty(textBoxFiltroAvanzado.Text)) // Si el filtro está vacío o null
                {
                    MessageBox.Show("Debes cargar el filtro...");
                    return true;
                }
                if ((soloNumeros(textBoxFiltroAvanzado.Text))) // Por qué está en opción texto
                {
                    MessageBox.Show("Solo letras para filtrar por un campo de texto...");
                    return true;
                }
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void BotonFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloManager ArtiManager = new ArticuloManager();
            try
            {
                if (validarFiltro()) // Si hay que validar, corta la ejecución
                    return;

                string campo = ComboBoxCampo.SelectedItem.ToString();
                string criterio = ComboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltroAvanzado.Text;
                DgvArticulos.DataSource = ArtiManager.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
