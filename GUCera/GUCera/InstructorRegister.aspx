<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorRegister.aspx.cs" Inherits="GUCera.InstructorRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Instructor Register</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Instructor Register</h2>
    <form id="form2" runat="server" style="margin-left:20px;">
        <div>
        </div>
        firstName<p>
            <asp:TextBox ID="firstName2" runat="server"></asp:TextBox>
        </p>
        <p>
            lastName</p>
        <asp:TextBox ID="lastName2" runat="server"></asp:TextBox>
        <br />
        password<p>
            <asp:TextBox ID="password2" runat="server"></asp:TextBox>
        </p>
        <p>
            gender
       </p>
        <p>
            <asp:DropDownList ID="gender2" runat="server">
                <asp:ListItem Value="0">Male</asp:ListItem>
                <asp:ListItem Value="1">Female</asp:ListItem>
            </asp:DropDownList>
        </p>
        <br />
        email<br />
        <asp:TextBox ID="email2" runat="server"></asp:TextBox>
        <p>
            address</p>
        <p>
            <asp:TextBox ID="address2" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;<asp:Button ID="register2" runat="server" class="btn btn-primary" OnClick="register4" Text="Register" />
        </p>
    </form>
</body>
</html>
