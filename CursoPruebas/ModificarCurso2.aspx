<%@ Page Language="C#" CodeBehind="ModificarCurso2.aspx.cs" Inherits="CursoPruebas.ModificarCurso2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Cursos - Modificar</title>
    <link rel="shortcut icon" type="image/x-icon" href="imagenes/iconoMF.png" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script type="text/javascript" src="js/kickstart.js"></script> <!-- KICKSTART -->
    <link rel="stylesheet" href="css/kickstart.css" media="all" /> <!-- KICKSTART -->
    <link rel="stylesheet" href="css/Basico.css" type="text/css"/>
    <script type="text/javascript">
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
                <h3 id="MensajeBienvenida">Modificar Curso</h3><br>
                <div style="padding-left: 20%">
                    <table style="width: 60%">
                        <tr>
                            <td colspan="2"><asp:ValidationSummary ID="vsProductoDetalle" runat="server" CssClass="spnMensajeError" /></td>
                        </tr>
                        <tr>
                            <td>
                                <label for="txtNombre">Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="right">(Ej: Lenguaje1)</span></label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtNombre" runat="server" MaxLength="100"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" Display="Dynamic" ErrorMessage="Por favor ingrese el nombre." CssClass="spnMensajeError"><i class="icon-remove"></i></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label for="txtCodigo">Codigo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="right">(Ej: HU23)</span></label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCodigo" runat="server" MaxLength="5"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvCodigo" runat="server" ControlToValidate="txtCodigo" Display="Dynamic" ErrorMessage="Por favor ingrese un codigo" CssClass="spnMensajeError"><i class="icon-remove"></i></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label for="txtCreditos">Creditos&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="right">(Ej: 3)</span></label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCreditos" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvCreditos" runat="server" ControlToValidate="txtCreditos" Display="Dynamic" ErrorMessage="Por favor ingrese creditos" CssClass="spnMensajeError"><i class="icon-remove"></i></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="rngCreditos" runat="server" ControlToValidate="txtCreditos" ErrorMessage="Por favor ingrese un numero[1-6]." Display="Dynamic" CssClass="spnMensajeError" Type="Integer" MinimumValue="1" MaximumValue="6"><i class="icon-remove"></i></asp:RangeValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label for="txtRequisitos">Requisitos&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="right">(Ej: HU20)</span></label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtRequisitos" runat="server" MaxLength="100"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvRequisitos" runat="server" ControlToValidate="txtRequisitos" Display="Dynamic" ErrorMessage="Por favor ingrese requisitos" CssClass="spnMensajeError"><i class="icon-remove"></i></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label for="txtCiclo">Ciclo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="right">(Ej: 2)</span></label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCiclo" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvCiclo" runat="server" ControlToValidate="txtCiclo" Display="Dynamic" ErrorMessage="Por favor ingrese ciclo" CssClass="spnMensajeError"><i class="icon-remove"></i></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="rngCiclo" runat="server" ControlToValidate="txtCiclo" ErrorMessage="Por favor ingrese un numero[1-10]." Display="Dynamic" CssClass="spnMensajeError" Type="Integer" MinimumValue="1" MaximumValue="10"><i class="icon-remove"></i></asp:RangeValidator>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton ID="btnModificarCurso" runat="server" OnClick="LnkGuardarCurso">Modificar Curso</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                    <!-- Success -->
                    <div runat="server" id="divResultado" class="notice success"><i class="icon-ok icon-large"></i><label id="lblMensaje">El curso ha sido modificado correctamente.</label> 
                        <a href="#close" class="icon-remove"></a></div>
                </div>
            </div>
            <label style="text-align: center;color: transparent">-----***PRUEBAS DE SOFTWARE***-----</label>
            <!--#include file="template/footer.aspx"-->
        </div>
    </form>
</body>
</html>

