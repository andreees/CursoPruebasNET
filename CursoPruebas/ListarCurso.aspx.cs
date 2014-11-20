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
    public partial class ListarCurso : System.Web.UI.Page
    {
        public ListarCurso()
        {
            this.Load += new EventHandler(PageLoad);
        }

        protected void PageLoad(object sender, EventArgs e)
        {
            CursoDALC objCursoDALC = new CursoDALC();

            grdCursos.DataSource = objCursoDALC.ListarCursos();
            grdCursos.DataBind();
        }
    }
}