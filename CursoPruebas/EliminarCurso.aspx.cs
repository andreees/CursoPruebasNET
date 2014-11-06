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
    public partial class EliminarCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CursoDALC objCursoDALC = new CursoDALC();

            grdCursos.DataSource = objCursoDALC.ListarCursos();
            grdCursos.DataBind();
        }

        protected void grdProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToUpper().Equals("CMDELIMINAR"))
            {
                CursoDALC objCursoDALC = new CursoDALC();
                int idCurso = Convert.ToInt32(e.CommandArgument);
                objCursoDALC.EliminarCurso(idCurso);
                Response.Redirect("EliminarCurso.aspx");
            }
        }
    }
}