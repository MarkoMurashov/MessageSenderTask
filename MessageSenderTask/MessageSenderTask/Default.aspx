<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="MessageSenderTask.Default" MasterPageFile="~/MasterPage.Master" %>

<%@ Register Src="~/Controls/UserControl.ascx" TagPrefix="main" TagName="UserControl" %>

<asp:Content ID="DefaultContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">  
    <main:UserControl runat="server" id="UserControl"/>
</asp:Content>