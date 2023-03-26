<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="agregarActividad.aspx.cs" Inherits="Sport.agregarActividad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div style="text-align:center; padding-bottom:50px;">
            <h2 style="font-family:'Sans Serif Collection';">Agregue una Actividad</h2>
        </div>
        <div class="col-6">
            <div class="mb-3">
                <asp:Label Text="Actividad(*)" CssClass="form-label" runat="server" />
                <asp:TextBox ID="txtActividad" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label Text="Profesor(*)" CssClass="form-label" runat="server" />
                <asp:DropDownList ID="ddlProfesores" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <asp:Label Text="Dias(*)" CssClass="form-label" runat="server" />
                <asp:TextBox CssClass="form-control" ID="txtDias" runat="server" />
                <asp:ListBox CssClass="form-select" SelectionMode="Multiple" AutoPostBack="true" OnSelectedIndexChanged="listDias_SelectedIndexChanged" ID="listDias" runat="server">
                    <asp:ListItem Value="1">Lunes</asp:ListItem>
                    <asp:ListItem Value="2">Martes</asp:ListItem>
                    <asp:ListItem Value="3">Miercoles</asp:ListItem>
                    <asp:ListItem Value="4">Jueves</asp:ListItem>
                    <asp:ListItem Value="5">Viernes</asp:ListItem>
                    <asp:ListItem Value="5">Sabado</asp:ListItem>
                    <asp:ListItem Value="5">Domingo</asp:ListItem>
                </asp:ListBox>
            </div>
            <div class="mb-3">
                <asp:Label Text="Imagen" CssClass="form-label" runat="server" />
                <asp:textBox ID="txtImagenUrl" onerror="this.src='https://assets.cdn-shop.com/mi-arte3-es/assets/img/backgrounds/placeholder-8b83e412a5.svg';" CssClass="form-control" runat="server"></asp:textBox>
            </div>
            <asp:Button Text="Agregar" ID="btnAgregar" OnClick="btnAgregar_Click" CssClass="btn btn-success" runat="server" />
            <asp:Label Text="" ID="lblErrorCampos" style="color:red;" runat="server" />
        </div>

        <div class="col-2" style="padding-top: 180px;">
            <asp:Button Style="display: inline-block;" CssClass="btn btn-outline-danger" ID="btnLimpiar" OnClick="btnLimpiar_Click" Text="Limpiar Dias" runat="server" />

        </div>
        <div class="col">
            <div class="mb-3">
                <asp:Label Text="Modalidad" CssClass="form-label" runat="server" />
                <asp:DropDownList ID="ddlModalidad" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <asp:Label Text="Fecha Inicio(*)" CssClass="form-label" runat="server" />
                <asp:TextBox ID="txtFechaInicio" TextMode="Date" class="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label Text="Fecha Fin(*)" CssClass="form-label" runat="server" />
                <asp:TextBox ID="txtFechaFin" TextMode="Date" class="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label Text="Horario de:(*)" CssClass="form-label" runat="server" />
                <asp:TextBox ID="txtHorarioInicio" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label Text="Horario hasta:(*)" CssClass="form-label" runat="server" />
                <asp:TextBox ID="txtHorarioFin" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label Text="Precio(*)" CssClass="form-label" runat="server" />
                <asp:TextBox ID="txtPrecio" CssClass="form-control" runat="server" />
            </div>
        </div>

    </div>
</asp:Content>
