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
using PrograBases.ventanas;
using System.Data.SqlClient;

namespace PrograBases.ventanas
{
    public partial class cliente : Form
    {
        public vendedor vend;

        public cliente()
        {
            InitializeComponent();
        }

        private void cliente_Load(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.cargarIdDistrito();

            while (dr.Read())
            {
                idDistritoClientecomboBox.Items.Add(dr["idDistrito"].ToString());
            }
        }

        private void BTNagregarCliente_Click(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.agregarCliente(cedulaClienteTextBox.Text, nombreClienteTextBox.Text, apellido1ClienteTextBox.Text, apellido2ClienteTextBox.Text,
                sexoClientecomboBox.SelectedItem.ToString(), int.Parse(numClienteTextBox.Text), tipoClienteComboBox.SelectedItem.ToString(), 
                int.Parse(idDistritoClientecomboBox.SelectedItem.ToString()), otrasSeñasClienteTextBox.Text);
            dr.Read();
            MessageBox.Show("!! Se agrego Correctamente");
            vend.Visible = true;
            vend.cargarCedulaCliente();
            this.Visible = false;
        }

        private void BTNregresarVendedor_Click(object sender, EventArgs e)
        {
            vend.Visible = true;
            this.Visible = false;
        }
    }
}
