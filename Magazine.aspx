<%@ Page Title="" Language="C#" MasterPageFile="~/Adsmedium.Master" AutoEventWireup="true" CodeBehind="Magazine.aspx.cs" Inherits="Advertiser.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<table style="border-style: inset; border-color: inherit; border-width: thin; left: 251px; width: 529px; position: absolute; top: 166px; height: 684px;
            background-color: lightskyblue">
            <tr>
                <td colspan="2" style="height: 1px">
                    <span style="font-size: 14pt">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <span
                        style="font-family: Times New Roman">&nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;<span style="color: #00ff33"> <span style="color: #990000">
                            Advertise in Magazine</span></span></span><br />
                        <br />
                    </span>
                </td>
            </tr>
            <tr>
                <td style="width: 1px; height: 24px">
                    <asp:Label ID="Label1" runat="server" Text="Magazine Name: " Width="180px"></asp:Label></td>
                <td class="style1">
                    <asp:DropDownList
                ID="DD1" runat="server" style="left: 183px;">
                <asp:ListItem>Select One</asp:ListItem>
            </asp:DropDownList>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 1px; height: 40px">
                    <asp:Label ID="Label3" runat="server" Height="26px" Text="Advertise Date:" Width="192px"></asp:Label>
                    <asp:Label ID="Label4" runat="server" Text="From:"></asp:Label></td>
                <td class="style2">
                    <br />
                    <br />
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="Fdate" runat="server" TextMode="Date"
                        style="z-index: 1; left: 200px; top: 250px; position: absolute"></asp:TextBox>
&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 1px; height: 37px">
                    <asp:Label ID="Label5" runat="server" Text="To:"></asp:Label></td>
                <td class="style3">
                    <asp:TextBox ID="Tdate" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 1px; height: 37px">
                    <asp:Label ID="Label6" runat="server" Text="Advertising page: " Width="188px"></asp:Label></td>
                <td class="style3">
            <asp:DropDownList ID="DD2" runat="server" style="left: 184px;" >
                <asp:ListItem>NONE</asp:ListItem>
                <asp:ListItem>First page</asp:ListItem>
                <asp:ListItem>Middle Page</asp:ListItem>
                <asp:ListItem>Last Page</asp:ListItem>
            </asp:DropDownList>
                    <table id="TABLE1" onclick="return TABLE1_onclick()" 
                        style="left: 565px; width: 211px; position: absolute; top: -4px; margin-right: 16px;">
                        <tr>
                            <td style="background-color: #99ccff" colspan="3">
                                &nbsp; &nbsp; &nbsp;&nbsp; Advertise On This</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                    <img src="Images/Frontline_magazine_cover_1_Nov_2013.jpg" /></td>
                        </tr>
                        <tr>
                            <td style="background-color: #99ccff" colspan="3">
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                 <img src="Images/20140310_400.jpg" /><br />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="background-color: #99ccff">
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                        <img src="Images/akhbar-i-jahan-urdu-magazine.jpg" /><br />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="background-color: #99ccff">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="width: 1px; height: 37px">
                    <asp:Label ID="Label8" runat="server" Text="AdSize: "></asp:Label></td>
                <td class="style3">
            <asp:DropDownList ID="DD3" runat="server" style="left: 185px;" >
                <asp:ListItem>NONE</asp:ListItem>
                <asp:ListItem>50x50</asp:ListItem>
                <asp:ListItem>100x100</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
                    </td>
            </tr>
            <tr>
                <td style="width: 1px; height: 37px">
                    <asp:Label ID="Label9" runat="server" Text="Issues: "></asp:Label></td>
                <td class="style3">
            <asp:DropDownList ID="DD4" runat="server" Style="left: 185px;">
                <asp:ListItem>NONE</asp:ListItem>
                <asp:ListItem>Weekly</asp:ListItem>
                <asp:ListItem>Monthly</asp:ListItem>
            </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 1px; height: 37px">
                    <asp:Label ID="Label10" runat="server" Text="Pattern:  "></asp:Label></td>
                <td class="style3">
            <br />
                    <asp:RadioButtonList ID="RB1" runat="server" >
                        <asp:ListItem>MONO</asp:ListItem>
                        <asp:ListItem>COLOR</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td style="width: 1px; height: 20px">
                    <br />
                    <asp:Label ID="Label11" runat="server" Text="Price: "></asp:Label>
                    &nbsp; &nbsp;&nbsp;</td>
                <td class="style4">
                    <asp:TextBox ID="TB4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 1px; height: 28px">
                    <asp:Label ID="Label7" runat="server" Text="Upload Your File"></asp:Label></td>
                <td class="style5">
                    <asp:FileUpload ID="FileUp" runat="server" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    &nbsp;&nbsp;
                    <br />
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Button ID="Submit" runat="server" Text="SUBMIT" OnClick="Submit_Click"/>
                    <br />
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;

                    </td>
            </tr>
        </table>


</div>
</asp:Content>
