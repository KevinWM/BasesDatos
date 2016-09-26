using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrograBases.datos;
using System.Data.SqlClient;

namespace PrograBases.ventanas
{
    public partial class Administrador : Form
    {
        public Form vendedor;

        public Administrador()
        {
            InitializeComponent();
        }

        private void cedulaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.mostrarInfoCedulaPersonal(cedulaModificarComboBox.SelectedItem.ToString());
            dr.Read();

            cedulaModificarComboBox.Text = dr["cedula"].ToString();
            nombreModificarTextBox.Text = dr["nombre"].ToString();
            apellido1ModificarTextBox.Text = dr["apellido1"].ToString();
            apellido2ModificarTextBox.Text = dr["apellido2"].ToString();
            nombreUsuarioModificarTextBox.Text = dr["NombreUsuario"].ToString();
            contraseñaModificarTextBox.Text = dr["contraseña"].ToString();
            tipoVendedorModificarTextBox.Text = dr["tipoVendedor"].ToString();
            sexoModificarTextBox.Text = dr["sexo"].ToString();
            idDistritoModificarTextBox.Text = dr["idDistrito"].ToString();
            otrasSeñasModificarTextBox.Text = dr["otrasSeñas"].ToString();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            cargarCedulaComboBox();
            cargarIdDistritoComboBox();
            cargarIdProveedorComboBox();
            cargarCodigoProductoComboBox();
            cargarTablaInventario();
            cargarTablaDeudores();
        }

/*
 * ***********  Metodos cargar datos en ComboBox y otros  **********************
 */

        public void cargarCedulaComboBox()
        {
            cedulaAgregarCorreoComboBox1.Items.Clear();
            cedulaEliminarComboBox.Items.Clear();
            cedulaModificarComboBox.Items.Clear();
            CedulaVendedorVentascomboBox.Items.Clear();

            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.cargarCedulaPersonal();

            while (dr.Read())
            {
                cedulaAgregarCorreoComboBox1.Items.Add(dr["cedula"].ToString());
                cedulaEliminarComboBox.Items.Add(dr["cedula"].ToString());
                cedulaModificarComboBox.Items.Add(dr["cedula"].ToString());
                CedulaVendedorVentascomboBox.Items.Add(dr["cedula"].ToString());
            }
        }

        public void cargarIdDistritoComboBox()
        {
            idDistritoAgregarComboBox.Items.Clear();
            idDistritoProveedorAgregarComboBox.Items.Clear();
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.cargarIdDistrito();

            while (dr.Read())
            {
                idDistritoAgregarComboBox.Items.Add(dr["idDistrito"].ToString());
                idDistritoProveedorAgregarComboBox.Items.Add(dr["idDistrito"].ToString());
            }
        }

        public void cargarCodigoProductoComboBox()
        {
            CodigoModificarProductoComboBox.Items.Clear();
            codigoEliminarProductocomboBox.Items.Clear();
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.cargarCodigoProducto();
            while (dr.Read())
            {
                CodigoModificarProductoComboBox.Items.Add(dr["codigo"].ToString());
                codigoEliminarProductocomboBox.Items.Add(dr["codigo"].ToString());
                codigoProductoAgregarStockComboBox.Items.Add(dr["codigo"].ToString());
            }
        }

        public void cargarIdProveedorComboBox()
        {
            idProveedorAgregarTel_EmaComboBox.Items.Clear();
            idProveedorModificarProveedorcomboBox.Items.Clear();
            idProveedorModificarCorTelcomboBox.Items.Clear();
            idProveedorEliminarProveedorcomboBox.Items.Clear();
            idProveedorAgregarProductoComboBox.Items.Clear();
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.cargarIdProveedores();

            while (dr.Read())
            {
                idProveedorAgregarTel_EmaComboBox.Items.Add(dr["idProveedor"].ToString());
                idProveedorModificarProveedorcomboBox.Items.Add(dr["idProveedor"].ToString());
                idProveedorModificarCorTelcomboBox.Items.Add(dr["idProveedor"].ToString());
                idProveedorEliminarProveedorcomboBox.Items.Add(dr["idProveedor"].ToString());
                idProveedorAgregarProductoComboBox.Items.Add(dr["idProveedor"].ToString());
            }
        }

        public void cargarTablaInventario()
        {
            inventarioDataGridView.Rows.Clear();
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.cargarVISstock();

            while (dr.Read())
            {
                inventarioDataGridView.Rows.Add(dr["codigo"].ToString(), dr["nombreEmpresa"].ToString(),
                    dr["nombre"].ToString(), dr["marca"].ToString(), dr["categoria"].ToString(),
                    dr["precioVenta"].ToString(), dr["stock"].ToString(), dr["Ganancia total"].ToString());
            }
        }

        public void cargarTablaDeudores()
        {
            vistaDeudoresdataGridView.Rows.Clear();
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.cargarVISDeudores();

            while (dr.Read())
            {
                vistaDeudoresdataGridView.Rows.Add(dr["numFactura"].ToString(), dr["Tipo_Fac"].ToString(),
                     dr["fecha"].ToString(), dr["hora"].ToString(), dr["cedulaC"].ToString(),
                    dr["Nombre cliente"].ToString(), dr["Monto total"].ToString(), dr["Monto por pagar"].ToString(),
                    dr["Cantidad de productos"].ToString());
            }
        }

/*
 ********************  Otros ******************************
 */

        private void BTNmodificar_Click(object sender, EventArgs e)
        {
            int idDistrito = int.Parse(idDistritoModificarTextBox.Text);
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.modificarPersonal(cedulaModificarComboBox.SelectedItem.ToString(), nombreModificarTextBox.Text, apellido1ModificarTextBox.Text, apellido2ModificarTextBox.Text, sexoModificarTextBox.Text
            , idDistrito, otrasSeñasModificarTextBox.Text, nombreUsuarioModificarTextBox.Text, contraseñaModificarTextBox.Text, tipoVendedorModificarTextBox.Text);
            MessageBox.Show(tabPage6,"!!! Se Modifico Correctamente");
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {   
            int idDistrito = int.Parse(idDistritoAgregarComboBox.SelectedItem.ToString());
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.agregarPersonal(cedulaAgregarTextBox.Text, nombreAgregarTextBox.Text, apellido2AgregarTextBox1.Text, apellido2AgregarTextBox1.Text
            , sexoAgregarComboBox.SelectedItem.ToString(), idDistrito, otrasSeñasAgregarTextBox1.Text, nombreUsuarioAgregarTextBox1.Text, contraseñaAgregarTextBox1.Text
            , tipoVendedorAgregarComboBox.SelectedItem.ToString());
            MessageBox.Show(tabPage6, "!!! Se Agrego Correctamente");
            cedulaAgregarTextBox.Text = "";
            nombreAgregarTextBox.Text = "";
            apellido1AgregarTextBox1.Text = "";
            apellido2AgregarTextBox1.Text = "";
            nombreUsuarioAgregarTextBox1.Text = "";
            contraseñaAgregarTextBox1.Text = "";
            tipoVendedorAgregarComboBox.Text = "";
            sexoAgregarComboBox.Text = "";
            idDistritoAgregarComboBox.Text = "";
            otrasSeñasAgregarTextBox1.Text = "";

            cargarCedulaComboBox();
        }

        private void BTNagregarEmsTeles_Click(object sender, EventArgs e)
        {
            if (cedulaAgregarTextBox.Enabled == true)
            {
                inserccionPersonal.Enabled = false;

                insercionTel_Ema_Personal.Enabled = true;
            }
            else if (cedulaAgregarCorreoComboBox1.Enabled == true)
            {
                inserccionPersonal.Enabled = true;
               
                insercionTel_Ema_Personal.Enabled = false;
            }
        }

        private void BTNagregarEmTel_Click(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            if ((correoAgregarTextBox.Text == "") && (telefonoAgregarTextBox.Text == ""))
            {
                return;
            }
            else if ((correoAgregarTextBox.Text == "") && (telefonoAgregarTextBox.Text != ""))
            {
                SqlDataReader dr = sisV.agregarTelefonoPersonal(cedulaAgregarCorreoComboBox1.SelectedItem.ToString(), telefonoAgregarTextBox.Text);
                MessageBox.Show(tabPage6, "!!! Se Agrego Correctamente el Telefono");
                telefonoAgregarTextBox.Text = "";
            }
            else if ((correoAgregarTextBox.Text != "") && (telefonoAgregarTextBox.Text == ""))
            {
                SqlDataReader dr = sisV.agregarCorreoPersonal(cedulaAgregarCorreoComboBox1.SelectedItem.ToString(), correoAgregarTextBox.Text);
                MessageBox.Show(tabPage6, "!!! Se Agrego Correctamente el Correo");
                correoAgregarTextBox.Text = "";
            }
            else
            {
                SqlDataReader dr = sisV.agregarTelefonoPersonal(cedulaAgregarCorreoComboBox1.SelectedItem.ToString(), telefonoAgregarTextBox.Text);
                SqlDataReader dr1 = sisV.agregarCorreoPersonal(cedulaAgregarCorreoComboBox1.SelectedItem.ToString(), correoAgregarTextBox.Text);
                MessageBox.Show(tabPage6, "!!! Se Agregraron Correctamente");
                telefonoAgregarTextBox.Text = "";
                correoAgregarTextBox.Text = "";
            }
        }

        private void BTNmodificarEms_Tels_Click(object sender, EventArgs e)
        {
            if (cedulaModificarComboBox.Enabled == true)
            { 
                modificarPersonal.Enabled = false;

                modificarTel_Ema_Personal.Enabled = true;
            }
            else if (cedulaCorreoModificarcomboBox.Enabled == true)
            {
                modificarPersonal.Enabled = true;

                modificarTel_Ema_Personal.Enabled = false;
            }
        }

        private void BTNmodificarTel_Ema_Click(object sender, EventArgs e)
        {
            if ((correoModificarcomboBox.Text == "") && (telefonoModificarcomboBox.Text != "") && (telefonoNuevoModificartextBox.Text != ""))
            {
                sisVdatos sisV = new sisVdatos();
                SqlDataReader dr = sisV.modificarTelefonoPersonal(cedulaCorreoModificarcomboBox.Text, telefonoModificarcomboBox.Text, telefonoNuevoModificartextBox.Text);
                MessageBox.Show(tabPage6, "!!! Se Modificó Correctamente el Telefono");
            }
            else if ((correoModificarcomboBox.Text != "") && (telefonoModificarcomboBox.Text == "") && (correoNuevoModificartextBox.Text != ""))
            {
                sisVdatos sisV = new sisVdatos();
                SqlDataReader dr = sisV.modificarCorreoPersonal(cedulaCorreoModificarcomboBox.Text, correoModificarcomboBox.Text, correoNuevoModificartextBox.Text);
                MessageBox.Show(tabPage6, "!!! Se Modificó Correctamente el Correo");
            }
            else if ((correoModificarcomboBox.Text != "") && (telefonoModificarcomboBox.Text != "") && (correoNuevoModificartextBox.Text != "") && (telefonoNuevoModificartextBox.Text != ""))
            {
                sisVdatos sisV = new sisVdatos();
                SqlDataReader dr = sisV.modificarTelefonoPersonal(cedulaCorreoModificarcomboBox.Text, telefonoModificarcomboBox.Text, telefonoNuevoModificartextBox.Text);
                SqlDataReader dr1 = sisV.modificarCorreoPersonal(cedulaCorreoModificarcomboBox.Text, correoModificarcomboBox.Text, correoNuevoModificartextBox.Text);
                MessageBox.Show(tabPage6, "!!! Se Modificaron Correctamente");
            }
            else
            {
                return;
            }
        }

        private void cedulaCorreoModificarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            correoModificarcomboBox.Items.Clear();
            telefonoModificarcomboBox.Items.Clear();
            correoModificarcomboBox.Text = "";
            telefonoModificarcomboBox.Text = "";
            correoNuevoModificartextBox.Text = "";
            telefonoNuevoModificartextBox.Text = "";

            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.cargarCorreosPersonas(cedulaCorreoModificarcomboBox.SelectedItem.ToString());

            while (dr.Read())
            {
                correoModificarcomboBox.Items.Add(dr["correo"].ToString());
            }

            SqlDataReader dr1 = sisV.cargarTelefonosPersonas(cedulaCorreoModificarcomboBox.SelectedItem.ToString());

            while (dr1.Read())
            {
                telefonoModificarcomboBox.Items.Add(dr1["telefono"].ToString());
            }
        }

        private void eliminarBoton_Click(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.eliminarVendedor(cedulaEliminarComboBox.SelectedItem.ToString());
            MessageBox.Show(tabPage6, "!!! Se Elimino Correctamente");

            cedulaEliminarComboBox.Text = "";
            nombreEliminarTextBox1.Text = "";
            nombre_UsuarioEliminarTextBox.Text = "";

            cargarCedulaComboBox();
        }

        private void cedulaEliminarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.buscarCedulaVISTEliminar(cedulaEliminarComboBox.SelectedItem.ToString());
            dr.Read();

            cedulaEliminarComboBox.Text = dr["Numerocedula"].ToString();
            nombreEliminarTextBox1.Text = dr["Nombre"].ToString();
            nombre_UsuarioEliminarTextBox.Text = dr["NombreUsuario"].ToString();
        }

        private void BTNagregarProveedor_Click(object sender, EventArgs e)
        {
            int idProveedor = int.Parse(idProveedorAgregarTextBox.Text);
            int idDistrito = int.Parse(idDistritoProveedorAgregarComboBox.SelectedItem.ToString());

            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.insertarProveedor(idProveedor, nombreEmpresaAgregarTextBox.Text, descripcionProveedorAgregarTextBox.Text, idDistrito, otrasSeñasProveedorAgregarTextBox.Text);
            MessageBox.Show(tabPage10, "!!! Se Agregó Correctamente");

            idProveedorAgregarTextBox.Text = "";
            nombreEmpresaAgregarTextBox.Text = "";
            descripcionProveedorAgregarTextBox.Text = "";
            idDistritoProveedorAgregarComboBox.Text = "";
            otrasSeñasProveedorAgregarTextBox.Text = "";

            cargarIdProveedorComboBox();
        }

        private void BTNagregarTels_Emas_Proveedores_Click(object sender, EventArgs e)
        {
            if (idProveedorAgregarTextBox.Enabled == true)
            {
                insercionProveedor.Enabled = false;
                inserccionTel_Em_Proveedor.Enabled = true;
            }
            else if (idProveedorAgregarTel_EmaComboBox.Enabled == true)
            {
                insercionProveedor.Enabled = true;
                inserccionTel_Em_Proveedor.Enabled = false;
            }
        }

        // Modificar copy paste
        private void BTNagregarTel_Ema_Proveedor_Click(object sender, EventArgs e)
        {
            int idProveedor = int.Parse(idProveedorAgregarTel_EmaComboBox.SelectedItem.ToString());
            sisVdatos sisV = new sisVdatos();
            if ((correoProveedorAgregarTextBox.Text == "") && (telefonoProveedorAgregarTextBox.Text == ""))
            {
                return;
            }
            else if ((correoProveedorAgregarTextBox.Text == "") && (telefonoProveedorAgregarTextBox.Text != ""))
            {
                SqlDataReader dr = sisV.agregarTelefonoProveedor(idProveedor, telefonoProveedorAgregarTextBox.Text);
                MessageBox.Show(tabPage10, "!!! Se Agrego Correctamente el Telefono");
                telefonoProveedorAgregarTextBox.Text = "";
            }
            else if ((correoProveedorAgregarTextBox.Text != "") && (telefonoProveedorAgregarTextBox.Text == ""))
            {
                SqlDataReader dr = sisV.agregarCorreoProveedor(idProveedor, correoProveedorAgregarTextBox.Text);
                MessageBox.Show(tabPage10, "!!! Se Agrego Correctamente el Correo");
                correoProveedorAgregarTextBox.Text = "";
            }
            else
            {
                SqlDataReader dr = sisV.agregarTelefonoProveedor(idProveedor, telefonoProveedorAgregarTextBox.Text);
                SqlDataReader dr1 = sisV.agregarCorreoProveedor(idProveedor, correoProveedorAgregarTextBox.Text);
                MessageBox.Show(tabPage10, "!!! Se Agregraron Correctamente");
                telefonoProveedorAgregarTextBox.Text = "";
                correoProveedorAgregarTextBox.Text = "";
            }
        }

        private void idProveedorModificarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            telefonoModificarProveedorcomboBox.Items.Clear();
            correosModificarProveedorComboBox.Items.Clear();
            telefonoModificarProveedorcomboBox.Text = "";
            correosModificarProveedorComboBox.Text = "";
            correoNuevoModificarProveedortextBox.Text = "";
            telefonoNuevoModificarProveedortextBox.Text = "";

            int idProveedor = int.Parse(idProveedorModificarCorTelcomboBox.SelectedItem.ToString());
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.cargarTelefonosProveedor(idProveedor);

            while (dr.Read())
            {
                telefonoModificarProveedorcomboBox.Items.Add(dr["telefono"].ToString());
            }


            SqlDataReader dr1 = sisV.cargarCorreosProveedor(idProveedor);

            while (dr1.Read())
            {
                correosModificarProveedorComboBox.Items.Add(dr1["correo"].ToString());
            }
        }

        private void BTNmodificarTels_Emas_Proveedores_Click(object sender, EventArgs e)
        {
            if (idProveedorModificarProveedorcomboBox.Enabled == true)
            {
                modificarProveedor.Enabled = false;

                modificacionTel_Ema_Proveedor.Enabled = true;
            }
            else if (idProveedorModificarCorTelcomboBox.Enabled == true)
            {
                modificarProveedor.Enabled = true;

                modificacionTel_Ema_Proveedor.Enabled = false;
            }
        }

        private void BTNmodicarProveedor_Click(object sender, EventArgs e)
        {
            int idProveedor = int.Parse(idProveedorModificarProveedorcomboBox.Text);
            int idDistrito = int.Parse(idDistritoModicarProveedortextBox.Text);

            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.modificarProveedor(idProveedor, nombreEmpresaModificarProveedortextBox.Text, descripcionModificarProveedortextBox.Text, idDistrito, otrasSeñasModificarProveedortextBox.Text);
            MessageBox.Show(tabPage11, "!!! Se Modificó Correctamente");

            cargarTablaInventario();
        }

        private void idProveedorModificarProveedorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProveedor = int.Parse(idProveedorModificarProveedorcomboBox.SelectedItem.ToString());
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.mostrarInfoIdProveedor(idProveedor);
            dr.Read();

            idProveedorModificarProveedorcomboBox.Text = dr["idProveedor"].ToString();
            nombreEmpresaModificarProveedortextBox.Text = dr["nombreEmpresa"].ToString();
            descripcionModificarProveedortextBox.Text = dr["descripcion"].ToString();
            idDistritoModicarProveedortextBox.Text = dr["idDistrito"].ToString();
            otrasSeñasModificarProveedortextBox.Text = dr["otrasSeñas"].ToString();
        }

        private void BTNmodificarTel_EmaProveedor_Click(object sender, EventArgs e)
        {
            int idProveedor = int.Parse(idProveedorModificarCorTelcomboBox.SelectedItem.ToString());
            sisVdatos sisV = new sisVdatos();

            if ((correosModificarProveedorComboBox.Text == "") && (telefonoModificarProveedorcomboBox.Text != "") && (telefonoNuevoModificarProveedortextBox.Text != ""))
            {
                SqlDataReader dr = sisV.modificarTelefonoProveedor(idProveedor, telefonoModificarProveedorcomboBox.Text, telefonoNuevoModificarProveedortextBox.Text);
                MessageBox.Show(tabPage11, "!!! Se Modificó Correctamente el Telefono");
            }
            else if ((correosModificarProveedorComboBox.Text != "") && (telefonoModificarProveedorcomboBox.Text == "") && (correoNuevoModificarProveedortextBox.Text != ""))
            {
                SqlDataReader dr = sisV.modificarCorreoProveedor(idProveedor, correosModificarProveedorComboBox.Text, correoNuevoModificarProveedortextBox.Text);
                MessageBox.Show(tabPage11, "!!! Se Modificó Correctamente el Correo");
            }
            else if ((correosModificarProveedorComboBox.Text != "") && (telefonoModificarProveedorcomboBox.Text != "") && (correoNuevoModificarProveedortextBox.Text != "") && (telefonoNuevoModificarProveedortextBox.Text != ""))
            {
                SqlDataReader dr = sisV.modificarTelefonoProveedor(idProveedor, telefonoModificarProveedorcomboBox.Text, telefonoNuevoModificarProveedortextBox.Text);
                SqlDataReader dr1 = sisV.modificarCorreoProveedor(idProveedor, correosModificarProveedorComboBox.Text, correoNuevoModificarProveedortextBox.Text);
                MessageBox.Show(tabPage11, "!!! Se Modificaron Correctamente");
            }
            else
            {
                return;
            }
            correoNuevoModificarProveedortextBox.Text = "";
            telefonoNuevoModificarProveedortextBox.Text = "";
            correosModificarProveedorComboBox.Text = "";
            telefonoModificarProveedorcomboBox.Text = "";
            idProveedorModificarCorTelcomboBox.Text = "";
        }

        private void BTNeliminarTel_Ema_Proveedor_Click(object sender, EventArgs e)
        {
            int idProveedor = int.Parse(idProveedorModificarCorTelcomboBox.SelectedItem.ToString());
            sisVdatos sisV = new sisVdatos();

            if ((correosModificarProveedorComboBox.Text == "") && (telefonoModificarProveedorcomboBox.Text == ""))
            {
                return;
            }
            else if ((correosModificarProveedorComboBox.Text == "") && (telefonoModificarProveedorcomboBox.Text != ""))
            {
                SqlDataReader dr = sisV.eliminarTelefonoProveedor(idProveedor, telefonoModificarProveedorcomboBox.Text);
                MessageBox.Show(tabPage11, "!!! Se Eliminó Correctamente el Telefono");
                telefonoModificarProveedorcomboBox.Text = "";
            }
            else if ((correosModificarProveedorComboBox.Text != "") && (telefonoModificarProveedorcomboBox.Text == ""))
            {
                SqlDataReader dr = sisV.eliminarCorreoProveedor(idProveedor, correosModificarProveedorComboBox.Text);
                MessageBox.Show(tabPage11, "!!! Se Eliminó Correctamente el Correo");
                correosModificarProveedorComboBox.Text = "";
            }
            else
            {
                SqlDataReader dr = sisV.eliminarTelefonoProveedor(idProveedor, telefonoModificarProveedorcomboBox.Text);
                SqlDataReader dr1 = sisV.eliminarCorreoProveedor(idProveedor, correosModificarProveedorComboBox.Text);
                MessageBox.Show(tabPage11, "!!! Se Eliminarón Correctamente");
                telefonoModificarProveedorcomboBox.Text = "";
                correosModificarProveedorComboBox.Text = "";
            }
        }

        private void idProveedorEliminarProveedorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProveedor = int.Parse(idProveedorEliminarProveedorcomboBox.SelectedItem.ToString());
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.mostrarInfoIdProveedor(idProveedor);
            dr.Read();

            nombreEmpresaEliminarProveedortextBox.Text = dr["nombreEmpresa"].ToString();
        }

        private void BTNeliminarProveedor_Click(object sender, EventArgs e)
        {
            int idProveedor = int.Parse(idProveedorEliminarProveedorcomboBox.SelectedItem.ToString());
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.eliminarProveedor(idProveedor);
            dr.Read();
            MessageBox.Show(tabPage12, "!!! Se Eliminó Correctamente");
            
            idProveedorEliminarProveedorcomboBox.Text = "";
            nombreEmpresaEliminarProveedortextBox.Text = "";

            cargarIdProveedorComboBox();
            cargarTablaInventario();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            sisV.modificarProducto(int.Parse(CodigoModificarProductoComboBox.SelectedItem.ToString()), ImpuestoModificarProductoComboBox.SelectedItem.ToString(), categoriaModificarProductotextBox.Text, NombreModificarProductoPtextBox.Text
            , MarcaModificarProductotextBox.Text, int.Parse(precioModificarProductotextBox.Text), int.Parse(stockModificarProductotextBox.Text), FamiliaModificarProductocomboBox.SelectedItem.ToString());
            MessageBox.Show(tabPage8, "!!! Se Modifico Correctamente");

            cargarTablaInventario();
        }

        private void CodigoModificarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.obtenerDatosProducto(int.Parse(CodigoModificarProductoComboBox.SelectedItem.ToString()));
            dr.Read();

            CodigoModificarProductoComboBox.Text = dr["codigo"].ToString();
            NombreModificarProductoPtextBox.Text = dr["nombre"].ToString();
            ImpuestoModificarProductoComboBox.Text = dr["tipoImpuesto"].ToString();
            categoriaModificarProductotextBox.Text = dr["categoria"].ToString();
            MarcaModificarProductotextBox.Text = dr["marca"].ToString();
            precioModificarProductotextBox.Text = dr["precioVenta"].ToString();
            stockModificarProductotextBox.Text = dr["stock"].ToString();
            FamiliaModificarProductocomboBox.Text = dr["familiaProductos"].ToString();
        }

        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.eliminarProducto(int.Parse(codigoEliminarProductocomboBox.SelectedItem.ToString()));
            MessageBox.Show(tabPage6, "!!! Se Elimino Correctamente");

            codigoEliminarProductocomboBox.Text = "";
            nombreEliminarProductotextBox.Text = "";
            cargarCodigoProductoComboBox();
            cargarTablaInventario();
        }

        private void codigoProductosEcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.obtenerDatosProducto(int.Parse(codigoEliminarProductocomboBox.SelectedItem.ToString()));
            dr.Read();

            codigoEliminarProductocomboBox.Text = dr["codigo"].ToString();
            nombreEliminarProductotextBox.Text = dr["nombre"].ToString();
        }

        private void BTNAgregarProducto(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.agregarProducto(int.Parse(codigoAgregarProductoTextBox.Text), tipoImpuestoAgregarProductoComboBox.SelectedItem.ToString(), categoriaAgregarProductoTextBox.Text, nombreAgregarProductoTextBox.Text
            , marcaAgregarProductoTextBox.Text, int.Parse(precioVentaAgregarProductoTextBox.Text), int.Parse(stockAgregarProductoTextBox.Text), familiaProductosAgregarProductoComboBox.Text
            , int.Parse(idProveedorAgregarProductoComboBox.SelectedItem.ToString()));
            MessageBox.Show(tabPage7, "!!! Se Agrego Correctamente");

            cargarIdProveedorComboBox();
            cargarCodigoProductoComboBox();
            cargarTablaInventario();
        }

        private void BTNregresarVendedor_Click(object sender, EventArgs e)
        {
            vendedor.Visible = true;
            this.Visible = false;
        }

/*
 **********************************************************************************************
 */

        private void ConsultarVentasbutton_Click(object sender, EventArgs e)
        {
            MostrarVistadataGridView.Rows.Clear();
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.mostrarProductosFormaPago(fechaPagoPorformadateTimePicker.Text, formaPagoVentascomboBox.Text);

            while (dr.Read())
            {
                MostrarVistadataGridView.Rows.Add(dr["nombre"].ToString(), dr["codigo"].ToString(), dr["marca"].ToString(), dr["cantidad"].ToString(), dr["fecha"].ToString(), dr["stock"].ToString());
            }
        }

        private void CedulaVendedorVentascomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.mostrarInfoCedulaPersonal(CedulaVendedorVentascomboBox.SelectedItem.ToString());
            dr.Read();

            NombreVendedorVentastextBox.Text = (dr["nombre"].ToString() + " " + (dr["apellido1"].ToString()) + " " + (dr["apellido2"]));
        }

        private void consultarPorVendedorbutton_Click(object sender, EventArgs e)
        {
            mostrarVentasVendedordataGridView.Rows.Clear();
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.mostrarVentasPorVendedor(SeleccionarFechaPorvendedordateTimePicker1.Text, CedulaVendedorVentascomboBox.Text);

            while (dr.Read())
            {
                mostrarVentasVendedordataGridView.Rows.Add(dr["Nombre completo"].ToString(), dr["nombre"].ToString(), dr["codigo"].ToString(), dr["cantidad"].ToString(), dr["fecha"], dr["stock"].ToString(), dr["marca"].ToString());
            }
        }

        private void FamiliaPructosbutton_Click(object sender, EventArgs e)
        {
            mostrarProductosFamiliaProductodataGridView1.Rows.Clear();
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.mostrarVentasPorFamiliaProducto(FechaFamiliaProductosdateTimePicker.Text, FamiliaProductoscomboBox.Text);

            while (dr.Read())
            {
                mostrarProductosFamiliaProductodataGridView1.Rows.Add(dr["nombre"].ToString(), dr["codigo"].ToString(), dr["stock"].ToString(), dr["cantidad"].ToString(), dr["fecha"].ToString());
            }
        }

        private void BTNagregarStock_Click(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.agregarProductosStock(int.Parse(codigoProductoAgregarStockComboBox.SelectedItem.ToString()), int.Parse(cantidadProductoAgregarStocknumericUpDown.Value.ToString()));

            cargarTablaInventario();
        }
    }
}
