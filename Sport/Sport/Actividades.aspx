<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Actividades.aspx.cs" Inherits="Sport.Actividades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--  <script type="text/javascript">
        function mostrarAlerta() {
            var respuesta = confirm("¿Está seguro de que desea continuar?");
            if (respuesta == true) {
                alert("Ha seleccionado Aceptar");
            } else {
                alert("Ha seleccionado Cancelar");
            }
            return false;
        }
    </script>--%>
    <div style="padding-top: 5px;">
        <div class="row">
            <div class="col-10"></div>
            <div class="col">
                <a type="submit" class="btn btn-dark" href="agregarActividad.aspx">Agregar Actividad</a>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col">

                <h2 style="background: #F2F3F4; font-size: 25px; font-family: 'Sans Serif Collection';">Pendientes</h2>
                <asp:Repeater ID="repetidorPendientes" runat="server">
                    <ItemTemplate>
                        <div class="card mb-3" style="max-width: 540px;">
                            <div class="row g-0">
                                <div class="col-md-4">
                                    <img src="<%#Eval("Actividad.Imagen")%>" class="img-fluid rounded-start" onerror="this.src='https://assets.cdn-shop.com/mi-arte3-es/assets/img/backgrounds/placeholder-8b83e412a5.svg';" alt="...">
                                </div>
                                <div class="col-md-4">
                                    <div class="card-body">
                                        <h5 class="card-title"><%#Eval("Actividad.actividad")%></h5>
                                        <p style="color: grey"><%#Eval("Actividad.Dias")%></p>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="card-body">
                                        <p style="color: grey">De: <%#Eval("Actividad.horarioInicio")%>  hasta: <%#Eval("Actividad.horarioFin")%> </p>
                                        <p style="color: grey;" class="card-text">$<%#Eval("Actividad.Precio")%></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>





                <h2 style="background: #F2F3F4; font-size: 25px; font-family: 'Sans Serif Collection';">Mis Inscripciones</h2>
                <asp:Repeater ID="repetidorMisInscripciones" runat="server">
                    <ItemTemplate>
                        <div class="card mb-3" style="max-width: 540px;">
                            <div class="row g-0">
                                <div class="col-md-4">
                                    <img src="<%#Eval("Actividad.Imagen")%>" class="img-fluid rounded-start" onerror="this.src='https://assets.cdn-shop.com/mi-arte3-es/assets/img/backgrounds/placeholder-8b83e412a5.svg';" alt="...">
                                </div>
                                <div class="col-md-4">
                                    <div class="card-body">
                                        <h5 class="card-title"><%#Eval("Actividad.actividad")%></h5>
                                        <p style="color: grey"><%#Eval("Actividad.Dias")%></p>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="card-body">
                                        <p style="color: grey">De: <%#Eval("Actividad.horarioInicio")%>  hasta: <%#Eval("Actividad.horarioFin")%> </p>
                                        <p style="color: grey;" class="card-text">$<%#Eval("Actividad.Precio")%></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <h2 style="background: #F2F3F4; font-size: 25px; font-family: 'Sans Serif Collection';">Clases</h2>
                <asp:Repeater ID="repetidor" runat="server">
                    <ItemTemplate>
                        <div class="card mb-3" style="max-width: 540px;">
                            <div class="row g-0">
                                <div class="col-md-4">
                                    <img src="<%#Eval("Imagen")%>" class="img-fluid rounded-start" onerror="this.src='https://assets.cdn-shop.com/mi-arte3-es/assets/img/backgrounds/placeholder-8b83e412a5.svg';" alt="...">
                                </div>
                                <div class="col-md-4">
                                    <div class="card-body">
                                        <h5 class="card-title"><%#Eval("actividad")%></h5>
                                        <p style="color: grey"><%#Eval("Profesor.Nombre")%></p>
                                        <p style="color: grey"><%#Eval("Profesor.Apellido")%></p>
                                        <p style="color: grey"><%#Eval("Dias")%></p>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="card-body">
                                        <p style="color: grey">De: <%# ((DateTime)Eval("fechaInicio")).ToShortDateString() %></p>
                                        <p style="color: grey">Hasta: <%# ((DateTime)Eval("fechaFin")).ToShortDateString() %></p>
                                        <hr />
                                        <p style="color: grey">De: <%#Eval("horarioInicio")%>  hasta: <%#Eval("horarioFin")%> </p>
                                        <p style="color: grey;" class="card-text">$<%#Eval("Precio")%></p>
                                        <asp:Button Text="Modificar" ID="btnModificar" AutoPostBack="true" OnClick="btnModificar_Click" CssClass="btn btn-success" CommandArgument='<%#Eval("Id")%>' runat="server" />
                                        <asp:Button Text="Inscribirse" ID="btnInscribirse" AutoPostBack="true" OnClick="btnInscribirse_Click" CssClass="btn btn-primary" CommandArgument='<%#Eval("Id")%>' runat="server" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
