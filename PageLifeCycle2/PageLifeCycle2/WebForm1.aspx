<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PageLifeCycle2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Client Side Controls</h1>
        <div>
            <input type="text" />
            <input type="radio" />
            <input type="checkbox" />
            <input type="button" value="Button"/>
        </div>
        <h1>Server Side Controls</h1>
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RadioButton ID="RadioButton1" runat="server" />
            <asp:CheckBox ID="CheckBox1" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
        

    </form>
</body>
</html>
