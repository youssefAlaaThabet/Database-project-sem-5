<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admins.aspx.cs" Inherits="GUCera.Admins" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Page</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Welcome To The Admin's Page</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="List all courses in the system:" style="color:black;"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="ListallCourses" class="btn btn-primary" Text="List all Courses" Width="225px" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="List all the courses added by instructors not yet accepted:" style="color:black;"></asp:Label>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="NotAcceptedCourses" class="btn btn-primary" Text="Not Accepted Courses" Width="225px" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Accept any of the requested courses that are added by instructors:" style="color:black;"></asp:Label>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="AcceptCourses" class="btn btn-primary" Text="Accept Courses" Width="215px" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Create new Promo codes by inserting all promo code details:" style="color:black;"></asp:Label>
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="CreateNewPromocode" class="btn btn-primary" Text="Create New Promocode" Width="225px" />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Issue the promo code created to any student:" style="color:black;"></asp:Label>
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="IssuePromocodeToStudent" class="btn btn-primary" Text="Issue Promocode To Student" Width="225px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Add Mobile Number (You can add more than one number, each one at a time):" style="color:black;"></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server" style="color:black;" Text="Your ID:"></asp:Label>
            <br />
            <asp:TextBox ID="Id" runat="server" CssClass="alert-dark" Width="200px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" style="color:black;" Text="Mobile Number:"></asp:Label>
            <br />
            <asp:TextBox ID="Mobile" runat="server" CssClass="alert-dark" Width="200px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" OnClick="AddMobile" class="btn btn-primary" Text="Add Mobile" Width="225px" />
            <br />
        </div>
    </form>
</body>
</html>
