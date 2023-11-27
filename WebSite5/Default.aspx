<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr>
    <td>USER-ID</td>
    <td>
        <asp:TextBox ID="txtid" runat="server" ></asp:TextBox>
        </td></tr>
    <tr>
    <td>UserName</td>
    <td>
        <asp:TextBox ID="txtname" runat="server" ></asp:TextBox>
        </td></tr>
    <tr>
    <td>Password</td>
    <td>
        <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
        </td></tr>
    <tr>
    <td>Email</td>
    <td>
        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
        </td></tr>
    <tr>
    <td>City</td>
    <td>
        <asp:DropDownList ID="txtdrp" runat="server">
            <asp:ListItem>Tirunelveli</asp:ListItem>
            <asp:ListItem>Tuticorin</asp:ListItem>
            <asp:ListItem>Madurai</asp:ListItem>
            <asp:ListItem>Kerala</asp:ListItem>
            <asp:ListItem>Tenkasi</asp:ListItem>
            <asp:ListItem>Pudukottai</asp:ListItem>
            <asp:ListItem>Valliyoor</asp:ListItem>
            <asp:ListItem>Others</asp:ListItem>
        </asp:DropDownList>
        </td></tr>
        <tr>
        <td>
            <asp:Button ID="btnadd" runat="server" Text="ADD" onclick="btnadd_Click" />
            </td></tr>
            <tr><td>
                <asp:Label ID="lblinfo" runat="server"></asp:Label>
                </td></tr>

    </table>
    
    </div>
    </form>
</body>
</html>
