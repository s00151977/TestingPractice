<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SeleniumTestSite.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 131px">
    
        Enter Gender<asp:TextBox ID="TextGender" runat="server"></asp:TextBox>
    
    </div>
        <div style="width: 131px">Enter Age<asp:TextBox ID="TextAge" runat="server" TabIndex="1"></asp:TextBox></div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /></div>
    </form>
</body>
</html>
