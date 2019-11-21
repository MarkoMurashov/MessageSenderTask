<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sended.aspx.cs"
    Inherits="MessageSenderTask.Sended"  MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="SendedContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="mainForm">
        <asp:Label ID="lblResponse" runat="server" ></asp:Label>
        <asp:Button ID="btnBack" runat="server" CssClass="btnBack" PostBackUrl="~/Default.aspx"/>
    </div>
 </asp:Content>     