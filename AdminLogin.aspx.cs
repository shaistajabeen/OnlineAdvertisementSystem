using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Advertiser
{
    public partial class AdLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sign_In_Click1(object sender, EventArgs e)
        {

            ArrayList list = new ArrayList();
            list = BLL.AuthenticateAdmin(TextBox1.Text.Trim(), TextBox2.Text.Trim());
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToString() == "True")
                {
                    Session["UserName"] = list[i + 1].ToString();
                    Session["RoleId"] = list[i + 2].ToString();

                    Response.Redirect("AdminPage.aspx");
                }
                else if (list[i].ToString() == "False")
                {


                    Response.Write("Invalid  UserName/password");
                }

            }
        }
    }
}