<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listaUsuarios.aspx.cs" Inherits="Sport.listaUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <div class="col-6">
            <h5>Usuarios</h5>
            <asp:GridView ID="ddlListaUsuarios" Style="width: 50%;" runat="server" DataKeyNames="Id" AutoGenerateColumns="false" CssClass="table table-success table-warning"
                OnClass="table">
                <Columns>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                    <asp:ButtonField Text="Asignar Profesor" ControlStyle-CssClass="btn btn-outline-success" CommandName="Boton1" />
                </Columns>
            </asp:GridView>
        </div>
</asp:Content>
