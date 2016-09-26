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
using PrograBases.ventanas;
using PrograBases;

namespace PrograBases
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void BTNIngresar_Click(object sender, EventArgs e)
        {
            sisVdatos sisV = new sisVdatos();
            SqlDataReader dr = sisV.cargarlogin();

            while (dr.Read())
            {
                if (TBusuario.Text == dr["NombreUsuario"].ToString())
                {
                    if (TBcontraseña.Text == dr["contraseña"].ToString())
                    {
                        if (dr["tipoVendedor"].ToString() == "Administrador")
                        {
                            vendedor venAdmin = new vendedor();
                            venAdmin.estadoBTN = true;
                            venAdmin.loginUsuario = this;
                            venAdmin.cedulaVendedor = dr["cedula"].ToString();
                            venAdmin.Visible = true;
                            this.Visible = false;
                            return;
                        }
                        else 
                        {
                            vendedor venNormal = new vendedor();
                            venNormal.loginUsuario = this;
                            venNormal.cedulaVendedor = dr["cedula"].ToString();
                            venNormal.Visible = true;
                            this.Visible = false;
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("Usuario o contraseña incorrecta");
        }
    }
}
