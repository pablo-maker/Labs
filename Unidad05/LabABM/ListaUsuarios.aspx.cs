using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListaUsuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int d=1; d<=31;d++) {
            ddlDiaFechaNacimiento.Items.Insert(0, new ListItem(d.ToString(), ""));
        }
    }
}