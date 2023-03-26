<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="creaCuenta.aspx.cs" Inherits="Sport.creaCuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row">
        <div class="col-4"></div>
        <div class="col" style="padding-top: 50px;">
            <div class="mb-3">
                <label class="form-label">Nombre(*)</label>
                <asp:TextBox ID="txtNombre" class="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label class="form-label">Apellido(*)</label>
                <asp:TextBox ID="txtApellido" class="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label">Email</label>
                <asp:TextBox type="email" ID="txtEmail" class="form-control" aria-describedby="emailHelp" runat="server" />
            </div>
            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">Password</label>
                <asp:TextBox type="password" ID="txtPassword" class="form-control" runat="server" />
                <div style="padding-top: 10px;">
                    <asp:Button CssClass="btn btn-dark" ID="btnRegistrar" OnClick="btnRegistrar_Click" Text="Regristrar" runat="server" />
                </div>
                <asp:Label Style="color:red;" Text="" ID="lblError" runat="server" />
            </div>
        </div>
        <div class="col-4"></div>
    </div>
</asp:Content>
