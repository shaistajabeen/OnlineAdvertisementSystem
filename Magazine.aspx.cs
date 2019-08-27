using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace Advertiser
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL obj=new BLL();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            String filename = Path.GetFileName(FileUp.FileName);
            FileUp.SaveAs(Server.MapPath("~/Upload/") + filename);
            BLL obj = new BLL();
            BLL.Magazine(DD1.SelectedItem.Value, Fdate.Text.Trim(), Tdate.Text.Trim(), DD2.SelectedItem.Value, DD3.SelectedItem.Value, DD4.SelectedItem.Value, RB1.Text.Trim(), TB4.Text.Trim(), filename);
        }
    }
}