<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Issue Certificate.aspx.cs" Inherits="GUCera.Issue_Certificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Issue Certificate</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Issue Certificate</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            <asp:Label ID="Label1" runat="server" Text="CourseID"></asp:Label>
        </div>
        <asp:TextBox ID="cid" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="StudentID"></asp:Label>
        </p>
        <asp:TextBox ID="sid" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="InstructorID"></asp:Label>
        </p>
        <asp:TextBox ID="instid" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Issue Date"></asp:Label>
        </p>
        <asp:TextBox ID="issuedate" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Submit" OnClick="issuecertificate" />
        </p>
         <br />
            <br />
            <asp:Button ID="STUDENT" runat="server" class="btn btn-primary" Text="Instructor Page" OnClick="INSTRUCTOR_Click" Width="153px" />
            <br />
    </form>
</body>
</html>




