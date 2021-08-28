<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addcreditcard.aspx.cs" Inherits="GUCera.addcreditcard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body style="background-color:cadetblue;">
    <form id="form1" runat="server" style="margin-left:20px;">
        <div>
            Enter Your ID<br />
            <asp:TextBox ID="SID" runat="server"></asp:TextBox>
            <br />
            Enter Your Credit Card Number<br />
            <asp:TextBox ID="Number" runat="server"></asp:TextBox>
            <br />
            Enter Card Holder Name<br />
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            <br />
            Enter Expiry Date<br />
            <asp:TextBox ID="Date" runat="server"></asp:TextBox>
            <br />
            Enter CVV<br />
            <asp:TextBox ID="CVV" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Submit" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Student Page" OnClick="SUBMIT_Click" />
        </div>
    </form>
</body>
</html>
