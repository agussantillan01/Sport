<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosPersonales.aspx.cs" Inherits="Sport.DatosPersonales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%if ((Dominio.Usuario)Session["Usuario"] != null)
        {%>
    <div class="row">
        <div style="text-align: center; padding-bottom: 50px;">

            <h2 style="font-family: 'Sans Serif Collection'; color: grey;">Datos Personales</h2>

        </div>
        <div class="col-6">
            <div class="mb-3">
                <asp:Label Text="Nombre(*)" CssClass="form-label" runat="server" />
                <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label Text="Apellido(*)" CssClass="form-label" runat="server" />
                <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label Text="Email(*)" CssClass="form-label" runat="server" />
                <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label Text="DNI - ingrese solamente numeros. SIN PUNTOS.(*)" CssClass="form-label" runat="server" />
                <asp:TextBox CssClass="form-control" ID="txtDNI" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label Text="Fecha de Nacimiento" CssClass="form-label" runat="server" />
                <asp:TextBox ID="txtFechaNacimiento" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

            <asp:Button Text="Agregar" OnClick="btnAgregar_Click" ID="btnAgregar" CssClass="btn btn-success" runat="server" />
            <asp:Label Text="" ID="lblErrorCampos" Style="color: red;" runat="server" />

        </div>
    </div>
    <%}
        else
        {
            Session.Add("Error", "Recuerde que debe loguearse!");
            Response.Redirect("ErrorLogin.aspx", false);
        } %>
</asp:Content>
