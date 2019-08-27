using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Advertiser
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
BLL obj= new BLL();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                String filename = Path.GetFileName(FU1.FileName);
                FU1.SaveAs(Server.MapPath("~/Upload/") + filename);
                BLL obj = new BLL();
                BLL.Banner(DD1.SelectedItem.Value,DD2.SelectedItem.Value,DD3.SelectedItem.Value, Fdate.Text.Trim(), Tdate.Text.Trim(), DD4.SelectedItem.Value, RB1.Text.Trim(), TB1.Text.Trim(), filename);
            }
        }

       
    }
}