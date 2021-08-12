using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        //Validar usuario y clave
        if (txtUsuario.Text.ToLower() == "admin" && this.txtClave.Text == "admin")
        {
            Page.Response.Write("Ingreso OK");
        }
        else
        {
            Page.Response.Write("Usuario y/o contraseña incorectos");
        }
    }

    protected void lnkRecordarClave_Click(object sender, EventArgs e)
    {
        //Redireccionar a otra pagina
        Response.Redirect("~/Default.aspx?=msj=Es Ud. un usuario muy descuidado, haga memoria");
    }
}