<%@ Page Language="C#" CodeBehind="Index.aspx.cs" Inherits="CursoPruebas.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Matricula</title>
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
            $("#eliminarCurso").removeClass("current");
        });
    </script>
</head>
<body>
    <div id="Contenedor">
        <!--#include file="template/CabeceraT.aspx"-->
        <!--#include file="template/MenuLateralT.aspx"-->
        <div id="ContenidoCentral">
            <h3 id="MensajeBienvenida">Bienvenido Administrador</h3><br />
            <!-- Caption -->
            <img src="imagenes/matriculaFacil.png" style="margin-left: 10%" alt="MatriculaFacil" />
        </div>
        <label style="text-align: center;color: transparent">-----***PRUEBAS DE SOFTWARE***-----</label>
        <!--#include file="template/footer.aspx"-->
    </div>
</body>
</html>
