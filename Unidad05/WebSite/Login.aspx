<%@ Page Language="C#" MasterPageFile="~/LabLoginMasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" Runat="Server">

        <div>

        </div>
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
            <asp:Label ID="lblBienvenido" runat="server" Text="¡Bienvenido al Sistema!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td>
            <asp:TextBox ID="txtUsuario" runat="server" style="margin-top: 0px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
            <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
                </td>
                <td>
            <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
                </td>
            </tr>
            <tr>
                <td>
            <asp:LinkButton ID="lnkRecordarClave" runat="server" Text="Olvidé mi Clave" OnClick="lnkRecordarClave_Click">Olvidé mi Clave</asp:LinkButton>

                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
</asp:Content>