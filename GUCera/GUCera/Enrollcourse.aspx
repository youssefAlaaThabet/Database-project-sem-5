<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Enrollcourse.aspx.cs" Inherits="GUCera.Enrollcourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Enroll In Course</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Enroll In Course</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            Enter StudentID<br />
            <asp:TextBox ID="SID" runat="server"></asp:TextBox>
            <br />
            Enter CourseID<br />
            <asp:TextBox ID="CID" runat="server"></asp:TextBox>
            <br />
            Enter IntructorID<br />
            <asp:TextBox ID="INID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Submit" Height="51px" Width="110px" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server"  class="btn btn-primary" Text="Student Page" OnClick="SUBMIT_Click" />
        </div>
    </form>
</body>
</html>