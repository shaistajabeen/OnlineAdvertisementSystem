<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Advertiser.AdLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>!!Admin Login!!</title>
     <style type="text/css">
    body {
	margin:0;
	padding:0;
	font: bold 11px/1.5em Verdana;
}

h2 {
	font: bold 14px Verdana, Arial, Helvetica, sans-serif;
	color: #000;
	margin: 0px;
	padding: 0px 0px 0px 15px;
}
 

	
	
/*- Menu Tabs F--------------------------- */

    #tabsF {
      float:left;
      width:100%;
      background:#efefef;
      font-size:93%;
      line-height:normal;
	  border-bottom:1px solid #666;
             margin-top: 27px;
             height: 49px;
         }
    #tabsF ul {
	margin:0;
	padding:10px 10px 0 50px;
	list-style:none;
      }
    #tabsF li {
      display:inline;
      margin:0;
      padding:0;
      }
    #tabsF a {
      float:left;
      background:url("Image/tableftF.gif") no-repeat left top;
      margin:0;
      padding:0 0 0 4px;
      text-decoration:none;
      }
    #tabsF a span {
      float:left;
      display:block;
      background:url("Image/tabrightF.gif") no-repeat right top;
      padding:5px 15px 4px 6px;
      color:#666;
      }
    /* Commented Backslash Hack hides rule from IE5-Mac \*/
    #tabsF a span {float:none;
             height: 19px;
             width: 53px;
         }
    /* End IE5-Mac hack */
    #tabsF a:hover span {
      color:#FFF;
      }
    #tabsF a:hover {
      background-position:0% -42px;
      }
    #tabsF a:hover span {
      background-position:100% -42px;
      }
	     </style>
</head>
<body style="font-weight: bold">
    <form id="form1" runat="server">
    <div>
        <img src="Images/Title.png" style="width: 1232px" />
        <table style="border-right: thin inset; border-top: thin inset; left: 365px; border-left: thin inset;
            width: 265px; border-bottom: thin inset; position: absolute; top: 141px; background-color: #dfffff">
            <tr>
                <td colspan="2" style="height: 17px">
                    <span style="color: #ff9966">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; ADMIN LOGIN</span><span style="color: #ff3300"><span style="background-color: khaki"><br />
                    </span>
            </span>
                </td>
            </tr>
            <tr>
                <td style="width: 70px">
                    UserName</td>
                <td style="width: 142px">
                    <asp:TextBox
                ID="TextBox1" runat="server" Style="border-top-style: inset; border-right-style: inset;
                border-left-style: inset; border-bottom-style: inset"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 70px">
                    Password</td>
                <td style="width: 142px">
                    <asp:TextBox
                ID="TextBox2" runat="server" Style="border-top-style: inset; border-right-style: inset;
                border-left-style: inset; border-bottom-style: inset" TextMode="Password" Width="124px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 70px; height: 38px;">
                </td>
                <td style="width: 142px; height: 38px;">
                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
            &nbsp;&nbsp;<asp:Button ID="Sign_In" runat="server" onclick="Sign_In_Click1" 
                        style="z-index: 1; left: 91px; top: 90px; position: absolute" Text="Sign_In" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 1px">
                    &nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
