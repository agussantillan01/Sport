<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listaUsuarios.aspx.cs" Inherits="Sport.listaUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col">
            <h5>Usuarios</h5>
            <asp:GridView ID="ddlListaUsuarios" Style="width: 50%;" runat="server" DataKeyNames="Id" AutoGenerateColumns="false" OnRowCommand="ddlListaUsuarios_RowCommand" CssClass="table table-success table-warning"
                OnClass="table">
                <Columns>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                    <asp:BoundField HeaderText="DNI" DataField="DNI" />
                    <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn btn-danger" Text="Asignar Profe" />

                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>
