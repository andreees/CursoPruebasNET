﻿<%@ Page Language="C#" CodeBehind="ModificarCurso.aspx.cs" Inherits="CursoPruebas.ModificarCurso" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cursos - Modificar</title>
    <link rel="shortcut icon" type="image/x-icon" href="imagenes/iconoMF.png" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script type="text/javascript" src="js/kickstart.js"></script> <!-- KICKSTART -->
    <link rel="stylesheet" href="css/kickstart.css" media="all" /> <!-- KICKSTART -->
    <link rel="stylesheet" href="css/Basico.css" type="text/css"/>
    <script>
        $(document).ready(function () {
            $("#listarCurso").removeClass("current");
            $("#crearCurso").removeClass("current");
            $("#modificarCurso").addClass("current");
            $("#eliminarCurso").removeClass("current");
        });
    </script>
</head>
<body>
    <form id="frmCursos" runat="server">
    <div id="Contenedor">
            <!--#include file="template/CabeceraT.aspx"-->
            <!--#include file="template/MenuLateralT.aspx"-->
            <div id="ContenidoCentral">
                <h3 id="MensajeBienvenida">Modificar Cursos</h3><br>
                <!------>
                <asp:GridView ID="grdCursos" runat="server" CssClass="sortable" AutoGenerateColumns="false" OnRowCommand="GrdProductosRowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="Código" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <%# Eval("idcurso").ToString() %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre" ItemStyle-HorizontalAlign="Left"  HeaderStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <%# Eval("nombre").ToString()%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="creditos" HeaderText="Créditos" ItemStyle-HorizontalAlign="Right" />
                    <asp:TemplateField HeaderText="Modificar" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkModificar" runat="server" CommandName="cmdModificar" CommandArgument='<%# Eval("idcurso") %>'><i class="icon-edit"></i></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView>
                <!------>
            </div>
            <label style="text-align: center;color: transparent">-----***PRUEBAS DE SOFTWARE***-----</label>
            <!--#include file="template/footer.aspx"-->
        </div>
    </form>
</body>
</html>
