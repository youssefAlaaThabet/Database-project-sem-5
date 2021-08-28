<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view Assignments.aspx.cs" Inherits="GUCera.view_Assignments" %>

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
    <h2 style="color:black;text-align:center;">View Assignments</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            Write Your course ID<br />
            <asp:TextBox ID="cid" runat="server"></asp:TextBox>
            <br />
            Write Your ID<br />
            <asp:TextBox ID="sid" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="viewass" runat="server" class="btn btn-primary" OnClick="submit" Text="View" Width="162px" />
        <br />
        <br />
        <br />
        <asp:Button ID="viewstupage" runat="server"  class="btn btn-primary" Text="StudentPage" OnClick="viewstupage_Click" Width="162px" />
            <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br>
        </br>
            </form>
    
</body>
</html>
