<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sport.Default" %>
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
                background: #000;
                padding: 15px;
                color: #f3f3f3;
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

        <br />
        <h3 style="font-family: Arial; text-decoration: underline; padding-top: 80px; color: #717D7E; text-align: center;">¿Por qué anotarse?</h3>
        <div class="row row-cols-1 row-cols-md-3 g-4 sectionCard">
            <div class="col">
                <div class="card">
                    <div class="face front">
                        <img src="../img/tarjeta1.jpg" alt="Gimansio" />
                        <h3>Actividad Fisica</h3>
                    </div>
                    <div class="face back">
                        <h3>Actividad Fisica</h3>
                        <p>Hacer actividad física regularmente puede ayudarte a mantener fuertes tus habilidades para pensar, aprender y tener buen juicio con el pasar de los años. También puede reducir tu riesgo de depresión y ansiedad, al igual que ayudarte a dormir mejor.</p>
                        <div class="link">
                            <p>Gym</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="card">
                    <div class="face front">
                        <img src="../img/tarjeta2.jpg" alt="Alternate Text" />
                        <h3>Actividad para mayores</h3>
                    </div>
                    <div class="face back">
                        <h5>Actividad para mayores</h5>
                        <p>Como un adulto mayor, una de las cosas más importantes que puedes hacer por tu salud es hacer actividad física regularmente. Puede prevenir o retrasar muchos de los problemas de salud que parecen surgir con los años.</p>
                        <div class="link">
                            <p>Actividad para mayores</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="card">
                    <div class="face front">
                        <img src="../img/tarjeta3.jpg" alt="Alternate Text" />
                        <h3>Socializar</h3>
                    </div>
                    <div class="face back">
                        <h3>Socializar</h3>
                        <p>Los deportes fomentan la identidad y la amistad. La participación en los deportes ayuda a crear una identidad social.</p>
                        <div class="link">
                            <p>Socializar</p>
                        </div>
                    </div>
                </div>
            </div>

            <br />
            <br />
        </div>
        </div>
</asp:Content>
