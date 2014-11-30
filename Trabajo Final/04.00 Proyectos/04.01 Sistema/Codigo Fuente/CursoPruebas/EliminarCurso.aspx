<%@ Page Language="C#" CodeBehind="EliminarCurso.aspx.cs" Inherits="CursoPruebas.EliminarCurso" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cursos - Eliminar</title>
    <link rel="shortcut icon" type="image/x-icon" href="imagenes/iconoMF.png" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script type="text/javascript" src="js/kickstart.js"></script> <!-- KICKSTART -->
    <link rel="stylesheet" href="css/kickstart.css" media="all" /> <!-- KICKSTART -->
    <link rel="stylesheet" href="css/Basico.css" type="text/css"/>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#listarCurso").removeClass("current");
            $("#crearCurso").removeClass("current");
            $("#modificarCurso").removeClass("current");
            $("#eliminarCurso").addClass("current");
        });
    </script>
</head>
<body>
    <form id="frmCursos" runat="server">
    <div id="Contenedor">
            <!--#include file="template/CabeceraT.aspx"-->
            <!--#include file="template/MenuLateralT.aspx"-->
            <div id="ContenidoCentral">
                <h3 id="MensajeBienvenida">Eliminar Cursos</h3><br>
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
                    <asp:TemplateField HeaderText="Eliminar" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEliminar" runat="server" CommandName="cmdEliminar" CommandArgument='<%# Eval("idcurso") %>'><i class="icon-remove"></i></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView>
                <!------>
                <!-- Success -->
                    <div runat="server" id="divResultado" class="notice success"><i class="icon-ok icon-large"></i><label id="lblMensaje">Curso eliminado Correctamente.</label> 
                        <a href="#close" class="icon-remove"></a></div>
            </div>
            <label style="text-align: center;color: transparent">-----***PRUEBAS DE SOFTWARE***-----</label>
            <!--#include file="template/footer.aspx"-->
        </div>      
    </form>
</body>
</html>
