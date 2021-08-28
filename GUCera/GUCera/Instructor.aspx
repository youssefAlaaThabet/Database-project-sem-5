<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instructor.aspx.cs" Inherits="GUCera.Instructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Instructor's Page</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Welcome To Instructor's Page</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" Height="65px" Width="205px" Text="ADD COURSE"  OnClick="gotoaddcourse"/>
            <br />
            <br />
        </div>
        <p>
            <asp:Button ID="Button2" runat="server" Height="65px" Width="205px" class="btn btn-primary" Text="DEFINE ASSINGNMENTS"  OnClick="gotodefineassignments" />
        </p>
        <asp:Button ID="Button3" runat="server" Height="65px" class="btn btn-primary" Text="VIEW ASSIGNMENTS" Width="205px" OnClick ="gotoviewassignments"/>
        <br />
        <br />
        <p>
            <asp:Button ID="Button4" runat="server" Height="65px" class="btn btn-primary" Text="GRADE ASSIGNMENTS" Width="205px" OnClick="gotogradeassignments" />
        </p>
        <asp:Button ID="Button5" runat="server" Height="65px" class="btn btn-primary" Text="VIEW FEEDBACK" Width="205px" OnClick="gotoviewfeedback"/>
        <br />
        <br />
        <p>
            <asp:Button ID="Button6" runat="server" Height="65px" class="btn btn-primary" Text="ISSUE CERTIFICATE" Width="205px" OnClick="gotoissuecertificate"/>
        </p>
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
            <asp:Button ID="Button7" runat="server" class="btn btn-primary" OnClick="AddMobile" Text="Add Mobile" Width="196px" />
            <br />
            <br />
            <br />
    </form>
</body>
</html>