<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="gestionRoles.aspx.cs" Inherits="Sport.gestionRoles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <style>
        .card {
            position: relative;
            width: 300px;
            height: 350px;
        }

            .card .face {
                position: absolute;
                width: 100%;
                height: 100%;
                backface-visibility: hidden;
                border-radius: 10px;
                overflow: hidden;
                transition: .5s;
            }

            .card .front {
                transform: perspective(600px) rotateY(0deg);
                box-shadow: 0 5px 10px #000;
            }

                .card .front img {
                    position: absolute;
                    width: 100%;
                    height: 100%;
                    object-fit: cover;
                }

                .card .front h3 {
                    position: absolute;
                    bottom: 0;
                    width: 100%;
                    height: 45px;
                    line-height: 45px;
                    color: #fff;
                    background: rgba(0,0,0,.4);
                    text-align: center;
                }

            .card .back {
                transform: perspective(600px) rotateY(180deg);
                background: #F5F5DC;
                padding: 15px;
                color: black;
                display: flex;
                flex-direction: column;
                justify-content: space-between;
                text-align: center;
                box-shadow: 0 5px 10px #000;
            }

                .card .back .link {
                    border-top: solid 1px #f3f3f3;
                    height: 50px;
                    line-height: 50px;
                }

                    .card .back .link a {
                        color: #f3f3f3;
                    }

                .card .back h3 {
                    font-size: 30px;
                    margin-top: 20px;
                    letter-spacing: 2px;
                }

                .card .back p {
                    letter-spacing: 1px;
                }

            .card:hover .front {
                transform: perspective(600px) rotateY(180deg)
            }

            .card:hover .back {
                transform: perspective(600px) rotateY(360deg)
            }
    </style>

    <div class="row">
        <div class="col-2"></div>
            <div class="row row-cols-1 row-cols-md-3 g-4 sectionCard">
                <div class="col-4">
                    <div class="card" style="padding-right:15px;">
                        <div class="face front">
                            <img src="../img/img-Usuarios.jpg" alt="Gimansio" />
                            <h3 >Alumnos</h3>
                        </div>
                        <div class="face back">
                            <h3 style ="padding-top:50%; font-weight: bold; font-family:Comic Sans;">Alumnos</h3>
                            <hr />
                            <div class="link">
                                <a style="color:black;" href="listaUsuarios.aspx">Alumnos</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-4">
                    <div class="card">
                        <div class="face front">
                            <img src="../img/img-Profesor.png" alt="Alternate Text" />
                            <h3>Profesores</h3>
                        </div>
                        <div class="face back">
                            
                            <h3 style ="padding-top:50%; font-weight: bold; font-family:Comic Sans;">Profesores</h3>
                            <hr />
                            <div class="link">
                               
                                <a style="color:black;" href="listaProfesores.aspx">Profesores</a>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <br />
            </div>
        <div class="col-2"></div>

    </div>
</asp:Content>
