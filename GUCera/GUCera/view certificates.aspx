<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view certificates.aspx.cs" Inherits="GUCera.view_certificates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Certificates</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">View Certificates</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            Write Course ID
            <br />
            <asp:TextBox ID="CID" runat="server"></asp:TextBox>
            <br />
            Write Your ID
            <br />
            <asp:TextBox ID="SID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="SUBMIT" runat="server" class="btn btn-primary" Text="View" OnClick="SUBMIT_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="STUDENT" runat="server" class="btn btn-primary" Text="Student Page" OnClick="viewstupage_Click"/>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
