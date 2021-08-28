<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Define Assignments.aspx.cs" Inherits="GUCera.Define_Assigments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Define Assignments</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Define Assignments</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            <asp:Label ID="InstIDE" runat="server" Text="Instructor ID"></asp:Label>
        </div>
        <asp:TextBox ID="InstID2" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Course ID"></asp:Label>
        </p>
        <asp:TextBox ID="courseID2" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Assigment Number"></asp:Label>
        </div>
        <asp:TextBox ID="Assigmentnum" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Assigment Type"></asp:Label>
        </p>
        <asp:TextBox ID="AssigmentType" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Full Grade"></asp:Label>
        </div>
        <asp:TextBox ID="fullgrade" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Weight"></asp:Label>
        </p>
        <asp:TextBox ID="weight" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="Label6" runat="server" Text="Deadline"></asp:Label>
        </div>
        <asp:TextBox ID="deadline" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Content"></asp:Label>
        </p>
        <asp:TextBox ID="content" runat="server"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Submit" OnClick="DefineAssigmentforcourse" />
         <br />
            <br />
            <asp:Button ID="STUDENT" runat="server" class="btn btn-primary" Text="Instructor Page" OnClick="INSTRUCTOR_Click" Width="153px" />
            <br />
    </form>
</body>
</html>
