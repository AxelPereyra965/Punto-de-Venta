using Dominio;
using Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App
{
    public partial class FormVenta : Form
    {
        private List<Articulo> ListaArticulos;
        private decimal totalVenta = 0; // mi contador del total
        private ArticuloManager artiManager = new ArticuloManager(); // Instancia de ArticuloManager

        public FormVenta()
        {
            InitializeComponent();
            CargarComboBox();
            ComboBoxBuscar.SelectedIndex = -1; // No seleccionar ningún elemento de inicio
            ComboBoxBuscar.SelectedIndexChanged += ComboBoxBuscar_SelectedIndexChanged;
            this.FormClosing += FormVenta_FormClosing; // Agregar el manejador del evento FormClosing
        }

        private void CargarComboBox()
        {
            ArticuloManager ArtiManager = new ArticuloManager();
            ListaArticulos = ArtiManager.listar();

            if (ListaArticulos != null && ListaArticulos.Count > 0)
            {
                ComboBoxBuscar.DataSource = ListaArticulos; // Asigno la lista de artículos como fuente de datos
                ComboBoxBuscar.DisplayMember = "nombre"; // elijo qué propiedad mostrar
                ComboBoxBuscar.ValueMember = "Id"; // capturo el objeto por su ID
            }
            else
            {
                MessageBox.Show("No se encontraron artículos para cargar en el ComboBox.");
            }
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            ComboBoxBuscar.SelectedIndex = -1; // No seleccionar ningún elemento de inicio
        }

        private void ComboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxBuscar.SelectedIndex != -1)
            {
                Articulo articuloSeleccionado = (Articulo)ComboBoxBuscar.SelectedItem;
                AgregarArticuloAlDataGridView(articuloSeleccionado, 1); // Cantidad predeterminada
            }

            // Limpia la selección del ComboBox
            ComboBoxBuscar.SelectedIndex = -1;
        }

        public void AgregarArticuloAlDataGridView(Articulo articulo, int cantidad)
        {
            // Verificar si el artículo ya está en el DataGridView
            foreach (DataGridViewRow row in DgvVentas.Rows)
            {
                if (!row.IsNewRow && Convert.ToInt32(row.Cells["Id"].Value) == articulo.Id)
                {
                    // Si el artículo ya está, actualizar la cantidad
                    int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    row.Cells["Cantidad"].Value = cantidadActual + cantidad;

                    // Actualizar el totalVenta
                    totalVenta += articulo.Precio * cantidad; // Sumar la nueva cantidad al total

                    // Actualizar el LabelTotal con el nuevo totalVenta sin el símbolo de moneda
                    LabelTotal.Text = totalVenta.ToString(); // Mostrar el total sin formato de moneda

                    // Actualizar el stock en la base de datos
                    artiManager.ReducirStock(articulo.Id, cantidad);

                    return; // Salir del método, ya que no necesitamos agregar una nueva fila
                }
            }

            // Si el artículo no está en el DataGridView, agregar una nueva fila
            if (DgvVentas.Columns.Count == 0)
            {
                DgvVentas.Columns.Add("Id", "ID");
                DgvVentas.Columns.Add("Nombre", "Nombre");
                DgvVentas.Columns.Add("Marca", "Marca"); // Nueva columna para la marca
                DgvVentas.Columns.Add("Precio", "Precio");
                DgvVentas.Columns.Add("Cantidad", "Cantidad"); // Columna adicional para la cantidad
            }

            // Añadir la fila con el artículo seleccionado
            DgvVentas.Rows.Add(articulo.Id, articulo.Nombre, articulo.TipoMarca.Descripcion, articulo.Precio, cantidad);

            // Sumar el precio del artículo al totalVenta
            totalVenta += articulo.Precio * cantidad; // Multiplicamos por cantidad para el total

            // Actualizar el LabelTotal con el nuevo totalVenta sin el símbolo de moneda
            LabelTotal.Text = totalVenta.ToString(); // Mostrar el total sin formato de moneda

            // Reducir el stock en la base de datos
            artiManager.ReducirStock(articulo.Id, cantidad);
        }

        private void BotonQuitar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (DgvVentas.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = DgvVentas.SelectedRows[0];

                // Obtener el precio, cantidad e ID del artículo de la fila seleccionada
                decimal precio = Convert.ToDecimal(filaSeleccionada.Cells["Precio"].Value);
                int cantidad = Convert.ToInt32(filaSeleccionada.Cells["Cantidad"].Value);
                int idArticulo = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                // Restar el total de la fila seleccionada del totalVenta
                totalVenta -= precio * cantidad;

                // Eliminar la fila seleccionada
                DgvVentas.Rows.Remove(filaSeleccionada);

                // Actualizar el LabelTotal con el nuevo totalVenta sin el símbolo de moneda
                LabelTotal.Text = totalVenta.ToString(); // Mostrar el total sin formato de moneda

                // Aumentar el stock en la base de datos
                artiManager.AumentarStock(idArticulo, cantidad);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo para quitar.");
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            // Verificar cada fila del DataGridView y restaurar el stock
            foreach (DataGridViewRow row in DgvVentas.Rows)
            {
                if (!row.IsNewRow)
                {
                    int idArticulo = Convert.ToInt32(row.Cells["Id"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    // Aumentar el stock en la base de datos
                    artiManager.AumentarStock(idArticulo, cantidad);
                }
            }

            // Eliminar todas las filas del DataGridView
            DgvVentas.Rows.Clear();

            // Restablecer el total de la venta a 0
            totalVenta = 0;

            // Actualizar el LabelTotal con el nuevo totalVenta (que será 0)
            LabelTotal.Text = totalVenta.ToString(); // Mostrar el total sin formato de moneda
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBuscar FrBuscar = new FormBuscar(this);
            FrBuscar.ShowDialog(); //traigo el otro formulario al hacer click 
        }

        private void FormVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verificar cada fila del DataGridView y restaurar el stock
            foreach (DataGridViewRow row in DgvVentas.Rows)
            {
                if (!row.IsNewRow)
                {
                    int idArticulo = Convert.ToInt32(row.Cells["Id"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    // Aumentar el stock en la base de datos
                    artiManager.AumentarStock(idArticulo, cantidad);
                }
            }
        }

        private void BotonCobrar_Click(object sender, EventArgs e)
        {
            List<Articulo> articulosEnVenta = new List<Articulo>();

            foreach (DataGridViewRow row in DgvVentas.Rows)
            {
                if (!row.IsNewRow)
                {
                    int idArticulo = Convert.ToInt32(row.Cells["Id"].Value);
                    Articulo articulo = ListaArticulos.First(a => a.Id == idArticulo);
                    articulosEnVenta.Add(articulo);
                }
            }

            FormCobrar FrCobrar = new FormCobrar(totalVenta, articulosEnVenta, this);
            FrCobrar.ShowDialog(); // Trae el otro formulario al hacer clic 
        }


        public void VaciarDataGridView()
        {
            // Eliminar todas las filas del DataGridView
            DgvVentas.Rows.Clear();

            // Restablecer el total de la venta a 0
            totalVenta = 0;

            // Actualizar el LabelTotal con el nuevo totalVenta (que será 0)
            LabelTotal.Text = totalVenta.ToString(); // Mostrar el total sin formato de moneda
        }

    }
}















