
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registar.aspx.cs" Inherits="Application3.Registar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        
            <p ><font size ="5" face="Gisha" color="Gray"> Register</font></p>
            <p />
            UserName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
        <p>
            Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </p>
        <p>
            Phone Number&nbsp; <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
            <asp:Button ID="Button1" runat="server" Text="Sing Up" OnClick="Button1_Click" />
            <p>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </p>
    </form>
</body>
</html>
