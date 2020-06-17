<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hellow.aspx.cs" Inherits="Application3.Hellow" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 37px;
        }
    </style>
</head>
<body style="height: 46px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Edit Password" />
        </p>
    </form>
</body>
</html>
