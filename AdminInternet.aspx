<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminInternet.aspx.cs" Inherits="Advertiser.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 66px;
            height: 24px;
        }
        .style2
        {
            width: 133px;
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="height: 805px">
 <table>
            <tr>
                <td style="width: 360px; height: 19px;">
                    </td>
                <td style="width: 467px; height: 19px;">
                </td>
                <td style="width: 382px; height: 19px;">
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Blue" Style="left: 416px;
                        position: absolute; top: 157px; height: 28px;" Text="WELCOME ADMIN"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    &nbsp;
                    </td>
            </tr>
            <tr>
                <td colspan="3">
                    &nbsp;&nbsp;
                    
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="Red"
                    
                        Text="Internet Ads Registration" 
                        style="z-index: 1; left: 9px; top: 165px; position: absolute"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
  <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" 
        style="z-index: 1; left: 10px; top: 238px; position: absolute; height: 121px; width: 178px">
    </asp:GridView>
        <br />
        <asp:TextBox ID="TextBox4" runat="server" 
        style="z-index: 1; left: 135px; top: 388px; position: absolute"></asp:TextBox>
        <br />
        <table style="left: 164px; width: 672px; position: absolute; height: 166px; top: 852px;">
            <tr>
                <td colspan="3" style="text-align: center">
                    <span style="color: #0033ff"><span style="color: #0033ff"><span style="color: black">
                        Cant Find It!Search Now &nbsp;<br />
                    </span>
                        <img src="Images/Logo_25gry[1].gif" />
                        <br />
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
                        <asp:Button ID="Button2" runat="server" Text="SEARCH" /><br />
                        <br />
                        <span style="color: #0000ff"><a href="Home.aspx">HOME</a></span> | <span style="color: #0000cc">
                            <a href="adminradio.aspx">RADIO</a></span> |<a href="adminnewspaper.aspx">NEWSPAPER</a>|<a
                                href="adminmagazine.aspx">MAGAZINE</a>| <span style="color: #0000cc"><a href="admintv.aspx">
                                    TELEVISION<br />
                            <span></span></a></span>
                        <asp:Label ID="Label14" runat="server" ForeColor="Maroon" Style="left: 167px; top: 773px" Text="     Copyright ©2013-2017 Shaista"
                        Width="279px"></asp:Label><br />
                        <span style="color: black">
                        We are not responsible for the content of external websites. Images featured&nbsp;
                        on Ats-ads.com are copyright of their respective owners.<br />
                        </span></span></span>
                </td>
            </tr>
        </table>
    
    









    <asp:Button ID="Button3" runat="server" 
        style="z-index: 1; left: 66px; top: 446px; position: absolute; width: 67px; height: 34px" 
        Text="Delete"   />
    
    









</div>
    
    









    <asp:Label ID="Label15" runat="server" Text="Delete Record" 
        style="z-index: 1; left: 1px; top: 390px; position: absolute"></asp:Label>
    
    









</asp:Content>
