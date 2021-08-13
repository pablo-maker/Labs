using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

public partial class ListaUsuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            cargarDiasCalendario();
        }
        if (PaginaEnEstadoEdicion())
        {
            CargarDatosUsuario(Int32.Parse(Request.QueryString["id"]));
            this.lblAccion.Text = "Editar Usuario " + Request.QueryString["id"];
        }else
        {
            this.lblAccion.Text = "Agregar nuevo Usuario";
        }
    }
    private void cargarDiasCalendario()
    {
        //Cargar en el combo los items correspondientes a los días
        //(del 1 al 31)
        for (int d = 1; d <= 31; d++)
        {
            ddlDiaFechaNacimiento.Items.Insert(0, new ListItem(d.ToString(), ""));
        }
    }
    private bool PaginaEnEstadoEdicion()
    {
        if (Request.QueryString["id"] != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void CargarDatosUsuario(int idUsuario)
    {
        // 1 - Obtener los datos del usuario en cuestión
        // 2 - Cargar en los controles de la tabla los datos del usuario obtenido
        ManagerUsuarios managerUsuarios = new ManagerUsuarios();
        Usuario usr = new Usuario();
        usr = managerUsuarios.GetUsuario(idUsuario);

        this.txtNombre.Text = usr.Nombre;
        this.txtApellido.Text = usr.Apellido;
        this.txtEmail.Text = usr.Email;
        this.txtDirección.Text = usr.Direccion;
        this.txtTelefono.Text = usr.Telefono;
        this.txtNombreUsuario.Text = usr.NombreUsuario;
        this.txtClave.Text = usr.Clave;
        this.txtCelular.Text = usr.Celular;
        this.rblTipoDocumento.SelectedIndex = usr.TipoDoc.Value;
        this.txtNroDocumento.Text = usr.NroDoc.ToString();


    }



    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ManagerUsuarios mgrUsr = new ManagerUsuarios();
            Usuario usr = new Usuario();
            usr.Nombre = this.txtNombre.Text;
            usr.Apellido = this.txtApellido.Text;
            usr.Email = this.txtEmail.Text;
            usr.Direccion = this.txtDirección.Text;
            usr.Telefono = this.txtTelefono.Text;
            usr.NombreUsuario = this.txtNombreUsuario.Text;
            usr.Clave = this.txtClave.Text;
            usr.Celular = this.txtCelular.Text;
            usr.TipoDoc = this.rblTipoDocumento.SelectedIndex;
            usr.NroDoc = Int32.Parse(this.txtNroDocumento.Text);
            usr.FechaNac = new DateTime(Int32.Parse(this.txtAnioFechaNacimiento.Text), this.ddlMesFechaNacimiento.SelectedIndex, this.ddlDiaFechaNacimiento.SelectedIndex).ToString("MM-dd-yyyy");
            if (PaginaEnEstadoEdicion())
            {
                mgrUsr.ActualizarUsuario(usr);
            }
            else
            {
                mgrUsr.AgregarUsuario(usr);
            }
        }
        
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListaUsuarios.aspx");
    }
}