<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcceptCou.aspx.cs" Inherits="GUCera.AcceptCou" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Accept Promocode</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    </head>
<body style="background-color:cadetblue;">
     <h2 style="color:black;text-align:center;">Accept Course</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <asp:Label ID="Label1" runat="server" style="color:black;" Text="Admin ID:"></asp:Label>
        <p>
            <asp:TextBox ID="AdminId" runat="server" CssClass="alert-dark"></asp:TextBox>
            </p>
        <p>
            <asp:Label ID="Label2" runat="server" style="color:black;" Text="Course ID:"></asp:Label>
        </p>
        <asp:TextBox ID="CourseId" runat="server" OnTextChanged="TextBox2_TextChanged" CssClass="alert-dark"></asp:TextBox>
        <br />
        <p>
            <asp:Button ID="Button1" OnClick="Submit" class="btn btn-primary" runat="server" Text="Submit" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" style="color:black;" Text="Go To Unaccepted Courses Page:"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button3" OnClick="ToUnacceptCourse" class="btn btn-primary" runat="server" Text="View Unaccepted Courses" Width="205px" />
        </p>
        <asp:Button ID="AdminPage" runat="server" class="btn btn-primary" Text="Back To Home Page" OnClick="AdminPage_Click" />
        <br />
        <br />
    </form>
</body>
</html>
