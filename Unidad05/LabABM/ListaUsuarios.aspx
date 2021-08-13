<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListaUsuarios.aspx.cs" Inherits="ListaUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
            height: 34px;
        }
        .auto-style2 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="grdUsuarios" runat="server" AutoGenerateColumns="False" DataSourceID="odsUsuarios">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="TipoDoc" HeaderText="TipoDoc" SortExpression="TipoDoc" />
                    <asp:BoundField DataField="NroDoc" HeaderText="NroDoc" SortExpression="NroDoc" />
                    <asp:BoundField DataField="FechaNac" HeaderText="FechaNac" SortExpression="FechaNac" />
                    <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="Celular" HeaderText="Celular" SortExpression="Celular" />
                    <asp:BoundField DataField="NombreUsuario" HeaderText="NombreUsuario" SortExpression="NombreUsuario" />
                    <asp:BoundField DataField="Clave" HeaderText="Clave" SortExpression="Clave" />
                    <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="ListaUsuarios.aspx?id={0}" Text="Editar" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="odsUsuarios" runat="server" DataObjectTypeName="Negocio.Usuario" DeleteMethod="BorrarUsuario" InsertMethod="AgregarUsuario" SelectMethod="GetAll" TypeName="Negocio.ManagerUsuarios" UpdateMethod="ActualizarUsuario">
                <DeleteParameters>
                    <asp:Parameter Name="Id" Type="Int32" />
                </DeleteParameters>
            </asp:ObjectDataSource>
            <table style="width:100%;">
        <tr>
                <td align="center" colspan="2">
                    <asp:Label ID="lblAccion" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Apellido:</td>
                <td>
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" class="auto-style1">
                    Nombre:</td>
                
                <td class="auto-style2">
                    &nbsp;<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Tipo de Documento:</td>
                <td>
                    <asp:RadioButtonList ID="rblTipoDocumento" runat="server">
                        <asp:ListItem Value="1">DNI</asp:ListItem>
                        <asp:ListItem Value="2">LC / LE</asp:ListItem>
                        <asp:ListItem Value="3">C&#233;dula Identidad</asp:ListItem>
                        <asp:ListItem Value="4">Pasaporte</asp:ListItem>
                        <asp:ListItem Value="5">Otro</asp:ListItem>
                    </asp:RadioButtonList></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Nro de Documento:</td>
                <td>
                    <asp:TextBox ID="txtNroDocumento" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Fecha de Nacimiento:</td>
                <td>
                    <asp:DropDownList ID="ddlDiaFechaNacimiento" runat="server">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlMesFechaNacimiento" runat="server">
                        <asp:ListItem>Enero</asp:ListItem>
                        <asp:ListItem>Febrero</asp:ListItem>
                        <asp:ListItem>Marzo</asp:ListItem>
                        <asp:ListItem>Abril</asp:ListItem>
                        <asp:ListItem>Mayo</asp:ListItem>
                        <asp:ListItem>Junio</asp:ListItem>
                        <asp:ListItem>Julio</asp:ListItem>
                        <asp:ListItem>Agosto</asp:ListItem>
                        <asp:ListItem>Septiembre</asp:ListItem>
                        <asp:ListItem>Octubre</asp:ListItem>
                        <asp:ListItem>Noviembre</asp:ListItem>
                        <asp:ListItem>Diciembre</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txtAnioFechaNacimiento" runat="server" MaxLength="4" Width="50px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Dirección:</td>
                <td>
                    <asp:TextBox ID="txtDirección" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Teléfono:</td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Email:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Celular:</td>
                <td>
                    <asp:TextBox ID="txtCelular" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Nombre de Usuario:</td>
                <td>
                    <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Clave:</td>
                <td>
                    <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Confirmar Clave:</td>
                <td>
                    <asp:TextBox ID="txtConfirmarClave" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="center">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" /></td>
                <td align="center">
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" /></td>
            </tr>

    </table>
        </div>
    </form>
    
</body>
</html>
