<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Application3.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 50px;
        }
        .auto-style2 {
            margin-left: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Edit your password</div>
        <p>
            UserName:
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1" Width="159px"></asp:TextBox>
        </p>
        <p>
            Current Password:&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="165px"></asp:TextBox>
        </p>
        <p>
            New Password:&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style2" Width="161px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Change your password" />
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
