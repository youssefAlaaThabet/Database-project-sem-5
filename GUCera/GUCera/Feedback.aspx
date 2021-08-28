<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="GUCera.Feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Feedback</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Feedback</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            Add Your Comment </div>
        <asp:TextBox ID="Comment" runat="server"></asp:TextBox>
        <br />
        Add The Course ID<br />
        <asp:TextBox ID="CID" runat="server"></asp:TextBox>
        <br />
        Add Your ID
        <br />
        <asp:TextBox ID="SID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SUMBIT" runat="server" class="btn btn-primary" Text="Submit" OnClick="SUMBIT_Click" Width="147px" />
        <br />
        <br />
        <asp:Button ID="SUBMIT" runat="server" class="btn btn-primary" Text="Student Page" OnClick="SUBMIT_Click" />
    </form>
</body>
</html>
