﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view Assignments Exams Projects.aspx.cs" Inherits="GUCera.view_Assigments_Exams_Projects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Assignments</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">View Assignments Exams, Projects and Quizzes</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            <asp:Label ID="Label1" runat="server" Text="InstID"></asp:Label>
        </div>
        <asp:TextBox ID="InstID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Course"></asp:Label>
        </p>
        <asp:TextBox ID="cid" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="submit" OnClick="ShowstudentsAssigments" />
        </p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
         <br />
            <br />
            <asp:Button ID="STUDENT" runat="server" class="btn btn-primary" Text="Instructor Page" OnClick="INSTRUCTOR_Click" Width="153px" />
            <br />
    </form>
</body>
</html>
