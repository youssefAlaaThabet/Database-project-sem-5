<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssuePromo.aspx.cs" Inherits="GUCera.IssuePromo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Issue Promocode</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
     <h2 style="color:black;text-align:center;">Issue Promocode</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            <asp:Label ID="Label1" runat="server" style="color:black;" Text="Student ID:"></asp:Label>
            <br />
            <asp:TextBox ID="StudentId" runat="server" CssClass="alert-dark"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" style="color:black;" Text="Code:"></asp:Label>
            <br />
            <asp:TextBox ID="PromoCode" runat="server" CssClass="alert-dark"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" OnClick="Submit" class="btn btn-primary" runat="server" Text="Submit" />
            <br />
            <br />
            <asp:Button ID="Button2" OnClick="AdminPage_Click" class="btn btn-primary" runat="server" Text="Back To Home Page" />
        </div>
    </form>
</body>
</html>
