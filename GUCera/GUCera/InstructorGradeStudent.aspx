<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorGradeStudent.aspx.cs" Inherits="GUCera.InstructorGradeStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Instructor Grade Student</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Instructor Grade Student</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            <asp:Label ID="Label1" runat="server" Text="InstID"></asp:Label>
        </div>
        <asp:TextBox ID="InstID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="StudentID"></asp:Label>
        </p>
        <asp:TextBox ID="StudentID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="CourseID"></asp:Label>
        </p>
        <asp:TextBox ID="CourseID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Assigment Number"></asp:Label>
        </p>
        <asp:TextBox ID="AssigmentNumber" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Assigment Type"></asp:Label>
        </p>
        <asp:TextBox ID="AssigmentType" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Grade"></asp:Label>
        </p>
        <asp:TextBox ID="Grade" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Submit" OnClick="SubmitGrade" />
        </p>
         <br />
            <br />
            <asp:Button ID="STUDENT" runat="server" class="btn btn-primary" Text="Instructor Page" OnClick="INSTRUCTOR_Click" Width="153px" />
            <br />
    </form>
</body>
</html>
