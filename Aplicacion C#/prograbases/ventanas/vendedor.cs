using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PrograBases.datos;

namespace PrograBases.ventanas
{
    public partial class vendedor : Form
    {
        public Login loginUsuario;
        public bool estadoBTN = false;
        public string cedulaVendedor;

        public vendedor()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxTipoFactura.SelectedItem.ToString() == "Crédito") {
                CBoxCedulaClente.Enabled = true;
            }
            else
            {
                CBoxCedulaClente.Enabled = false;
            }
        }

        private void vendedor_Load(object sender, EventArgs e)
        {
            BTNabrirVentAdmin.Enabled = estadoBTN;

            cargarCedulaCliente();
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr1 = sisV.cargarCodigoProducto();

            while (dr1.Read())
            {
                CBoxCodigoProductoFactura.Items.Add(dr1["codigo"].ToString());
                ConsultarIDcomboBox.Items.Add(dr1["codigo"].ToString());

            }

            SqlDataReader dr2 = sisV.cargarNumeroFactura();

            while (dr2.Read())
            {
                numFacturaPagoFacturaComboBox.Items.Add(dr2["numFactura"].ToString());
            }
        }

        public void cargarCedulaCliente()
        {
            CBoxCedulaClente.Items.Clear();
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.cargarCedulaCliente();

            while (dr.Read())
            {
                CBoxCedulaClente.Items.Add(dr["cedula"].ToString());
            }

        }

        private void BTNAgregarFactura_Click(object sender, EventArgs e)
        {
            if (((TXTNumFact.Text != "") && (CBoxCedulaClente.Text != "") && (CBoxTipoFactura.Text != "")) || ((CBoxCedulaClente.Enabled == false) && (TXTNumFact.Text != "") && (CBoxTipoFactura.Text != "")))
            {
                agregarFacturaPanel.Enabled = false;
                agregarProductoPanel.Enabled = true;
                BTNAgregarFactura.Enabled = false;
            }
        }

        private void CBoxCodigoProductoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.cargarVistaProductosFactura(int.Parse(CBoxCodigoProductoFactura.SelectedItem.ToString()));
            dr.Read();

            TXTNombreProductoFactura.Text = dr["nombre"].ToString();
            TXTPrecioProductoFactura.Text = dr["precioVenta"].ToString();
            TXTStockProductoFactura.Text = dr["stock"].ToString();

        }

        private void BTNAgregarProductoFactura_Click(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.insertarFacturaProductos(int.Parse(TXTNumFact.Text), CBoxTipoFactura.SelectedItem.ToString(), HoraVendedordateTimePicker.Text, FechaVendedordateTimePicker.Text, 
            CBoxCedulaClente.Text, cedulaVendedor, 0, int.Parse(CBoxCodigoProductoFactura.Text), int.Parse(NumCantidadProductoFactura.Value.ToString()));
            dr.Read();
            
            MessageBox.Show("!!! Se Agrego el producto");

            numFacturaPagoFacturaComboBox.Items.Clear();
            SqlDataReader dr1 = sisV.cargarNumeroFactura();

            while (dr1.Read())
            {
                numFacturaPagoFacturaComboBox.Items.Add(dr1["numFactura"].ToString());
            }
        }

        private void BTNabrirVentAdmin_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();
            admin.vendedor = this;
            admin.Visible = true;
            this.Visible = false;
        }

        private void BTNpagoFactura_Click(object sender, EventArgs e)
        {
            if ((numFacturaPagoFacturaComboBox.Text != "") || (montoPagoFacturaTextBox.Text != ""))
            {
                sisVdatos sisV = new sisVdatos();
                SqlDataReader dr = sisV.realizarPagoFactura(int.Parse(numFacturaPagoFacturaComboBox.SelectedItem.ToString()), int.Parse(montoPagoFacturaTextBox.Text), fechaPagoFacturaDateTimePicker.Text);
                dr.Read();
                MessageBox.Show("!!! Se agregó Correctamente");

                SqlDataReader dr1 = sisV.cargarMontoFactura(int.Parse(numFacturaPagoFacturaComboBox.SelectedItem.ToString()));
                dr1.Read();

                saldoPagoFacturatextBox.Text = dr1["montoCredito"].ToString();
                if (int.Parse(dr1["montoCredito"].ToString()) <= 0)
                {
                    SqlDataReader dr2 = sisV.modificarTipoCliente(dr1["cedulaC"].ToString());
                    dr2.Read();
                }
            }
        }

        private void numFacturaPagoFacturaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.cargarMontoFactura(int.Parse(numFacturaPagoFacturaComboBox.SelectedItem.ToString()));
            dr.Read();

            saldoActualPagoFacturatextBox.Text = dr["montoCredito"].ToString();
        }

        private void BTNagregarCliente_Click(object sender, EventArgs e)
        {
            cliente client = new cliente();
            client.vend = this;
            client.Visible = true;
            this.Visible = false;
        }

//**********************************

        private void ConsultarNombrebutton_Click(object sender, EventArgs e)
        {
            MontrasProductoDatosdataGridView.Rows.Clear();
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.obtenerDatosProductoNombre(ConsultarNombretextBox.Text);

            while (dr.Read())
            {
                MontrasProductoDatosdataGridView.Rows.Add(dr["nombre"].ToString(), dr["precioVenta"].ToString(), dr["marca"].ToString(), dr["stock"].ToString());
            }
        }

        private void ConsultarIDbutton_Click(object sender, EventArgs e)
        {
            MontrasProductoDatosdataGridView.Rows.Clear();
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.obtenerDatosProductoID(int.Parse(ConsultarIDcomboBox.Text));

            while (dr.Read())
            {
                MontrasProductoDatosdataGridView.Rows.Add(dr["nombre"].ToString(), dr["precioVenta"].ToString(), dr["marca"].ToString(), dr["stock"].ToString());
            }
        }

        private void ConsultarPorFamiliabutton_Click(object sender, EventArgs e)
        {

            MontrasProductoDatosdataGridView.Rows.Clear();
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.obtenerDatosProductoFamiliaProducto(MostrarPorFamiliacomboBox.Text);

            while (dr.Read())
            {
                MontrasProductoDatosdataGridView.Rows.Add(dr["nombre"].ToString(), dr["precioVenta"].ToString(), dr["marca"].ToString(), dr["stock"].ToString());
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            loginUsuario.Visible = true;
            this.Close();
        }

        private void BTNfinalizarVentaProducto_Click(object sender, EventArgs e)
        {
            CBoxCodigoProductoFactura.Text = "";
            TXTNombreProductoFactura.Text = "";
            TXTNumFact.Text = "";
            TXTPrecioProductoFactura.Text = "";
            TXTStockProductoFactura.Text = "";
            NumCantidadProductoFactura.Value = 0;
            CBoxCedulaClente.Text = "";
            CBoxTipoFactura.Text = "";
            CBoxCedulaClente.Enabled = false;
            
            agregarProductoPanel.Enabled = false;
            agregarFacturaPanel.Enabled = true;
            BTNAgregarProductoFactura.Enabled = true;
        }
    }
}
