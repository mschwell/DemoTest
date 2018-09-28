<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPlan.aspx.cs" Inherits="DemoTest.AddPlan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="form-group">
                <div class="col-md-12">
                    <label class="control-label" for="txtPlanID">PlanID</label>
                    <input runat="server" class="text-box single-line" id="txtPlanID" name="PlanID" type="number" value="" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12">
                    <label class="control-label" for="txtPlanName">PlanName</label>
                    <input runat="server" class="text-box single-line" id="txtPlanName" name="PlanName" type="text" value="" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-12">
                    <label class="control-label" for="txtPlanFixedCost">PlanFixedCost</label>
                    <input runat="server" class="text-box single-line" id="txtPlanFixedCost" name="PlanFixedCost" type="text" value="" />
                </div>
            </div>


            <div class="form-group">
                <div class="col-md-12">
                    <label class="control-label" for="txtPlanVarCost">PlanVarCost</label>
                    <input runat="server" class="text-box single-line" id="txtPlanVarCost" name="PlanVarCost" type="text" value="" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-12">
                    <asp:Button runat="server" OnClick="btnAddPlan_Click" ID="btnAddPlan" Text="Submit" CssClass="btn btn-success" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
