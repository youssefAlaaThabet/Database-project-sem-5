<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="submit Assignment.aspx.cs" Inherits="GUCera.submit_Assignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Submit Assignment</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Submit Assignment</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            Write Assignment Type:</div>
        <asp:TextBox ID="Type" runat="server"></asp:TextBox>
        <br />
        Write Assignment Number:<br />
        <asp:TextBox ID="Number" runat="server"></asp:TextBox>
        <br />
        Write Your ID<br />
        <asp:TextBox ID="SID" runat="server"></asp:TextBox>
        <br />
        Write Course ID<br />
        <asp:TextBox ID="CID" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="submitass" runat="server" class="btn btn-primary" Text="Submit" OnClick="submitass_Click" />
        
        <br />
        
        <br />
        <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Text="Student Page" Width="107px" />
        <br />
    </form>
</body>
</html>
