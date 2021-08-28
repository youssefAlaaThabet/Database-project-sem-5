<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListAllCou.aspx.cs" Inherits="GUCera.ListAllCou" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List All Courses</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
     <h2 style="color:black;text-align:center;">List All Courses In The System</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            <asp:GridView ID="GridView1" CssClass="mygridview" runat="server" BackColor="#999999"></asp:GridView>
            <br />

            <asp:Button ID="AdminPage" runat="server" class="btn btn-primary" Text="Back To Home Page" OnClick="AdminPage_Click" />
        </div>
    </form>
    
</body>
</html>
