<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Actividades.aspx.cs" Inherits="Sport.Actividades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="padding-top:5px;">
        <div class="row">
            <div class="col-10"></div>
            <div class="col">
                <a type="submit" class="btn btn-dark" href="agregarActividad.aspx">Agregar Actividad</a>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col">
                <h2 style="background:#F2F3F4; font-size:25px; font-family:'Sans Serif Collection';">Mis Inscripciones</h2>
                <h2 style="background:#F2F3F4; font-size:25px;font-family:'Sans Serif Collection';">Clases</h2>
                        <asp:Repeater ID="repetidor" runat="server">
            <ItemTemplate>
                <div class="card mb-3" style="max-width: 540px;">
                    <div class="row g-0">
                        <div class="col-md-4">
                            <img src="<%#Eval("Imagen")%>" class="img-fluid rounded-start" onerror="this.src='https://assets.cdn-shop.com/mi-arte3-es/assets/img/backgrounds/placeholder-8b83e412a5.svg';" alt="...">
                        </div>
                        <div class="col-md-6">
                            <div class="card-body">
                                <h5 class="card-title"><%#Eval("actividad")%></h5>
                                <p style="color: grey"><%#Eval("Profesor.Nombre")%></p>
                                <p style="color: grey"><%#Eval("Profesor.Apellido")%></p>
                                <p style="color: grey"><%#Eval("Dias")%></p>
                                <p style="color: grey;" class="card-text"><%#Eval("Precio")%></p>
                                
                            </div>
                        </div>
                        <div class="col-md-2" style="padding:5px;">
                            <asp:Button  Text="Inscribirse" CssClass="btn btn-primary" runat="server" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
