<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListCustomersAndPlan.aspx.cs" Inherits="DemoTest.ListCustomersAndPlan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <asp:Repeater ID="ListCustomersAndPlans" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-bordered table-hover table-condensed">
                        <tr>
                            <th><strong>CustID</strong></th>
                            <th><strong>CustName</strong></th>
                            <th><strong>CustEmail</strong></th>
                            <th><strong>PlanName</strong></th>
                            <th><strong>PlanFixedCost</strong></th>
                            <th><strong>PlanVarCost</strong></th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("CustID") %> </td>
                        <td><%# Eval("CustName") %> </td>
                        <td><%# Eval("CustEmail") %> </td>
                        <td><%# Eval("PlanName") %> </td>
                        <td><%# Eval("PlanFixedCost") %> </td>
                        <td><%# Eval("PlanVarCost") %> </td>
                    </tr>
                </ItemTemplate>
                <AlternatingItemTemplate>
                    <tr>
                        <td><%# Eval("CustID") %> </td>
                        <td><%# Eval("CustName") %> </td>
                        <td><%# Eval("CustEmail") %> </td>
                        <td><%# Eval("PlanName") %> </td>
                        <td><%# Eval("PlanFixedCost") %> </td>
                        <td><%# Eval("PlanVarCost") %> </td>
                    </tr>
                </AlternatingItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-4">
            <a href="AddCustomer.aspx" class="btn btn-success">Add Customer</a>
        </div>
        <div class="col-xs-4">
            <a href="AddPlan.aspx" class="btn btn-success">Add Plan</a>
        </div>
    </div>
</asp:Content>
