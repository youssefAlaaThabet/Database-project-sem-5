<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewprofile.aspx.cs" Inherits="GUCera.viewprofile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Profile</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">View Profile</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            Write Your ID<br />
            <asp:TextBox ID="SID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="submit" OnClick="submit" />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
        <asp:Button ID="SUBMIT" runat="server" class="btn btn-primary" Text="Student Page" OnClick="SUBMIT_Click" />
        </div>
    </form>
</body>
</html>