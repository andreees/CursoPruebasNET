using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using UPC.CursoPruebas.BL.BE;
using UPC.CursoPruebas.DL.DALC;

namespace CursoPruebas
{
    public partial class CrearCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            divResultado.Visible = false;
        }

        protected void lnkCrearCurso(object sender, EventArgs e)
        {
            CursoBE objCursoBE = new CursoBE();
            objCursoBE.Nombre = txtNombre.Text;
            objCursoBE.Codigo = txtCodigo.Text;
            objCursoBE.Creditos = Convert.ToInt32(txtCreditos.Text);
            objCursoBE.Requisitos = txtRequisitos.Text;
            objCursoBE.Ciclo = Convert.ToInt32(txtCiclo.Text);

            CursoDALC objCursoDALC = new CursoDALC();
            divResultado.Visible = objCursoDALC.InsertarCurso(objCursoBE);
        }
    }
}