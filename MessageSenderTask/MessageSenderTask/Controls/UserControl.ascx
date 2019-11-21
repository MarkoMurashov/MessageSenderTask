<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl.ascx.cs" Inherits="MessageSenderTask.Controls.WebUserControl1" %>


<div class="mainForm">

<asp:Label ID="lbInValid" runat="server" Visible="false"></asp:Label>
<asp:Label ID="lbEmail" runat="server"  CssClass="emailLabel"></asp:Label>
<asp:TextBox ID="txtEmail" runat="server"  CssClass="emailInput"></asp:TextBox>
<asp:Label ID="lbMessage" runat="server" CssClass="messageLabel"></asp:Label>
<textarea ID="txtMessage" runat="server" class="messageInput" required></textarea>
<asp:Button ID="Send" runat="server" CssClass="btnSend" OnClick="Send_Click"/>

</div>