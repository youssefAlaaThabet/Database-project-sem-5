<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewcourses.aspx.cs" Inherits="GUCera.viewcourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Courses</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">View Courses</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="view" Height="61px" Width="181px" />
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>

            <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Student Page" OnClick="SUBMIT_Click" />

        </div>
    </form>
</body>
</html>