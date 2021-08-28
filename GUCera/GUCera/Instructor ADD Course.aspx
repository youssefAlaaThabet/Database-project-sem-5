<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instructor ADD Course.aspx.cs" Inherits="GUCera.Instructor_ADD_Course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Instructor Add Course</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Instructor Add COurse</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            <asp:Label ID="addcoursecredithours" runat="server" Text=" Couse credithours"></asp:Label>
        </div>
        <asp:TextBox ID="addedcoursecredithours" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="addcoursename" runat="server" Text="Course Name"></asp:Label>
        </p>
        <asp:TextBox ID="addedcoursename" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="addcourseprice" runat="server" Text="Course Price"></asp:Label>
        </p>
        <asp:TextBox ID="addedcourseprice" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="instructorsid" runat="server" Text="Instructors ID"></asp:Label>
        </p>
        <asp:TextBox ID="instructorid" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="addcourse" runat="server" class="btn btn-primary" Text="Confirm Cousre" OnClick="addcourse_Click" />
        </p>
         <br />
            <br />
            <asp:Button ID="STUDENT" runat="server" class="btn btn-primary" Text="Instructor Page" OnClick="INSTRUCTOR_Click" Width="153px" />
            <br />
    </form>
</body>
</html>