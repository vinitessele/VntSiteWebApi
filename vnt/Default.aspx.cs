using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vnt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Context db = new Context();
            db.Configuracao.ToList().ForEach(p=> Label1.Text = p.valor);

            // List<DtoConfig> a = new List<DtoConfig>();
            /*var a = from i in db.Condiguracao
                    select new DtoConfig()
                    {
                        valor = i.valor,
                        campo = i.campo
                    };
                    */
        }
    }
}