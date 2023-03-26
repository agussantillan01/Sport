<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listaProfesores.aspx.cs" Inherits="Sport.listaProfesores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h5>Profesores</h5>
    <asp:GridView ID="dgvListaProfesores" Style="width: 50%;" runat="server" DataKeyNames="Id" AutoGenerateColumns="false" CssClass="table table-success table-striped"
        OnClass="table">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
        </Columns>
    </asp:GridView>
</asp:Content>
