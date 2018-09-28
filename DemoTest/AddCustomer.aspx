<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="DemoTest.AddCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="form-group">
                <div class="col-md-12">
                    <label class="control-label" for="txtCustID">CustID</label>
                    <input  runat="server" class="text-box single-line" id="txtCustID" name="CustID" type="number" value="" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12">
                    <label class="control-label" for="txtCustName">CustName</label>
                    <input  runat="server" class="text-box single-line" id="txtCustName" name="CustName" type="text" value="" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-12">
                    <label class="control-label" for="txtCustEmail">CustEmail</label>
                    <input runat="server" class="text-box single-line" id="txtCustEmail" name="CustEmail" type="text" value="" />
                </div>
            </div>
            

            <div class="form-group">
                <div class="col-md-12">
                    <label class="control-label" for="drpCustPlanID">CustPlanID</label>
                    <asp:DropDownList id='drpCustPlanID'  runat="server">
					</asp:DropDownList>  
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-12">
                    <asp:Button runat="server" OnClick="btnAddCustomer_Click" ID="btnAddCustomer" Text="Submit" CssClass="btn btn-success" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
