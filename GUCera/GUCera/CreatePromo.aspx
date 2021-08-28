<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePromo.aspx.cs" Inherits="GUCera.CreatePromo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Promocode</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Create Promocode</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            <asp:Label ID="Label1" runat="server" style="color:black;" Text="Code:"></asp:Label>
            <br />
            <asp:TextBox ID="Code1" runat="server" CssClass="alert-dark"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" style="color:black;" Text="IsuueDate:"></asp:Label>
            <br />
            <asp:TextBox ID="IssueDate1" runat="server" CssClass="alert-dark"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" style="color:black;" Text="ExpiryDate:"></asp:Label>
            <br />
            <asp:TextBox ID="ExpiryDate1" runat="server" CssClass="alert-dark"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" style="color:black;" Text="Discount:"></asp:Label>
            <br />
            <asp:TextBox ID="Discount1" runat="server" CssClass="alert-dark"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" style="color:black;" Text="AdminId:"></asp:Label>
            <br />
            <asp:TextBox ID="AdminId1" runat="server" CssClass="alert-dark"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" OnClick="Submitt" class="btn btn-primary" runat="server" Text="Submit" />
            <br />
            <br />
            <asp:Button ID="Button2" OnClick="AdminPage_Click" class="btn btn-primary" runat="server" Text="Back To Home Page" />
          </div>
    </form>
</body>
</html>
