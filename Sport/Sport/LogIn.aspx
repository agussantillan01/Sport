<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Sport.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <br />
    <h1 style="text-align: center; color: grey;">Login</h1>
    <br />
    <br />
    <div class="text-center">
        <img style="width: 250px;" src="../img/icon-flaticon.png" class="rounded" alt="...">
    </div>

    <div class="row">
        <div class="col-2"></div>
        <div class="col-2"></div>
        <div class="col">
            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label">Email</label>
                <asp:TextBox type="email" ID="txtEmail" class="form-control" aria-describedby="emailHelp" runat="server" />
            </div>
            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">Password</label>
                <asp:TextBox type="password" ID="txtPassword" class="form-control" runat="server" />
            </div>
            <asp:Button Text="Ingresar" ID="btnIngresar" OnClick="btnIngresar_Click" CssClass="btn btn-primary" runat="server" />
            <a href="creaCuenta.aspx">Crea una cuenta</a>

        </div>

        <div class="col-2"></div>
        <div class="col-2"></div>
    </div>
</asp:Content>
