<%@ Page Language="C#" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="update" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head><style>
    #container
    {
        font-family:Lucida Handwriting;
        font-style:oblique;
        color:brown;
        font-size:larger;
    }
   
table
{
    box-shadow:1px 4px;
    border-radius:12px 12px;
    margin-top:40px;
    width:400px;
    height:400px;
    padding:30px;
    background-color: papayawhip;
}</style>
<body>

<div id="container">
<span><center><h2>ONLINE GROCERY SHOPPING STORE</h2></center></span></div><center>

    <form id="form2" runat="server">
    
    <div>
    
    <table>
    <tr>
    <td><b>Sales_id</b></td>
    <td>
        <asp:TextBox ID="txtid" runat="server" BorderColor="Black" Height="50px" 
            ReadOnly="True"></asp:TextBox>
        </td></tr>
    <tr>
    <td><b>Fname</b></td>
    <td>
        <asp:TextBox ID="txtfname" runat="server" BorderColor="Black" Height="50px"></asp:TextBox>
        </td></tr>
    <tr>
    <td><b>Product Name</b></td>
    <td>
        <asp:DropDownList ID="txtpname" runat="server" Height="50px" Width="150px">
            <asp:ListItem>Rice</asp:ListItem>
            <asp:ListItem>Vegetables</asp:ListItem>
            <asp:ListItem>Fruits</asp:ListItem>
            <asp:ListItem>Biscuits</asp:ListItem>
            <asp:ListItem>Oil</asp:ListItem>
            <asp:ListItem>Cereals</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        </td></tr>
    <tr>
    <td><b>Price</b></td>
    <td>
        <asp:TextBox ID="txtprice" runat="server" BorderColor="Black" Height="50px"></asp:TextBox>
        </td></tr>
    <tr><td><b>Quantity</b></td>
    <td>
        <asp:TextBox ID="txtquantity" runat="server" BorderColor="Black" Height="50px"></asp:TextBox>
        </td></tr>
        <tr><td>
            
            <asp:Button ID="btnupdate" runat="server"  Text="UPDATE" 
                BackColor="Black" BorderColor="Black" BorderWidth="10px" ForeColor="White" 
                Height="50px" onclick="btnupdate_Click" />
            
            </td></tr>
            <tr><td>
                <asp:Label ID="lblinfo" runat="server"></asp:Label>
                </td></tr>
    </table>
    </div></center>
    </form>
<body>
    
</html>
