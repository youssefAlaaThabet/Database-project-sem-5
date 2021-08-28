<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NotAcceptedCou.aspx.cs" Inherits="GUCera.NotAcceptedCou" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Not Accepted Courses</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
     <h2 style="color:black;text-align:center;">Not Accepted Courses</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
             <asp:GridView ID="GridView2" CssClass="mygridview"  BackColor="#999999" runat="server"></asp:GridView>
             <br />
             <br />
            <asp:Label ID="Label1" runat="server" style="color:black;" Text="To Go To Accept Courses Page:"></asp:Label>
             <br />
            <asp:Button ID="Button3" OnClick="ToAcceptCourse" class="btn btn-primary" runat="server" Text="Go To Accept Courses Page" />
            <br />
            <br />
            <asp:Button ID="Button2" OnClick="AdminPage_Click" class="btn btn-primary" runat="server" Text="Back To Home Page" />
        </div>
    </form>
</body>
</html>
