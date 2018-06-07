<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WEB.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href="css/reset.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/supersized.css" rel="stylesheet" />
</head>
<body>
  <div class="page-container">
        <h1>注册</h1>
    <form id="form1" runat="server" method="post">
        <asp:TextBox ID="username" runat="server" placeholder="用户名"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="username" ErrorMessage="!"></asp:RequiredFieldValidator>
        <asp:TextBox ID="password" runat="server" placeholder="密码"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password" ErrorMessage="!"></asp:RequiredFieldValidator>
        <asp:TextBox ID="email" runat="server"  placeholder="邮箱" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  ControlToValidate="email"  ErrorMessage="!"></asp:RequiredFieldValidator>
        <asp:TextBox ID="phone" runat="server" placeholder="电话"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"   ControlToValidate="phone"  ErrorMessage="!"></asp:RequiredFieldValidator>
        <asp:Button ID="Button1" runat="server" Text="注册" OnClick="Button1_Click" /><br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <div class="error"><span>+</span></div>
    </form>
        <div  class="connect">
            <p>Pet Home</p>
            <p>
                <a class="facebook" href="#"></a>
                <a class="twitter" href="#"></a>
            </p>
        </div>
    </div>
    <script src="../js/jquery-1.8.2.min.js"></script>
  
    <script src="../js/scripts.js"></script>
</body>
</html>
