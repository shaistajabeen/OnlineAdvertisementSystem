using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Advertiser
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            {
                String filename = Path.GetFileName(Fu1.FileName);
                Fu1.SaveAs(Server.MapPath("~/Upload/") + filename);
                BLL obj = new BLL();
                BLL.Internet(DD1.SelectedItem.Value, Fdate.Text.Trim(), Tdate.Text.Trim(), DD2.SelectedItem.Value, RB1.Text.Trim(),TB1.Text.Trim(), filename);
            }
        }

    
    }
}