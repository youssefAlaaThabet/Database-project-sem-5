<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student page.aspx.cs" Inherits="GUCera.student_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student's Page</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Welcome To Student Page</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            <br />
            <asp:Button ID="Button1" runat="server" Height="61px" class="btn btn-primary" Text="View Profile" Width="181px" OnClick="viewprofile" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="View Available Courses" Height="62px" OnClick="viewcourses" Width="177px" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" class="btn btn-primary" Text="Enroll In Course" Height="61px" OnClick="EnrollCourse" Width="181px" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" class="btn btn-primary" Height="61px" OnClick="addcreditcard" Text="Add Credit Card" Width="181px" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" class="btn btn-primary" Text="Promo Codes Issues" OnClick="promocodes" Height="61px" Width="181px" />
            <br />
            <br />
            <asp:Button ID="view" runat="server" class="btn btn-primary" Height="61px" OnClick="viewAssign" Text="View Assignment" Width="181px" />
            <br />
            <br />
            <asp:Button ID="submit" runat="server" class="btn btn-primary" Height="56px" OnClick="submitAssign" Text="submit Assignment" Width="180px" />
            <br />
            <br />
            <asp:Button ID="grade" runat="server" class="btn btn-primary" Height="52px" OnClick="viewAssignGrades" Text="View Assignment Grade" Width="179px" />
            <br />
            <br />
            <br />
            <asp:Button ID="feedback" runat="server" class="btn btn-primary" Height="50px" OnClick="addFeedback" Text="Add Feedback" Width="178px" />
            <br />
            <br />
            <br />
            <asp:Button ID="certificates" runat="server" class="btn btn-primary" Height="61px" OnClick="viewCertificate" Text="View Certificates" Width="181px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Add Mobile Number (You can add more than one number, each one at a time):"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Your ID:"></asp:Label>
            <br />
            <asp:TextBox ID="Id" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Mobile Number:"></asp:Label>
            <br />
            <asp:TextBox ID="Mobile" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" class="btn btn-primary" OnClick="AddMobile" Text="Add Mobile" Width="196px" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>