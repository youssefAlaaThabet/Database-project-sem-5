<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="GUCera.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 1517px;
            height: 412px;
        }
    </style>
</head>
<body style="background-color:cadetblue;">
    <form id="form1" runat="server">
    <h2 style="color:black;text-align:center;">Welcome To GUCera</h2>
        <div>
            UserName:<br />
            <asp:TextBox ID="Username" runat="server"></asp:TextBox>
            <br />
            Password:<br  />
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            <asp:Button ID="signin" runat="server" class="btn btn-primary" OnClick="Login" Text="log in" />
            <br />
            If you do not have an account Please register! <br />
            <p>
            <asp:Button ID="student" runat="server" class="btn btn-primary" OnClick="Register1" Text="Register As Student" />
            <asp:Button ID="instructor" runat="server" class="btn btn-primary" OnClick="Register2" Text="Register As Instructor" />
        </p>
            <p>
                &nbsp;</p>
            <img alt="GUCera image" class="auto-style1" src="Images/Untitled3.png" /></div>
        
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
