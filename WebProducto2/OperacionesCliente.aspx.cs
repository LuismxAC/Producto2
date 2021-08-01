using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassCapaIntedidades;
using ClassLogicaNegocioCarniceria;


namespace WebProducto2
{
    public partial class OperacionesCliente : System.Web.UI.Page
    {
        ClassLogicaCliente objetoLogica = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                objetoLogica = new ClassLogicaCliente();
                Session["objetoLogica"] = objetoLogica;

            }
            else
            {
                objetoLogica = (ClassLogicaCliente)Session["objetoLogica"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Cliente temporal = new Cliente
            {
                //id_Cliente = Convert.ToInt32(TextBox1.Text),
                Nombre = TextBox2.Text,
                App = TextBox3.Text,
                ApM = TextBox4.Text,
                Celular = TextBox5.Text,
                Correo = TextBox6.Text
            };
            string mensaje = "";

            objetoLogica.InsertaCliente(temporal, ref mensaje);

            TextBox7.Text = mensaje;
        }
    }
}