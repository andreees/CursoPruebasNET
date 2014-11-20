using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CursoPruebas.template
{
    public partial class CabeceraT : System.Web.UI.Page
    {
        public CabeceraT()
        {
            this.Load += new EventHandler(PageLoad);
        }

        protected void PageLoad(object sender, EventArgs e)
        {
            //vacío
        }
    }
}