<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Email.aspx.cs" Inherits="DemoTest.Email" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="form-group">
                <div class="col-md-12">
                    <label class="control-label" for="drpCustID">Select Customer:</label>
                    <asp:DropDownList ID='drpCustID' runat="server">
                    </asp:DropDownList>  
                    <asp:Button runat="server" OnClick="btnPreview_Click" ID="btnPreview" Text="Preview" CssClass="btn btn-success" />
            
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-12">
                    <span runat="server" id="spnTo" value="" />
                    <br />
                    <span runat="server" id="spnSubj" value="" />
                    <br />
                    <span runat="server" id="spnBody" value="" />
                </div>
            </div>
            
            <div class="form-group">
                <div class="col-md-12">
                    <asp:Button runat="server" OnClick="btnSendEmail_Click" ID="btnSendEmail" Text="Send" CssClass="btn btn-success" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
