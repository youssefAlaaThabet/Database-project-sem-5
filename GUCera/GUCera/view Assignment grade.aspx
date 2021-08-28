<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view Assignment grade.aspx.cs" Inherits="GUCera.view_Assignment_grade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Assignment Grade</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">View Assignment Grade</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            Write Assignment Number<br />
            <asp:TextBox ID="Number" runat="server"></asp:TextBox>
            <br />
            Write Assignment Type<br />
&nbsp;<asp:TextBox ID="Type" runat="server"></asp:TextBox>
            <br />
            Write Course ID <br />
            <asp:TextBox ID="CID" runat="server"></asp:TextBox>
            <br />
            Write Your ID
            <br />
            <asp:TextBox ID="SID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Grade" runat="server" class="btn btn-primary" Text="View Grade" Width="161px" OnClick="Grade_Click" />
            <br />
            <br />
            <asp:Button ID="STUDENT" runat="server" class="btn btn-primary" Text="Student Page" OnClick="STUDENT_Click" Width="153px" />
            <br />
        </div>
    </form>
</body>
</html>
