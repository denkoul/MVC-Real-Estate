<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VSearch.aspx.vb" Inherits="RealEstate.VSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button2" runat="server" Text="Back" />
        <br />
        <br />
        Search Filters<br />
        Type of property: <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" Width="26%" Height="37px" style="margin-bottom: 0px">
                <asp:ListItem Value="0">Empty Property</asp:ListItem>
                <asp:ListItem Value="1">Building</asp:ListItem>
                <asp:ListItem Value="2">Appartment</asp:ListItem>
            </asp:DropDownList>
                     <br />
        <br />
        Purpose:
            <asp:DropDownList ID="DropDownList1" runat="server" Width="26%" AutoPostBack="true" Height="39px">
                <asp:ListItem>Sell</asp:ListItem>
                <asp:ListItem>Rent</asp:ListItem>
            </asp:DropDownList>
                    <br />
        <br />
        Price: Min <asp:TextBox ID="price_more_than" runat="server"></asp:TextBox>
&nbsp;Max
        <asp:TextBox ID="price_less_than" runat="server"></asp:TextBox>
        <br />
        <br />
        Size: Min
        <asp:TextBox ID="size_more_than" runat="server"></asp:TextBox>
&nbsp;Max
        <asp:TextBox ID="size_less_than" runat="server"></asp:TextBox>
        <br />
        <br />
        (leave empty for no limit)<br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Search" />
        <br />
    
    </div>
        <asp:Table ID="Table1" runat="server" Height="18px" Width="100%">
        </asp:Table>
    </form>
</body>
</html>
