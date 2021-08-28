<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="promocodes.aspx.cs" Inherits="GUCera.promocodes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Promocodes</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <h2 style="color:black;text-align:center;">Promocodes</h2>
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            Enter Your ID<br />
            <asp:TextBox ID="SID" runat="server"></asp:TextBox>
&nbsp;<br />
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="View" Height="37px" OnClick="Button1_Click" Width="66px" />
&nbsp;
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Student Page" OnClick="Button2_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
