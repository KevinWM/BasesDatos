using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrograBases.datos
{
    class sisVdatos
    {
        /// <summary>
        /// Contiene los parametros de conexion para la base de datos Sistema de Ventas
        /// </summary>
        private string strconn = "Data Source=KEVIN-PC;Initial Catalog=sisV;Persist Security Info=True;User ID=SA;Password=12345";
        //private string strconn = "Data Source = (localdb)\\Projects; Initial Catalog=sisV;Integrated Security=True";

        /// <summary>
        /// Busca por cedulas en la tabla personas
        /// </summary>
        /// <returns></returns>
        public SqlDataReader cargarCedulaPersonal()
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = "select cedula from vendedor";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader cargarlogin()
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = "select * from vendedor";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader cargarIdDistrito()
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = "select idDistrito from distrito";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader mostrarInfoCedulaPersonal(string cedula)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC VISVendedores '{0}'", cedula);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader mostrarInfoIdProveedor(int idProveedor)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("Select * from Proveedor where idProveedor = '{0}'", idProveedor);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }


        public SqlDataReader modificarPersonal(string cedula, string nombre, string apellido1, string apellido2, string sexo, int idDistrito, string otrasSeñas, string nombreUsuario, string contraseñar, string tipoVendedor)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC UPDvendedor '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}'", cedula, nombre, apellido1, apellido2, sexo, idDistrito, otrasSeñas, nombreUsuario, contraseñar, tipoVendedor);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader agregarPersonal(string cedula, string nombre, string apellido1, string apellido2, string sexo, int idDistrito, string otrasSeñas, string nombreUsuario, string contraseñar, string tipoVendedor)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC INSvendedor '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}'", cedula, nombre, apellido1, apellido2, sexo, idDistrito, otrasSeñas, nombreUsuario, contraseñar, tipoVendedor);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader agregarCorreoPersonal(string cedula, string correo)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC INScorreoPersona '{0}', '{1}'", cedula, correo);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader agregarTelefonoPersonal(string cedula, string telefono)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC INStelPersona '{0}', '{1}'", cedula, telefono);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader modificarCorreoPersonal(string cedula, string correo, string correoNuevo)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC UPDcorreosPersona '{0}', '{1}', '{2}'", cedula, correo, correoNuevo);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader modificarTelefonoPersonal(string cedula, string telefono, string telefonoNuevo)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC UPDTelefonoPersona '{0}', '{1}', '{2}'", cedula, telefono, telefonoNuevo);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }        

        public SqlDataReader cargarCorreosPersonas(string cedula)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("select correo from CorreosPersona where cedula = '{0}'", cedula);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader cargarTelefonosPersonas(string cedula)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("select telefono from TelefonoPersona where cedula = '{0}'", cedula);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Busca los vendedores usando una cedula
        /// </summary>
        /// <param name="cedula">Cedula del vendedor</param>
        /// <returns></returns>
        public SqlDataReader buscarCedulaVISTEliminar(string cedula)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC VISEliminarVendedor '{0}'", cedula);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Elimana un vendedor usando una cedula
        /// </summary>
        /// <param name="cedula">Cedula para identificar a la persona a eliminar</param>
        /// <returns></returns>
        public SqlDataReader eliminarVendedor(string cedula)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC DELvendedor '{0}'", cedula);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader insertarProveedor(int idProveedor, string nombreEmpresa, string descripcion, int idDistrito, string otrasSeñas)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC INSproveedor '{0}', '{1}', '{2}', '{3}', '{4}'", idProveedor, nombreEmpresa, descripcion, idDistrito, otrasSeñas);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader eliminarProveedor(int idProveedor)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC DELproveedor '{0}'", idProveedor);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader agregarCorreoProveedor(int idProveedor, string correo)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC INScorreosProveedor '{0}', '{1}'", idProveedor, correo);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader agregarTelefonoProveedor(int idProveedor, string telefono)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC INStelefonoProveedor '{0}', '{1}'", idProveedor, telefono);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader eliminarCorreoProveedor(int idProveedor, string correo)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC DELcorreosProveedor '{0}', '{1}'", idProveedor, correo);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader eliminarTelefonoProveedor(int idProveedor, string telefono)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC DELtelefonoProveedor '{0}', '{1}'", idProveedor, telefono);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader modificarProveedor(int idProveedor, string nombreEmpresa, string descripcion, int idDistrito, string otrasSeñas)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC UPDPProveedor '{0}', '{1}', '{2}', '{3}', '{4}'", idProveedor, nombreEmpresa, descripcion, idDistrito, otrasSeñas);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader modificarCorreoProveedor(int idProveedor, string correo, string correoNuevo)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC UPDcorreosProveedor '{0}', '{1}', '{2}'", idProveedor, correo, correoNuevo);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader modificarTelefonoProveedor(int idProveedor, string telefono, string telefonoNuevo)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC UPDtelefonoProveedor '{0}', '{1}', '{2}'", idProveedor, telefono, telefonoNuevo);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader cargarIdProveedores()
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = "Select idProveedor from Proveedor";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader cargarCorreosProveedor(int idProveedor)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("select correo from CorreosProveedor where idProveedor = '{0}'", idProveedor);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader cargarTelefonosProveedor(int idProveedor)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("select telefono from TelefonoProveedor where idProveedor = '{0}'", idProveedor);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Metodo para agregar un producto
        /// </summary>
        public SqlDataReader agregarProducto(int codigo, string tipoImpuesto, string categoria, string nombre, string marca, int precioVenta, int stock, string familiaProducto, int idProvedor)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC INSproducto '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}'", codigo, tipoImpuesto, categoria, nombre, marca, precioVenta, stock, familiaProducto, idProvedor);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Método que llena el comboBox nombre del modificar Producto
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public SqlDataReader cargarCodigoProducto()
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("select * from Producto");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Método para modificar un telefono
        /// </summary>
        public SqlDataReader modificarProducto(int codigo, string tipoImpuesto, string categoria, string nombre, string marca, int precioVenta, int stock, string familiaProducto)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC UPDProducto '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}'", codigo, tipoImpuesto, categoria, nombre, marca, precioVenta, stock, familiaProducto);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Método para seleccionar los datos de un producto en insertado
        /// </summary>
        /// <param name="codigo">Contiene la llave primaria del producto para buscarlo</param>
        /// <returns></returns>
        public SqlDataReader obtenerDatosProducto(int codigo)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("select * from Producto where codigo = '{0}'", codigo);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader eliminarProducto(int codigo)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC DELproducto '{0}'", codigo);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        // metodos cliente factura--------------------------------------------
        //--------------------------------------------------------------------

        public SqlDataReader cargarCedulaCliente()
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("select cedula from cliente");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Metodo para cargar los datos de un producto
        /// </summary>
        /// <returns>Una variable con las tablas de la vista</returns>
        public SqlDataReader cargarVistaProductosFactura(int codigo)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("select * from VISProductosParaFactura where codigo = {0}", codigo);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader cargarNumeroFactura()
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("select * from factura");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader cargarMontoFactura(int numFactura)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("select * from factura where numFactura = '{0}'", numFactura);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader realizarPagoFactura(int numFactura, int monto, string fechaPago)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC INSpago '{0}', '{1}', '{2}'", numFactura, monto, fechaPago);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Método para agregar una factura y sus productos
        /// </summary>>
        /// <returns></returns>
        public SqlDataReader insertarFacturaProductos(int numeroFactura, string tipoFactura, string hora, string fecha, string cedulaComprador, string cedulaVendedor
        , int montoCredito, int codigo, int cantidad)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();


            if (tipoFactura == "Crédito") {
                string query = string.Format("EXEC INSfactura '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}'", numeroFactura, tipoFactura, hora, fecha, cedulaComprador, cedulaVendedor, montoCredito, codigo, cantidad);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                return (dr);
            }
            else
            {
                string query = string.Format("EXEC INSfactura '{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}', '{8}'", numeroFactura, tipoFactura, hora, fecha, "null", cedulaVendedor, montoCredito, codigo, cantidad);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                return (dr);
            }
        }
        /// <summary>
        /// Metodo que carga toda la informacion acerca productos
        /// </summary>
        /// <returns></returns>
        public SqlDataReader cargarVISstock()
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("select * from ViewStock");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader agregarCliente(string cedula, string nombre, string apellido1, string apellido2, string sexo, int numFactura, string tipoVendedor, int idDistrito, string otrasSeñas)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC INScliente '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}'", cedula, nombre, apellido1, apellido2, sexo, idDistrito, otrasSeñas, numFactura, tipoVendedor);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader modificarTipoCliente(string cedula)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC UPDtipoCliente '{0}'", cedula);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Método que obtiene la vista de productos comprados
        /// </summary>
        /// <returns></returns>
        public SqlDataReader mostrarProductosFormaPago(string fecha, string formaPago)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC VISProVendidosDiaFormaDePago '{0}', '{1}'", fecha, formaPago);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Metodo para mostrar las ventas realizadas por un vendedor en un dia
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="cedulaVendedor"></param>
        /// <returns></returns>
        public SqlDataReader mostrarVentasPorVendedor(string fecha, string cedulaVendedor)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC VISProVendidosDiaVendedor '{0}', '{1}'", fecha, cedulaVendedor);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Método para mostrar las ventas realizadas basandose en la familia del producto
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="familiaProducto"></param>
        /// <returns></returns>
        public SqlDataReader mostrarVentasPorFamiliaProducto(string fecha, string familiaProducto)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC VISProVendidosDiaFamiliaProductos '{0}', '{1}'", fecha, familiaProducto);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Método que obtiene los datos de un producto mediante un nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public SqlDataReader obtenerDatosProductoNombre(string nombre)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("Select * from producto Where nombre = '{0}'", nombre);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Método para obtener los datos mediante un nombre
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SqlDataReader obtenerDatosProductoID(int id)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("Select * from producto Where codigo = '{0}'", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        /// <summary>
        /// Método para obtener los datos de un producto usando la familia de producto
        /// </summary>
        /// <param name="familiaProducto"></param>
        /// <returns></returns>
        public SqlDataReader obtenerDatosProductoFamiliaProducto(string familiaProducto)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("Select * from producto Where familiaProductos = '{0}'", familiaProducto);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader cargarVISDeudores()
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("select * from ViewFacturasCredito");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }

        public SqlDataReader agregarProductosStock(int codigo, int cantidad)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string query = string.Format("EXEC UPDATEProductoStock '{0}', '{1}'", codigo, cantidad);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr);
        }
    }
}
