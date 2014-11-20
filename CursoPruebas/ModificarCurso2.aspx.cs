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
    public partial class ModificarCurso2 : System.Web.UI.Page
    {
        public ModificarCurso2()
        {
            this.Load += new EventHandler(PageLoad);
        }

        protected void PageLoad(object sender, EventArgs e)
        {
            if (!(Page.IsPostBack))
            {
                int idCurso;

                idCurso = Convert.ToInt32(Request.QueryString["idCurso"]);
                ViewState["idCurso"] = idCurso.ToString();
                // Bind elements
                CursoDALC objCursoDALC = new CursoDALC();
                CursoBE objCursoBE = objCursoDALC.ObtenerCursoPorid(idCurso);
                txtNombre.Text = objCursoBE.Nombre;
                txtCodigo.Text = objCursoBE.Codigo;
                txtCreditos.Text = objCursoBE.Creditos.ToString();
                txtRequisitos.Text = objCursoBE.Requisitos;
                txtCiclo.Text = objCursoBE.Ciclo.ToString();

                divResultado.Visible = false;
            }
        }

        protected void LnkGuardarCurso(object sender, EventArgs e)
        {
            CursoBE objCursoBE = new CursoBE();
            objCursoBE.IdCurso = Convert.ToInt32(ViewState["idCurso"]);
            objCursoBE.Nombre = txtNombre.Text;
            objCursoBE.Codigo = txtCodigo.Text;
            objCursoBE.Creditos = Convert.ToInt32(txtCreditos.Text);
            objCursoBE.Requisitos = txtRequisitos.Text;
            objCursoBE.Ciclo = Convert.ToInt32(txtCiclo.Text);

            CursoDALC objCursoDALC = new CursoDALC();
            divResultado.Visible = objCursoDALC.ActualizarCurso(objCursoBE);
        }
    }
}