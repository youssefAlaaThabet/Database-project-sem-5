<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegister.aspx.cs" Inherits="GUCera.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Register</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Student Register</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
        </div>
        firstName<p>
            <asp:TextBox ID="firstName1" runat="server"></asp:TextBox>
        </p>
        <p>
            lastName</p>
        <asp:TextBox ID="lastName1" runat="server"></asp:TextBox>
        <br />
        password<p>
            <asp:TextBox ID="password1" runat="server"></asp:TextBox>
        </p>
        <p>
            Gender
            </p>
        <asp:DropDownList ID="gender1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="0">Male</asp:ListItem>
            <asp:ListItem Value="1">Female</asp:ListItem>
        </asp:DropDownList>
        <br />
        email<br />
        <asp:TextBox ID="email1" runat="server"></asp:TextBox>
        <p>
            address</p>
        <p>
            <asp:TextBox ID="address1" runat="server"></asp:TextBox>
            </p>
        <p>
            <asp:Button ID="register1" runat="server" class="btn btn-primary" OnClick="register3" Text="Register" />
        </p>
        <p>
&nbsp;</p>
    </form>
</body>
</html>
