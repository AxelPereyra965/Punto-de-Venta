using Dominio;
using Manager;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace App
{
    public partial class FormCobrar : Form
    {
        private Venta _Venta = null;
        private ArticulosVentas _ArtiVenta = null;
        private decimal totalVenta;
        private bool isChecked = false;
        private IFormatProvider culture;
        private List<Articulo> _ListaArticulos; // Lista de artículos a cobrar
        private FormVenta _formVenta; // Añadir esta línea para almacenar la referencia

        public FormCobrar(decimal totalVenta, List<Articulo> listaArticulos, FormVenta formVenta)
        {
            InitializeComponent();
            this.totalVenta = totalVenta;
            this._ListaArticulos = listaArticulos;
            this._formVenta = formVenta; // Asignar la referencia del FormVenta
            InicializarDataGridView();
        }

        private void FormCobrar_Load(object sender, EventArgs e)
        {
            ComboBoxPago.Items.Add("Efectivo");
            ComboBoxPago.Items.Add("Transferencia");
            ComboBoxPago.SelectedIndex = 0;
            labelNum.Text = totalVenta.ToString("C2");
            ComboBoxPago.SelectedIndexChanged += ComboBoxPago_SelectedIndexChanged;
        }

        private void InicializarDataGridView()
        {
            dataGridViewCobrar.Columns.Add("MedioPago", "Medio de Pago");
            dataGridViewCobrar.Columns.Add("Total", "Total");
            dataGridViewCobrar.Columns.Add("Importe", "Importe");
            dataGridViewCobrar.Columns.Add("Vuelto", "Vuelto");
        }

        private void ComboBoxPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPago.SelectedItem.ToString() == "Transferencia")
            {
                textImporte.Enabled = false;
                textImporte.Text = totalVenta.ToString("C2");
            }
            else
            {
                textImporte.Enabled = true;
                textImporte.Text = string.Empty;
            }
        }

        private void BotonCheck_Click(object sender, EventArgs e)
        {
            if (isChecked) return;

            labelSinImporte.Text = "";
            labelSinPago.Text = "";
            labelSinImporte.ForeColor = System.Drawing.Color.Red;
            labelSinPago.ForeColor = System.Drawing.Color.Red;

            if (ComboBoxPago.SelectedIndex == -1)
            {
                labelSinImporte.Text = "*Por favor seleccione un método de pago";
                return;
            }

            if (ComboBoxPago.SelectedItem.ToString() != "Transferencia" && (string.IsNullOrEmpty(textImporte.Text) || !decimal.TryParse(textImporte.Text, out decimal importe)))
            {
                labelSinImporte.Text = "*Por favor ingrese un monto";
                return;
            }

            if (ComboBoxPago.SelectedItem.ToString() == "Transferencia")
            {
                importe = totalVenta;
                labelSinPago.Text = "(verifique la acreditación de la transferencia)";
            }
            else
            {
                importe = decimal.Parse(textImporte.Text);
            }

            decimal vuelto = importe - totalVenta;

            dataGridViewCobrar.Rows.Add(ComboBoxPago.SelectedItem.ToString(), totalVenta.ToString("C2"), importe.ToString("C2"), vuelto.ToString("C2"));

            isChecked = true;
            BotonCheck.Enabled = false;
            textImporte.Enabled = false;
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            VentaManager VeantManager = new VentaManager();
            _Venta = new Venta();
            ArticulosVentasManager ArtiVentaManager = new ArticulosVentasManager();
            _ArtiVenta = new ArticulosVentas();
            //cargo el objeto de venta
            _Venta.FechaVenta = DateTime.Now;
            _Venta.Total = Convert.ToInt32(totalVenta);
            VeantManager.Agregar(_Venta);//lo inserto en la DB

            _Venta.Id = VeantManager.ObtenerUltimoID();//luego le cargo al objeto el id autogenerado en la DB

            foreach (var articulo in _ListaArticulos) //recorro solo los articulos que estan en el DataGridView
            {
                _ArtiVenta.IdVenta = _Venta.Id;
                _ArtiVenta.IdArticulo = articulo.Id;
                ArtiVentaManager.AgregarArticuloVenta(_ArtiVenta);
            }

            // Vaciar el DataGridView del FormVenta
            _formVenta.VaciarDataGridView();

            MessageBox.Show("Venta registrada con éxito.");
            this.Close();
        }

    }
}













