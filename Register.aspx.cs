using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.UI.HtmlControls;

namespace Advertiser
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL obj = new BLL();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();
            BLL.Register(EmailID.Text.Trim(), UN.Text.Trim(), Password.Text.Trim(), RePW.Text.Trim(), Name.Text.Trim(), Address.Text.Trim(), MobileNo.Text.Trim(), PhoneNo.Text.Trim(), Designation.Text.Trim(),Gender.SelectedItem.Value);
            LabelInfo.Text = "Successfully Registered!";
            Response.Redirect("Register.aspx");
           
        }

        protected void Log_In_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list = BLL.AuthenticateUserR(TextBox1.Text.Trim(), TextBox2.Text.Trim());
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToString() == "True")
                {
                    Session["UserName"] = list[i + 1].ToString();
                    Session["RoleId"] = list[i + 2].ToString();

                    Response.Redirect("SelectMedium.aspx");
                }
                else if (list[i].ToString() == "False")
                {


                    Response.Write("Invalid  UserName/password");
                }

            }
        }
    }
}
